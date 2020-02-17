//Pablo Conde

using System;
using System.Collections.Generic;

class SetOfString
{
    protected List<string> miLista;
    public int Count { get { return miLista.Count; } }

    public SetOfString()
    {
        miLista = new List<string>();
    }
    
    public void Add(string cadena)
    {
        if (!miLista.Contains(cadena))
            miLista.Add(cadena);
    }
    
    public bool Contains(string cadena)
    {
        return miLista.Contains(cadena);
    }

}

class ListTest
{
    static void Main()
    {
        SetOfString lista = new SetOfString();
       
        lista.Add("perro");
        lista.Add("gato");
        lista.Add("pato");
        
        Console.WriteLine(lista.Contains("gato"));
      
    }
}
