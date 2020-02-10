// Pablo Vigara Fernandez

using System;
using System.IO;
using System.Collections.Generic;

class Encriptador
{
    public string Encriptar(string texto)
    {
        string codigo = "";
        foreach (char c in texto)
        {
            codigo += (char)(c + 1);
        }
        return codigo;
    }

    public string Desencriptar(string codigo)
    {
        string texto = "";
        foreach (char c in codigo)
        {
            texto += (char)(c - 1);
        }
        return texto;
    }
}

class PruebaDeEncriptador
{
    static void Main()
    {
        Encriptador e = new Encriptador();
        string fileName = "dup.txt";
        Queue<string> queue1 = new Queue<string>(
            File.ReadAllLines(fileName) );
               
        int total = queue1.Count;
        for (int i = 0; i < total; i++)
        {
            Console.WriteLine(e.Encriptar(queue1.Dequeue()));
        }
    }
}
