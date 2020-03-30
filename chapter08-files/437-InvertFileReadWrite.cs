// Pablo Vigara Fernandez

using System;
using System.IO;

class InvertFileStream
{
    static void Main()
    {
        Console.Write("File to invert: ");
        string path = Console.ReadLine();

        if (!File.Exists(path))
        {
            Console.WriteLine("File not found");
            return;
        }

        try
        {
            FileStream input = File.Open(
                path, FileMode.Open, FileAccess.ReadWrite);
            int length = (int)(input.Length);
            byte[] allBytes = new byte[length];

            input.Read(allBytes, 0, length);
            Array.Reverse(allBytes);
            
            input.Seek(0, SeekOrigin.Begin);
            input.Write(allBytes);
            
            Console.WriteLine("File inverted");
            input.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Error: Path too long");
        }
        catch (IOException)
        {
            Console.WriteLine("I/O Error");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}