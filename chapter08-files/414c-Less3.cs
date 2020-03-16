//Jose Valera 1ºDAM

using System;
using System.IO;
class TextViewer //Ej03CuarentenicaRicaRica
{
    static void Main()
    {
        Console.Write("Path: ");
        string path = Console.ReadLine();

        ConsoleKeyInfo key;
        bool exit = false;

        if (!File.Exists(path))
            Console.WriteLine("File not exist");

        else
        {
            string[] contenido = File.ReadAllLines(path);
            int begin = 0;
            int end;

            if (contenido.Length < 22) end = contenido.Length - 1;

            else end = 21;

            for (int i = begin; i <= end; i++)
                Console.WriteLine(contenido[i]);

            do
            {
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true);
                    Console.Clear();

                    if ((key.Key == ConsoleKey.DownArrow ||
                        key.Key == ConsoleKey.S) && 
                        end < contenido.Length - 1)
                    {
                        begin++;
                        end++;
                    }

                    else if ((key.Key == ConsoleKey.UpArrow ||
                        key.Key == ConsoleKey.W) && 
                        begin > 0)
                    {
                        begin--;
                        end--;
                    }

                    else if (key.Key == ConsoleKey.Escape ||
                            key.Key == ConsoleKey.Q)
                        exit = true;

                    for (int i = begin; i <= end; i++)
                        Console.WriteLine(contenido[i]);
                }
            }
            while (!exit);
        }
    }
}
