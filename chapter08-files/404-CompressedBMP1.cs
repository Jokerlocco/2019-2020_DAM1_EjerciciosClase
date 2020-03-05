//En honor a pablo conde de su colega kiko.
using System;
using System.IO;

class CheckBMP1
{
    static void Main()
    {
        FileStream myFile;
        string fileName;
        byte header1, header2,comp;

        Console.Write("File name: ");
        fileName = Console.ReadLine();

        try
        {
            myFile = File.OpenRead(fileName);
            header1 = (byte)myFile.ReadByte();
            header2 = (byte)myFile.ReadByte();
            for(int i = 0; i < 27 ; i++)
            {
                myFile.ReadByte();
            }
            comp = (byte)myFile.ReadByte();
            myFile.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error" + e.Message);
            return;
        }

        if ((header1 == 'B') && (header2 == 'M'))
        {
            Console.WriteLine("It is a BMP image");
            if((comp == '0'))
            {
                Console.WriteLine("It's compressed");
            }
            else
                Console.WriteLine("It's not compressed");
        }
            
        else
            Console.WriteLine("It is not a BMP image");
    }
}
