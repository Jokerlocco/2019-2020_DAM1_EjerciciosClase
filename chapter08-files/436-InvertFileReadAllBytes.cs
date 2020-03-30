//Pablo Conde - 30-03-2020

using System;
using System.IO;


class InvertirReadAllBytes
{
    static void Main()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();


        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found");
        }
        else
        {
            try
            {
                byte[] data = File.ReadAllBytes(fileName);
                Array.Reverse(data);
                File.WriteAllBytes(fileName + "-inv", data);

                Console.WriteLine("New file created successfully");
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
}

