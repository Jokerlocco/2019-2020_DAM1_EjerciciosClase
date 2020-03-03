//Pablo Conde


using System;
using System.Collections.Generic;


class SortedListSS
{
    protected string[] claves;
    protected string[] valores;
    int contador;
    
    public int Count { get { return contador; } }
    
    public SortedListSS()
    {
        claves = new string[1000];
        valores = new string[1000];
        contador = 0;
    }
    
    public void Add (string clave, string valor)
    {
        claves[contador] = clave;
        valores[contador] = valor;
        contador++;
        
        for (int i = 0; i < contador - 1; i++)
        {
            for (int j = i+1; j < contador; j++)
            {
                if(claves[i].CompareTo(claves[j]) > 0)
                {
                    string aux = claves[i];
                    claves[i] = claves[j];
                    claves[j] = aux;
                    
                    string aux2 = valores[i];
                    valores[i] = valores[j];
                    valores[j] = aux2;
                }
            }
        }
    }
    
    public string GetKey(int num)
    {
        if(num < contador)
            return claves[num];
        else
            return "Posición no válida";
    }
    
    public string GetValue(int num)
    {
        if(num < contador)
            return valores[num];
        else
            return "Posición no válida";
    }
    
    public bool Contains(string clave)
    {
        bool contiene = false;
        
        for (int i = 0; i < contador; i++)
        {
            if(claves[i] == clave)
                contiene = true;
        }
        
        return contiene;
    }
    
    public string GetByKey(string clave)
    {
        int posicion = -1;
        
        for (int i = 0; i < contador; i++)
        {
            if(claves[i] == clave)
                posicion = i;
        }
        
        return valores[posicion];
    }
}

class SortedListPrueba
{
    static void Main()
    {
        SortedListSS lista = new SortedListSS();
        
        lista.Add("uno", "dos");
        lista.Add("antes", "despues");
        lista.Add("mesa", "silla");
        
        Console.WriteLine("uno? "+ lista.Contains("uno"));
        Console.WriteLine("diez? " + lista.Contains("diez"));
        
        Console.WriteLine("uno = " + lista.GetByKey("uno"));
        
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista.GetKey(i) + " -> " + lista.GetValue(i));
        }
    }
}
