// Joel Martinez Sanchez
using System;
using System.IO;

class InvertirUnFicheroFileStreamBloque
{
    static void Main()
    {
        string ruta;

        Console.Write("Introduce el nombre del fichero: ");
        ruta = Console.ReadLine();
      
        if (File.Exists(ruta))
        {
            try
            {
                FileStream input = File.OpenRead(ruta);
                FileStream output = File.OpenWrite(ruta + ".inv");

                byte[] datos = new byte[input.Length];
                input.Read(datos, 0, (int)input.Length);
                Array.Reverse(datos);

                output.Write(datos, 0, datos.Length);

                input.Close();
                output.Close();
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
}
