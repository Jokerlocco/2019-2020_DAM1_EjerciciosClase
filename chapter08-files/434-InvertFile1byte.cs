//Sergio Gumpert


using System;
using System.IO;

class Ejercicio
{
    static void Main()
    {
        string path;
       
            Console.WriteLine("¿path?");
            path = Console.ReadLine();
        try
        {

            FileStream inputFile = File.Open(path,FileMode.Open);
            FileStream outputFile = File.Create(path + ".inv");

            for (int i = 0; i < inputFile.Length; i++)
            {
                inputFile.Seek(inputFile.Length - 1 - i, SeekOrigin.Begin);
                outputFile.WriteByte((byte)inputFile.ReadByte());
            }
            inputFile.Close();
            outputFile.Close();

        }
        catch (PathTooLongException) { Console.WriteLine("Path too long"); }
        catch (IOException i) { Console.WriteLine(i.Message); }
        catch (Exception e) { Console.WriteLine(e.Message + "Error"); }
    }
}
