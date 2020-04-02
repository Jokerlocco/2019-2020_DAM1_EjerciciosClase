//Pablo Conde - 2/4/2020


using System;
using System.IO;
using System.Collections.Generic;

class ListaFuentes
{
    static void Main()
    {
        string[] listaFicherosCs = Directory.GetFiles(".", "*.cs");
        string[] listaFicherosJv = Directory.GetFiles(".", "*.java");
        
        List<string> listaFicheros = new List<string>(listaFicherosCs);
        listaFicheros.AddRange(listaFicherosJv);

        listaFicheros.Sort();
        foreach (string fichero in listaFicheros)
            Console.WriteLine(fichero);
    }
}
