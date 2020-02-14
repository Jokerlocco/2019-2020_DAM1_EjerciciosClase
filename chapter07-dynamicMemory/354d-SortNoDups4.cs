using System;
using System.Collections.Generic;
using System.IO;

class ColaPrueba
{
    static void Main()
    {
        Dictionary<string, bool> lista = new Dictionary<string, bool>();

        string path = "1.txt";
        string[] data = File.ReadAllLines(path);

        for (int i = 0; i < data.Length; i++)
        {
            if (!lista.ContainsKey(data[i]))
                lista.Add(data[i], true);
        }

        //foreach(string s in lista.Keys)
        //    Console.Write(s);

        //List<string> lines = new List<string>(lista.Keys);
        //lines.Sort();

        string[] lines = new string[lista.Keys.Count];
        lista.Keys.CopyTo(lines, 0);
        Array.Sort(lines);
        File.WriteAllLines("2.txt", lines);
    }
}
