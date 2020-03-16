// Pablo Vigara Fernandez

using System;
using System.IO;

class Ejercicio3
{
    static void Main()
    {
        try
        {
            FileStream output = File.Create("prueba.txt");

            for (int i = 0; i < 100; i++)
            {
                output.WriteByte(97);
            }
            output.Close();
            Console.WriteLine("Fichero prueba.txt creado correctamente");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
 
