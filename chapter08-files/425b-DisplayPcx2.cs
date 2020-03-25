// Abraham García

using System;
using System.IO;

class PCX
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
            Console.WriteLine("You have to enter file name");
        else
        {
            string pcxFile = args[0];
            if (!File.Exists(pcxFile))
            {
                Console.WriteLine("File doesn't exist");
            }
            else
            {
                try
                {
                    BinaryReader pcxReader = new BinaryReader(
                        File.Open(pcxFile, FileMode.Open));

                    byte head = pcxReader.ReadByte();
                    if (head != 10)
                    {
                        Console.WriteLine("Not a PCX file...");
                        return;
                    }

                    pcxReader.ReadByte();
                    byte zip = pcxReader.ReadByte();
                    bool checkZip = false;
                    if (zip == 1) checkZip = true;
                    else if (zip == 0) checkZip = false;

                    byte bitPerPixel = pcxReader.ReadByte();
                    if (bitPerPixel != 8)
                    {
                        Console.WriteLine("Bit per pixels is not 8");
                        return;
                    }


                    pcxReader.BaseStream.Seek(4, SeekOrigin.Begin);
                    short xMin = pcxReader.ReadInt16();
                    short yMin = pcxReader.ReadInt16();
                    short xMax = pcxReader.ReadInt16();
                    short yMax = pcxReader.ReadInt16();
                    int width = xMax - xMin + 1;
                    int height = yMax - yMin + 1;

                    pcxReader.BaseStream.Seek(66, SeekOrigin.Begin);
                    byte checkWidth = pcxReader.ReadByte();
                    if (checkWidth != width)
                    {
                        Console.WriteLine("Width incorrect");
                        return;
                    }

                    string imageData = "";
                    pcxReader.BaseStream.Seek(128, SeekOrigin.Begin);
                    while (pcxReader.BaseStream.Position < 
                        pcxReader.BaseStream.Length -1)
                    {
                        byte data = pcxReader.ReadByte();
                        if (data < 192)
                            imageData += pixelToDraw(data);
                        else
                        {
                            byte repeats = (byte)(data - 192);
                            data = pcxReader.ReadByte();
                            string drawingLine = 
                                new string(pixelToDraw(data), repeats);
                            imageData += drawingLine;
                        }
                    }
                    pcxReader.Close();

                    Console.WriteLine("Bits per pixel: " + bitPerPixel);
                    Console.WriteLine("Width: " + width);
                    Console.WriteLine("Height: " + height);
                    Console.WriteLine("Bytes per Line: " + checkWidth);
                    Console.WriteLine("Zip: " + checkZip);

                    int actualPosition = 0;
                    for (int row = 0; row < height; row++)
                    {
                        for (int column = 0; column < width; column++)
                        {
                            Console.Write(imageData[actualPosition]);
                            actualPosition++;
                        }
                        Console.WriteLine();
                    }
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

    private static char pixelToDraw(byte data)
    {
        if (data > 200) return ' ';
        else if (data > 150) return '.';
        else if (data > 100) return '-';
        else if (data > 50) return '=';
        else return '#';
    }
}
