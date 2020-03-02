//Pablo Conde

using System;
using System.IO;

class ExtractText1
{
    static void Main()
    {
        FileStream input;
        StreamWriter output;
        string name;
        byte data;

        Console.Write("File name: ");
        name = Console.ReadLine();
        
        try
        {
            input = File.OpenRead(name);
            output = File.CreateText(name + ".txt");

            for (long i = 0; i < input.Length; i++)
            {
                data = (byte) input.ReadByte();
                
                if((data >= 32 && data <= 126) || data == 9
                        || data == 10 || data == 13)
                    output.Write((char) data);
            }            
            output.Close();
            input.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
        }
        
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        
        catch (IOException)
        {
            Console.WriteLine("I/O error");
        }
        
        catch(Exception e)
        {
            Console.WriteLine("Error" + e.Message);
        }
    }
}
