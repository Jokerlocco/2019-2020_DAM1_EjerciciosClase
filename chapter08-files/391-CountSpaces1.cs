// Count spaces (V1)
// Pablo Vigara Fernandez

using System;
using System.IO;

class CountSpaces1
{
    static void Main()
    {
        Console.Write("Enter file name: ");
        string path = Console.ReadLine();

        FileStream fich = File.OpenRead(path);
        
        int fichByte;
        int count = 0;

        do
        {
            fichByte = fich.ReadByte();

            if (fichByte != -1)
                if (fichByte == ' ')
                    count++;
        }
        while (fichByte != -1);
        Console.Write("Spaces: " + count);

        fich.Close();
    }
}
