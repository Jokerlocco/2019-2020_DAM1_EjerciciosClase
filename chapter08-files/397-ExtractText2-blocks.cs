//Abraham García

using System;
using System.IO;

public class BinaryToTextBlocks
{
    public static void Main()
    {
        Console.WriteLine("Enter file");
        string text = Console.ReadLine();

        if (!File.Exists(text))
            Console.WriteLine("File doesn't exist");
        else
        {
            FileStream file = File.OpenRead(text);
            int size = (int)file.Length;
            byte[] data = new byte[size];
            file.Read(data, 0, size);
            file.Close();
            
            StreamWriter textFile = new StreamWriter(text + ".txt");
            for (int i = 0; i < data.Length; i++)
            {
                byte d = data[i];
                if ((d >= 32 && d <= 126) ||
                        (d == 9 || d == 10 || d == 13))
                    textFile.Write(Convert.ToChar(d));
            }
            textFile.Close();
        }
    }
}
