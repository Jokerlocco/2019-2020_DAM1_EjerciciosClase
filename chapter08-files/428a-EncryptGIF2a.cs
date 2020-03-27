//Pablo Conde - 26/03/2020

using System;
using System.IO;

class ReadWrite
{
    static void Main()
    {
        Console.Write("File name: ");
        string name = Console.ReadLine();
        
        if(!File.Exists(name))
        {
            Console.WriteLine("File not found");
        }
        else
        {
            try
            {
               FileStream input = File.Open(name, 
                    FileMode.Open, FileAccess.ReadWrite);
                
                byte first = (byte) input.ReadByte();
                byte second = (byte) input.ReadByte();
                byte third = (byte) input.ReadByte();
                
                if(first == 'G' && second == 'I' && third == 'F')
                {
                    Console.WriteLine("This is a GIF file");
                    
                    input.Seek(0, SeekOrigin.Begin);
                    input.WriteByte(third);
                    input.Seek(2, SeekOrigin.Begin);
                    input.WriteByte(first);
                    
                    Console.WriteLine("The file has been encrypted");
                    
                }
                else if(first == 'F' && second == 'I' && third == 'G')
                {
                    Console.WriteLine("This is a GIF file (encrypted)");
                    input.Seek(0, SeekOrigin.Begin);
                    input.WriteByte(third);
                    input.Seek(2, SeekOrigin.Begin);
                    input.WriteByte(first);
                    
                    Console.WriteLine("The file has been decrypted");
                }
                else
                 Console.WriteLine("This is not a GIF file");   
            
          
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

