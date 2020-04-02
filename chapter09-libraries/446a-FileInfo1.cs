// Cristina Francés

using System;
using System.IO;
using System.Collections.Generic;

class ListaFuentesTam
{
    static void Main()
    {
        DirectoryInfo directorio = new DirectoryInfo(".");
        FileInfo[] listaCS= directorio.GetFiles("*.cs");
        FileInfo[] listaJava= directorio.GetFiles("*.java");
        List<string> ficheros = new List<string>();
        
        foreach (FileInfo info in listaCS)
        {
            ficheros.Add(info.Name + " (" + info.Length + " KB)");
        }
        foreach (FileInfo info in listaJava)
        {
            ficheros.Add(info.Name + " (" + info.Length + " KB)");
        }

        ficheros.Sort();
        for (int i = 0; i < ficheros.Count; i++)
        {
            Console.WriteLine(ficheros[i]);
        }
    }
}
