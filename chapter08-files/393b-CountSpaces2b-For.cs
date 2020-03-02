// Count spaces (V2)
// Pablo José Ferrándiz Navarro

using System;
using System.IO;

class CountSpaces2a
{
    static void Main()
    {
        Console.Write("File name: ");
        string name = Console.ReadLine();
        try
        {
            FileStream file = new FileStream(name, FileMode.Open);            
            long count = 0;
            long size = file.Length;
            for(long i = 0; i < size; i++)
            {
                int data = (byte)file.ReadByte();
                if(data == ' ')
                    count++;
            }
            file.Close();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
            return;
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
            return;
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e);
            return;
        }
    }
}
