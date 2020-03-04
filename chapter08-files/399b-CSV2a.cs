//Jose Valera 1ºDAM

using System;
using System.IO;

class EjConNota
{
    static void Main()
    {
        Console.Write("Ruta: ");
        string ruta = Console.ReadLine();

        StreamReader entrada;
        StreamWriter salida;

        try
        {
            entrada = File.OpenText(ruta);
            salida = File.CreateText("resultado.txt");
            string fila;

            do
            {
                fila = entrada.ReadLine();

                if(fila != null)
                {
                    fila = fila.Replace("\";", Environment.NewLine).Replace("\"", "");
                }

                salida.WriteLine(fila);
                salida.WriteLine();
            }
            while (fila != null);

            entrada.Close();
            salida.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
        }

        catch (IOException)
        {
            Console.WriteLine("I/O error");
        }

        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
