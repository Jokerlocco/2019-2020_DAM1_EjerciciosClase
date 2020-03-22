// Pablo Vigara Fernandez

using System;
using System.IO;

class VisorHexadecimal
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
            return;

        if (!File.Exists(args[0]))
            return;

        try
        {
            FileStream input = File.OpenRead(args[0]);
            int blockSize = 16;
            long blocks = input.Length / blockSize;
            if (input.Length % blockSize != 0)
                blocks++;

            byte[] data = new byte[blockSize];
            for (long i = 0; i < blocks; i++)
            {
                int bytes = input.Read(data, 0, blockSize);
                for (int j = 0; j < bytes; j++)
                {
                    string hexaData = Convert.ToString(data[j], 16);

                    if (hexaData.Length == 1)
                        hexaData = "0" + hexaData;

                    Console.Write(hexaData + " ");
                }
                if (bytes != blockSize)
                {
                    for (int j = bytes; j < blockSize; j++)
                    {
                        Console.Write("   ");
                    }
                }
                for (int j = 0; j < bytes; j++)
                {
                    if (Convert.ToInt32(Convert.ToChar(data[j])) < 32)
                        Console.Write(".");
                    else
                        Console.Write(Convert.ToChar(data[j]));
                }
                Console.WriteLine();
            }
            input.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        
    }
}
