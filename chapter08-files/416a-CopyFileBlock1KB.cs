//Jose Valera 1ºDAM

using System;
using System.IO;

class CopyFileBlock1KB //Ej05CuarentenicaRicaRica
{
    static void Main()
    {
        const int BLOCK_SIZE = 1000;

        Console.Write("Path: ");
        string path = Console.ReadLine();
        string path2 = path + ".txt";

        FileStream input;
        FileStream output;

        try
        {
            if (!File.Exists(path))
                Console.WriteLine("Input not found");
            else if (File.Exists(path2))
                Console.WriteLine("Output name exists");
            else
            {
                input = File.OpenRead(path);
                output = File.Create(path2);

                byte[] data = new byte[BLOCK_SIZE];
                int readBytes;

                do
                {
                    readBytes = input.Read(data, 0, BLOCK_SIZE);
                    output.Write(data, 0, readBytes);
                }
                while (readBytes == BLOCK_SIZE);

                output.Close();
                input.Close();
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
