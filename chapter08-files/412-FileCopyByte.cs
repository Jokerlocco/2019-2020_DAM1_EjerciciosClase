//DAVID BERENGUER ANTON

using System;
using System.IO;

class FileCopyByte
{
    static void Main()
    {
        FileStream input;
        FileStream output;
        string name1, name2;
        byte current;
        Console.WriteLine("Enter the name of source file");
        name1 = Console.ReadLine();
        if(!File.Exists(name1))
        {
            Console.WriteLine("File not found");
        }
        else
        {
            Console.WriteLine("enter the name of destination file");
            name2 = Console.ReadLine();
            if(File.Exists(name2))
            {
                Console.WriteLine("Thar file exists!");
            }
            else
            {
                try
                {
                    input = File.OpenRead(name1);
                    output = File.Create(name2);

                    for (int i = 0; i < input.Length; i++)
                    {
                        current =(byte) input.ReadByte();
                        output.WriteByte(current);
                    }
                    output.Close();
                    input.Close();

                }
                catch (PathTooLongException)
                {
                    Console.WriteLine("path too long");
                }
                catch (IOException)
                {
                    Console.WriteLine("I/O error");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}

