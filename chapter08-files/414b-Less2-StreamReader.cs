//DAVID BERENGUER ANTON

using System;
using System.Collections.Generic;
using System.IO;

class LessSR
{
    static void Main()
    {
        StreamReader file;
        string name;
        int posIni = 0;
        int amountToDisplay = 22;
        int linesToDisplay = amountToDisplay;
        string line;
        List<string> data = new List<string>();
        ConsoleKeyInfo userkey;
        Console.WriteLine("enter the name of file");
        name = Console.ReadLine();
        if (!File.Exists(name))
        {
            Console.WriteLine("file not found");
        }
        else
        {
            try
            {
                file = File.OpenText(name);
                line = file.ReadLine();
                while (line != null)
                {
                    data.Add(line);
                    line = file.ReadLine();
                }
                file.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("path too long");
            }
            catch (IOException)
            {
                Console.WriteLine("I/O error");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }


            if (data.Count <= amountToDisplay)
            {
                amountToDisplay = data.Count;
            }
            bool exit = false;
            do
            {                
                for (int i = posIni; i < posIni+linesToDisplay; i++)
                {
                    Console.WriteLine(data[i]);
                }
                Console.WriteLine("push up or s to view before lines");
                Console.WriteLine("push down or d to view next lines");

                userkey = Console.ReadKey(true);
                switch (userkey.Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.S:
                        if (posIni > 0)
                        {
                            posIni --;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.D:
                        if (posIni < data.Count - amountToDisplay)
                        {
                            posIni ++;
                        }
                        break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.Q:
                        Console.WriteLine("bye");
                        exit = true;
                        break;
                }
                        
            }
            while (!exit);
        }
    }
}
