//Pablo Conde

using System;
using System.IO;

class CopyFileSmallBlocks
{
    static void Main()
    {
        Console.Write("Name of the file to copy: ");
        string nameA = Console.ReadLine();
        
        if(!File.Exists(nameA))
            Console.WriteLine("File does not exist");
        
        else
        {
            Console.Write("Name of the new file: ");
            string nameB = Console.ReadLine();
            
            if(File.Exists(nameB))
                Console.WriteLine("This file already exists");
            
            else
            {
                try
                {
                    FileStream input = File.OpenRead(nameA);
                    FileStream output = File.Create(nameB);
                    
                    int size = (int) input.Length;
                    byte[] data = new byte[size]; 
                    int blockToCopy = 1024;
                    
                    int iterations = size / blockToCopy;
                    int lastCopy = size % blockToCopy;
                    
                    for (int i = 0; i < iterations; i++)
                    {
                        input.Read(data, 0, blockToCopy);
                        output.Write(data, 0, blockToCopy);
                    }
                 
                    input.Read(data, 0, lastCopy);
                    output.Write(data, 0, lastCopy);

                    input.Close();
                    output.Close();
                    
                    Console.WriteLine();
                    Console.WriteLine(nameB + " has been created");
                }
                catch(PathTooLongException)
                {
                    Console.WriteLine("Path too long");
                }
                catch(IOException)
                {
                     Console.WriteLine("I/O error");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}
