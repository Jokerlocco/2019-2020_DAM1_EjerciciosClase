//Kiko 
using System;
using System.IO;


class ReadWriteGif
{
    static void Main()
    {
        Console.WriteLine("Type the path:");
        string path = Console.ReadLine();

        if (!File.Exists(path))
        {
            Console.WriteLine("Path does not exists.");
        }
        else
        {
            try
            {
                FileStream data = 
                    File.Open(path, FileMode.Open, FileAccess.ReadWrite);
                    
                byte[] aux = new byte[3];
                data.Read(aux, 0, 3);

                byte auxByte = aux[0];
                aux[0] = aux[2];
                aux[2] = auxByte;
                
                data.Seek(0, SeekOrigin.Begin);
                data.Write(aux, 0, 3);
                
                data.Close();
                Console.Clear();
                
                Console.WriteLine("Encrypt/Decrypt done properly.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("path too long");
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
}

