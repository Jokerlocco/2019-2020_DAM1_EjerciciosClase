//Abraham García

using System;
using System.IO;

class GifCryptInAOneSingleFile
{
    static void Main()
    {
        Console.Write("GIF file: ");
        string gifFile = Console.ReadLine();

        if (!File.Exists(gifFile))
        {
            Console.WriteLine("File doesn't exist");
        }
        else
        {
            try
            {
                FileStream inputOutput = File.Open(gifFile, FileMode.Open,
                    FileAccess.ReadWrite);

                int size = (int)inputOutput.Length;
                byte[] data = new byte[size];
                inputOutput.Read(data, 0, size);

                if (!(
                    (data[0] == 'G' && data[2] == 'F') ||
                    (data[0] == 'F' && data[2] == 'G')))
                {
                    Console.WriteLine("Not a valid GIF!");
                    return;
                }

                byte aux = data[0];
                data[0] = data[2];
                data[2] = aux;

                inputOutput.Seek(0, SeekOrigin.Begin);
                inputOutput.Write(data, 0, size);
                inputOutput.Close();

                if (data[0] == 'G')
                    Console.WriteLine(gifFile + " Decrypted!");
                else
                    Console.WriteLine(gifFile + " Encrypted!");

            }
            catch (PathTooLongException)
            {
                Console.WriteLine("ERROR: Path too long");
            }
            catch (IOException)
            {
                Console.WriteLine("ERROR: IO Exception");
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e);
            }
        }
    }
}

