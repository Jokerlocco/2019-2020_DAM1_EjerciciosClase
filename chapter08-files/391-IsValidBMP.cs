//Pablo Conde

using System;
using System.IO;

class CheckBMP1
{
    static void Main()
    {
        FileStream myFile;
        string fileName;
        byte header1, header2;
        
        Console.Write("File name: ");
        fileName = Console.ReadLine();
        
        try
        {
            myFile = File.OpenRead(fileName);
            header1 = (byte) myFile.ReadByte();
            header2 = (byte) myFile.ReadByte();
            myFile.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine("Error" + e.Message);
            return;
        }
        
        if ((header1  == 'B') && ( header2  == 'M' ))
            Console.WriteLine("It is a BMP image");
        else
            Console.WriteLine("It is not a BMP image");
    }
}
