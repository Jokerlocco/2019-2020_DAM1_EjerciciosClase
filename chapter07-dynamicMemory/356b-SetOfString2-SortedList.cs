using System;
using System.Collections.Generic;

class SetOfString // V2: SortedList
{
    protected SortedList<string, string> miLista;
    public int Count { get { return miLista.Count; } }

    public SetOfString()
    {
        miLista = new SortedList<string, string>();
    }

    public void Add(string cadena)
    {
        if (!miLista.ContainsKey(cadena))
            miLista.Add(cadena, cadena);
    }

    public bool Contains(string cadena)
    {
        return miLista.ContainsKey(cadena);
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
