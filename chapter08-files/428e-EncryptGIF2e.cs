//Jose Valera 1ºDAM

using System;
using System.IO;

class GifFig //Ej16CuarentenicaRicaRica
{
    static void Main()
    {
        Console.Write("Path: ");
        string path = Console.ReadLine();
        FileStream file;

        try
        {
            if (!File.Exists(path))
                Console.WriteLine("The file not exist");

            else
            {
                file = File.Open(path, FileMode.Open, FileAccess.ReadWrite);

                string init = "";
                init += Convert.ToChar(file.ReadByte());
                init += Convert.ToChar(file.ReadByte());
                init += Convert.ToChar(file.ReadByte());

                byte[] datos = new byte[file.Length - 3];
                file.Read(datos, 0, (int)file.Length - 3);

                file.Seek(0,SeekOrigin.Begin);

                if (init == "GIF")
                {
                    file.WriteByte(Convert.ToByte('F'));
                    file.WriteByte(Convert.ToByte('I'));
                    file.WriteByte(Convert.ToByte('G'));
                }

                else if (init == "FIG")
                {
                    file.WriteByte(Convert.ToByte('G'));
                    file.WriteByte(Convert.ToByte('I'));
                    file.WriteByte(Convert.ToByte('F'));
                }

                else
                    Console.WriteLine("This is not a gif file");

                file.Close();
            }
        }
        catch (PathTooLongException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
