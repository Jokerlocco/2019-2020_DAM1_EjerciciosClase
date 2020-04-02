// Kiko
using System;
using System.Collections.Generic;
using System.IO;
 
class Directorios

{
    static void Main()
    {
        SortedSet<string> ficheros = new SortedSet<string>();
        string[] ficherosCs = Directory.GetFiles(".", "*.cs");
        string[] ficherosJava = Directory.GetFiles(".", "*.java");
 
        ficheros.UnionWith(ficherosCs);
        ficheros.UnionWith(ficherosJava);
 
        foreach (string fichero in ficheros)
            Console.WriteLine(fichero);
    }
}
