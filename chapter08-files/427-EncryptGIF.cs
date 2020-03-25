/*
Create a program to encrypt/decrypt a GIF image file, by changing 
the "GIF" mark in the first three bytes with "FIG" and vice versa.

You must dump its contents to a new file. The user must enter 
the names for both files.
*/

using System;
using System.IO;

public class EncryptGIF
{
    public static void Main(string[] args)
    {
        string inputName, outputName;
        
        if (args.Length != 2)
        {
            Console.Write("Input file name?");
            inputName = Console.ReadLine();
            Console.Write("Output file name?");
            outputName = Console.ReadLine();
        }
        else
        {
            inputName = args[0];
            outputName = args[1];
        }

        if (!File.Exists(inputName))
            Console.WriteLine("Input file not found");
        else
        {
            try 
            {
                FileStream file = File.OpenRead(inputName);
                int amountToRead = (int) file.Length;
                byte[] data = new byte[amountToRead];
                int result = file.Read(data, 0, amountToRead);
                file.Close();
                
                if (result < 2)
                {
                    Console.WriteLine("File is too short!");
                    return;
                }
                
                if (! (
                    (data[0] == 'G' && data[2] == 'F') ||
                    (data[0] == 'F' && data[2] == 'G') ))
                {
                    Console.WriteLine("Not a valid GIF!");
                    return;
                }
                
                byte aux = data[0];
                data[0] = data[2];
                data[2] = aux;

                FileStream output = File.OpenWrite(outputName);
                output.Write(data, 0, result);
                output.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
                return;
            }
            catch (IOException exp)
            {
                Console.WriteLine("Input/output error: "+ exp.Message);
                return;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Unexpected error: "+ exp.Message);
                return;
            }
        }
    }
}
