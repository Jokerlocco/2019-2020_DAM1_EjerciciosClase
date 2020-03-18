// Pablo Vigara Fernandez

using System;
using System.IO;

class Ejercicio3
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Invalid num of arguments");
            return;
        }

        if (!File.Exists(args[0]))
        {
            Console.WriteLine("Input file not found");
            return;
        }

        if (File.Exists(args[1]))
        {
            Console.WriteLine("Output file already exists, not cloned");
            return;
        }

        try
        {
            
            FileStream input = File.OpenRead(args[0]);
            FileStream output = File.Create(args[1]);

            long blocks = input.Length / 1024;
            if (input.Length % 1024 != 0)
                blocks++;
            int blockSize = 1024;
            byte[] data = new byte[blockSize];

            for (long i = 0; i < blocks; i++)
            {
                int bytes = input.Read(data, 0, blockSize);
                output.Write(data, 0, bytes);
            }

            input.Close();
            output.Close();
            Console.WriteLine("File cloned succesfully");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
