// Joel Martinez Sanchez
using System;
using System.IO;

class CabeceraDBF
{
    static void Main()
    {
        Console.Write("Introduce el nombre del DBF: ");
        string ruta = Console.ReadLine();

        try
        {
            FileStream archivo = File.OpenRead(ruta);
            archivo.Seek(8, SeekOrigin.Begin);
            byte tamanyoTotal = (byte)archivo.ReadByte();
            byte tamanyoCampos = (byte) (tamanyoTotal - 32);
            byte cantidadCampos = (byte) (tamanyoCampos / 32);
            archivo.Seek(32, SeekOrigin.Begin);

            for (int i = 0; i < cantidadCampos; i++)
            {
                byte[] campos = new byte[32];
                archivo.Read(campos, 0, 32);
                
                for (int e = 0; e < 11; e++)
                {
                    Console.Write((char) campos[e]);
                }
                Console.WriteLine();
            }
            archivo.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Ruta demasiado larga");
        }
        catch (IOException)
        {
            Console.WriteLine("Error I/O");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }

    }
}
