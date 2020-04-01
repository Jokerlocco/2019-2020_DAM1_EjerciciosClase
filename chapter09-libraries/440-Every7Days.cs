// Gonzalo Arques

using System;
using System.IO;

class Programa
{
    static void Main()
    {
        StreamWriter fichero = File.CreateText("tasks.txt");

        DateTime tiempoActual = DateTime.Now;
        DateTime finalAnyo = new DateTime(2020, 12, 31);

        while (tiempoActual <= finalAnyo)
        {
            fichero.WriteLine(tiempoActual.ToString("d") + ": ");
            tiempoActual = tiempoActual.AddDays(7);
        }

        fichero.Close();
        Console.WriteLine("El fichero se ha creado correctamente.");
    }
}