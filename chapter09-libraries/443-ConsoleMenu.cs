// DAVID BERENGUER ANTON

using System;

class ConsoleMenu
{
    static void Main()
    {
        string[] options = { "Add", "Search", "Edit", "Quit" };
        int activeOption = 0;
        ConsoleKeyInfo key;

        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Cyan;
        do
        {
            Console.Clear();
            for (int i = 0; i < options.Length; i++)
            {
                Console.SetCursorPosition(10, 5 + i);
                if (activeOption == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-> " + options[i]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   " + options[i]);
                }
            }

            key = Console.ReadKey(true);
            if ((key.Key == ConsoleKey.DownArrow)
                    && (activeOption < options.Length-1))
                activeOption++;
            if ((key.Key == ConsoleKey.UpArrow)
                    && (activeOption > 0))
                activeOption--;
        }
        while (key.Key != ConsoleKey.Escape);
       Console.ResetColor();
    }
}
