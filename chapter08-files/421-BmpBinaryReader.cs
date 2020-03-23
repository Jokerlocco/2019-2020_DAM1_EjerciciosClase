// Gonzalo Arques

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "welcome1.bmp";
        byte header1, header2;
        int width, height;

        if (!File.Exists(fileName))
        {
            Console.WriteLine("The file doesn't exist!");
        }
        else
        {
            try
            {
                BinaryReader file = new BinaryReader(
                    File.Open(fileName, FileMode.Open));
                header1 = file.ReadByte();
                header2 = file.ReadByte();
                file.BaseStream.Seek(18, SeekOrigin.Begin);
                width = file.ReadInt32();
                height = file.ReadInt32();
                file.Close();

                if (Convert.ToChar(header1) != 'B' || 
                    Convert.ToChar(header2) != 'M')
                {
                    Console.WriteLine("Not a BMP file.");
                }
                else
                {
                    Console.WriteLine("Width of the file: " + width);
                    Console.WriteLine("Height of the file: " + height);
                }
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException m)
            {
                Console.WriteLine("I/O Error: " + m.Message);
            }
            catch (Exception m)
            {
                Console.WriteLine("ERROR: " + m.Message);
            }
        }
    }
}
