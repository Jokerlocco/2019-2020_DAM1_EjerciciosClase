//Pablo José Ferrándiz Navarro

using System;
using System.IO;

class Endianness
{
    static void Main()
    {
        try
        {
            BinaryWriter outputFile = new BinaryWriter(
                File.Open("endianess.bin", FileMode.Create));
            short s = 516;
            int i = 536870912;
            outputFile.Write(s);
            outputFile.Write(i);
            outputFile.Close();

            FileStream file = File.OpenRead("endianess.bin");
            short data1 = (short) (file.ReadByte() +
                256 * file.ReadByte());
            int data2 = file.ReadByte() +
                256 * file.ReadByte() +
                256 * 256 * file.ReadByte() +
                256 * 256 * 256 * file.ReadByte();
            file.Close();

            Console.WriteLine("Short: " + data1);
            Console.WriteLine("Int: " + data2);
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
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

