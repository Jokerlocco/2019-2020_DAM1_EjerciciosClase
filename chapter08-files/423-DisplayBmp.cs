//Kiko
using System;
using System.IO;

class DisplayBmpOnConsole
{
    static void Main()
    {
        Console.WriteLine("Type the path:");
        string path = Console.ReadLine();

        try
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Path does not exists.");
            }

            else
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                byte[] data = new byte[fs.Length];

                fs.Read(data, 0, (int)fs.Length-1);
                fs.Close();
                
                byte header1 = data[0];
                byte header2 = data[1];

                if (header1 == 'B' && header2 == 'M')
                {
                    byte width = data[18];
                    byte height = data[22];                    
                    int imgStart = data[10] + 256*data[11];
                 
                    byte[,] img = new byte[height,width];
                    
                    int i = 0;
                    for(int row = 0; row < height;row++)
                    {
                        for(int column = 0; column < width; column++)
                        {
                            byte pixel = data[imgStart + i];
                            img[height-row-1,column] = pixel;
                            i++;
                        }
                    }
                    
                    for(int row = 0; row < height;row++)
                    {
                        for(int column = 0; column < width; column++)
                        {
                            byte pixel =img[row,column];
                            if(pixel >127)
                            {
                               Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("#");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Not a BMP file");
                }
                
            }

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


