//Pablo José Ferrándiz Navarro

using System;
using System.IO;

class AnchoYAltoBMPFileStream
{
    static void Main()
    {
        Console.Write("File name: ");
        string name = Console.ReadLine();
        
        if (!File.Exists(name))
        {
            Console.WriteLine("File not found");
        }
        else
        {
            try
            {
                FileStream file = File.OpenRead(name);
                int size = 54;
                byte[] header = new byte[size];
                int amountRead = file.Read(header, 0, size);
                file.Close();
                if (amountRead < size)
                {
                    Console.WriteLine("Header incomplete"); return;
                }
                
                byte header1 = header[0];
                byte header2 = header[1];
                
                if ((header1 == 'B') && (header2 == 'M'))
                {
                    Console.WriteLine("It seems to be a valid BMP");
                    int width = header[18] + 256 * header[19] +
                        256 * 256 * header[20] + 256 * 256 * 256 * header[21];
                    
                    int height = header[22] + 256 * header[23] +
                        256 * 256 * header[24] + 256 * 256 * 256 * header[25];
                    
                    Console.WriteLine("Width: " + width);
                    Console.WriteLine("Height: " + height);
                }
                else
                {
                    Console.WriteLine("It is not a BMP");
                }
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
