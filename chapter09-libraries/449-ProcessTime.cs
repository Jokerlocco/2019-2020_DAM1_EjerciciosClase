//Daniel García

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

class MedirTiempos
{
    static void Main(string[] args)
    {
        string nombre;
        if (args.Length == 0)
        {
            Console.WriteLine("No se ha indicado ningún parámetro");
            Console.WriteLine("Nombre del proceso?");
            nombre = Console.ReadLine();
        }
        else
        {
            nombre = args[0];
        }
        
        DateTime inicio = DateTime.Now;
        Process programa = Process.Start(nombre);
        programa.WaitForExit();
        
        DateTime final = DateTime.Now;        
        TimeSpan tiempo = final.Subtract(inicio);
        Console.WriteLine("Ha tardado " + tiempo.TotalMilliseconds
            + " milisegundos en ejecutarse el programa " + nombre);
    }
}


