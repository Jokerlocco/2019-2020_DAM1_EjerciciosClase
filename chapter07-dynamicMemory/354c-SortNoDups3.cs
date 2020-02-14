// Pablo Vigara Fernandez

using System;
using System.Collections.Generic;
using System.IO;

class ColaPrueba
{
    static void Main()
    {
        SortedList<string, bool> lista = new SortedList<string, bool>();

        string path = "1.txt";
        string[] data = File.ReadAllLines(path);

        for (int i = 0; i < data.Length; i++)
        {
            if (!lista.ContainsKey(data[i]))
                lista.Add(data[i], true);
        }

        File.WriteAllLines("2.txt", lista.Keys);
    }
}
