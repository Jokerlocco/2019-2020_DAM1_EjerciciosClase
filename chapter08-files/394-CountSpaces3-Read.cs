// Pablo Vigara Fernandez

using System;
using System.IO;

class Ejercicio
{
    static void Main()
    {
        Console.Write("Nombre del archivo: ");
        string path = Console.ReadLine();

        try
        {
            FileStream fich = new FileStream(path, FileMode.Open);            
            int cantidadALeer = (int) fich.Length;
            byte[] datos = new byte[cantidadALeer];
            int cantidadLeida = fich.Read(datos, 0, cantidadALeer);
            fich.Close();
            
            if (cantidadLeida != cantidadALeer)
                Console.WriteLine("Read error!");

            int count = 0;
            for (long i = 0; i < datos.Length; i++)
            {
                if (datos[i] == ' ')
                    count++;
            }
            Console.Write("Espacios: " + count);

            
        }
        catch (Exception e) { Console.WriteLine("Error: " + e.Message); }
    }
}
