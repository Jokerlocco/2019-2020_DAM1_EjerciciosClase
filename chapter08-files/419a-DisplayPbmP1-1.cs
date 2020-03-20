//Jose Valera 1ºDAM

using System;
using System.Collections.Generic;
using System.IO;

class BlackAndWhiteImage //Ej08CuarentenicaRicaRica
{
    static void Main()
    {
        Console.Write("Path: ");
        string path = Console.ReadLine();
        string[] lines = new string[0];
        bool fileExists = true;
        try
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("The file not exist");
                fileExists = false;
            }
            else
            {
                lines = File.ReadAllLines(path);
            }
        }
        catch (PathTooLongException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }

        if (fileExists)
        {
            if (lines[0] != "P1")
                Console.WriteLine("The file is not a black and white image");
            else
            {
                int initPos, width, height;
                string pixels = "";

                if (lines[1].StartsWith("#"))
                {
                    initPos = 3;
                    width = Convert.ToInt32(lines[2].Split()[0]);
                    height = Convert.ToInt32(lines[2].Split()[1]);
                }

                else
                {
                    initPos = 2;
                    width = Convert.ToInt32(lines[1].Split()[0]);
                    height = Convert.ToInt32(lines[1].Split()[1]);
                }

                for (int i = initPos; i < lines.Length; i++)
                    pixels += lines[i].Trim();

                while (pixels.Contains(" "))
                    pixels = pixels.Replace(" ","");

                for (int i = 0; i < pixels.Length; i++)
                {
                    if (pixels[i] == '1')
                        Console.Write("#");
                    else
                        Console.Write("·");
                    
                    if (i % width == width - 1)
                        Console.WriteLine();
                }
            }
        }
    }
}
