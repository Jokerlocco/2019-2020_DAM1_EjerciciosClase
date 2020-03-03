//Lautaro Álvaro Fernández

using System;
using System.IO;

class SortedListSS
{
    private string[] keys;
    private string[] values;
    
    private int count;
    public int Count { get { return count; } }
    
    public SortedListSS()
    {
        keys = new string[100];
        values = new string[100];
        
        count = 0;
    }
    
    public void Add( string key, string val)
    {
        for ( int i = 0; i < count; i++)
        {
            if ( keys[i].CompareTo(key) >= 0 )
            {
                for ( int j = count+1; j > i; j--)
                {
                    keys[j] = keys[j-1];
                    values[j] = values[j-1];
                }
                keys[i] = key;
                values[i] = val;
                count++;
                return;
            }   
        }
        keys[count] = key;
        values[count] = val;
        count++; 
    }
    
    public string GetKey( int pos )
    {
        return keys[pos];
    }
    
    public string GetValue( int pos )
    {
        return values[pos];
    }
    
    public bool Contains( string key )
    {
        for ( int i = 0; i < keys.Length; i++)
        {
            if ( keys[i] == key )
            {
                return true;
            }
        }
        
        return false;
    }
    
    public string GetByKey( string key )
    {       
        for ( int i = 0; i < keys.Length; i++)
        {
            if ( keys[i] == key )
                return values[i];
        }
        return "";
    }
}

class Test
{
    static void Main()
    {
        SortedListSS s = new SortedListSS();
        
        s.Add("Naranja", "Fruta");
        s.Add("Pimiento", "Verdura");
        s.Add("Cacahuete", "Fruto seco");
        
        if ( s.Contains("Naranja") )
            Console.WriteLine("Contiene Naranja con el valor: " 
                + s.GetByKey("Naranja"));
        else
            Console.WriteLine("No contiene Naranja");
        
        if ( s.Contains("Mesa") )
            Console.WriteLine("Contiene Mesa con el valor: " 
                + s.GetByKey("Mesa"));
        else
            Console.WriteLine("No contiene Mesa");
            
        Console.WriteLine();
        Console.WriteLine("Contenido: ");    
        for ( int i = 0; i < s.Count; i++)
        {
            Console.WriteLine( s.GetKey(i) + " -> " + s.GetValue(i) );
        }
    }
} 
