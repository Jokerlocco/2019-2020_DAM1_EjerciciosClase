//Pablo Conde - 2/4/2020

using System;
using System.IO;
using System.Collections.Generic;

class ListaFuentesConTamanyo
{
    static void Main()
    {
        DirectoryInfo dir = new DirectoryInfo(".");
        FileInfo[] infoFicherosCs = dir.GetFiles("*.cs");
        FileInfo[] infoFicherosJv = dir.GetFiles("*.java");

        SortedList<string, long> listaFicheros = new SortedList<string, long>();

        for (int i = 0; i < infoFicherosCs.Length; i++)
        {
            listaFicheros.Add(infoFicherosCs[i].Name, infoFicherosCs[i].Length);          
        }

        for (int i = 0; i < infoFicherosJv.Length; i++)
        {
            listaFicheros.Add(infoFicherosJv[i].Name, infoFicherosJv[i].Length);
        }

        foreach (KeyValuePair <string, long> f in listaFicheros)
            Console.WriteLine(f.Key + " (" 
            + Math.Ceiling(f.Value / 1024.0) + " KB)");
    }
}
