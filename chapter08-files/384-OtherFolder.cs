// Joel Martinez Sanchez

using System;
using System.IO;

class rutas
{
    static void Main()
    {
        StreamReader input = File.OpenText(@"..\..\..\Pruebas.sln");
        string linea = "";
        do
        {
            linea = input.ReadLine();

            if (linea != null)
            {
                Console.WriteLine(linea);
            }

        } while (linea != null);
        input.Close();
    }
}
