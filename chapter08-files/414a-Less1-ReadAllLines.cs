//Kiko

using System;
using System.IO;

class Less
{
    static void Main()
    {
        Console.Write("Enter the file name: ");
        string path = Console.ReadLine();

        if (File.Exists(path))
        {
            string[] texto = File.ReadAllLines(path);
            bool salir = false;
            bool actualizar = true;
            int firstLine = 0;
            int lastLine = 22;

            do
            {
                ConsoleKeyInfo key;

                if (texto.Length > 22)
                {

                    if (actualizar)
                    {
                        Console.Clear();

                        for (int j = firstLine; j < lastLine; j++)
                        {
                            Console.WriteLine(texto[j]);
                        }

                        actualizar = false;
                    }

                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey(true);

                        if (key.Key == ConsoleKey.DownArrow ||
                            key.Key == ConsoleKey.S)
                        {
                            if (lastLine + 1 <= texto.Length)
                            {
                                firstLine += 1;
                                lastLine += 1;
                            }

                            else
                            {
                                lastLine = texto.Length;
                            }
                        }

                        if (key.Key == ConsoleKey.UpArrow ||
                           key.Key == ConsoleKey.W)
                        {
                            if (firstLine - 1 > 0)
                            {
                                firstLine -= 1;
                                lastLine -= 1;
                            }

                            else
                                firstLine = 0;
                        }

                        if (key.Key == ConsoleKey.Escape ||
                          key.Key == ConsoleKey.Q)
                        {
                            salir = true;
                        }

                        actualizar = true;
                    }
                }

                else
                {
                    for (int j = firstLine; j < texto.Length; j++)
                    {
                        Console.WriteLine(texto[j]);
                    }
                }

            }
            while (!salir);

        }
    }
}
