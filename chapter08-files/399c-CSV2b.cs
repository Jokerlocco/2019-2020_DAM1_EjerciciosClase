// Pablo Vigara Fernandez

using System;
using System.IO;

class Ejercicio
{
    static void Main()
    {
        Console.Write("Path: ");
        string path = Console.ReadLine();

        if (!File.Exists(path))
        {
            Console.WriteLine("Path or file not found. ");
            return;
        }

        try
        {
            StreamReader input = File.OpenText(path);
            StreamWriter output = File.CreateText("output.txt");
            string line;

            do
            {
                line = input.ReadLine();

                if (line != null)
                {
                    string[] parts = line.Split("\";");

                    for (int i = 0; i < parts.Length; i++)
                    {
                        if (i != parts.Length - 1)
                            output.WriteLine(parts[i].Substring(1));
                        else
                            output.WriteLine(parts[i]);
                    }
                    output.WriteLine();
                }
            }
            while (line != null);

            output.Close();
            input.Close();

            Console.WriteLine("output.txt created succesfully");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
