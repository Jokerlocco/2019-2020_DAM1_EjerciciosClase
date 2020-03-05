// Abraham

using System;
using System.IO;

class CheckBMP2
{
    static void Main()
    {
        FileStream myFile;
        string fileName;
        byte header1, header2, compression;

        Console.Write("File name: ");
        fileName = Console.ReadLine();

        try
        {
            myFile = File.OpenRead(fileName);
            header1 = (byte) myFile.ReadByte();
            header2 = (byte) myFile.ReadByte();
            
            Console.WriteLine("It is a BMP image");
            myFile.Seek(30, SeekOrigin.Begin);
            compression = (byte) myFile.ReadByte();
            
            myFile.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error" + e.Message);
            return;
        }

        if ((header1 == 'B') && (header2 == 'M'))
        {
            if (compression != 0)
                Console.WriteLine("Compressed BMP");
            else
                Console.WriteLine("Not compressed BMP");
        }
        else
            Console.WriteLine("It is not a BMP image");
    }
}
