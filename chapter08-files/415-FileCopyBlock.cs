// Cristina Francés

using System;
using System.IO;

class FileCopyBlock
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.Write("Please specify two file names");
        }
        else
        {
            try
            {
                FileStream input = File.OpenRead(args[0]);
                byte[] data = new byte[input.Length];
                input.Read(data, 0, data.Length);
                input.Close();
                
                if (File.Exists(args[1]))
                    Console.WriteLine("Destination file already exists");
                else
                {
                    FileStream output = File.Create(args[1]);
                    output.Write(data, 0, data.Length);
                    output.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
