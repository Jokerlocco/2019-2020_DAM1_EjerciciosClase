// Sergio Gumpert
//

using System;

class Menu01
{
    static void Main()
    {
        Console.WriteLine("1. Play");
        Console.WriteLine("2. Load");
        Console.WriteLine("0. Exit");

        byte option = Convert.ToByte(Console.ReadLine());

        switch (option)
        {
            case 1: Console.WriteLine("You chose Play."); break;
            case 2: Console.WriteLine("You chose Load."); break;
            case 0: Console.WriteLine("You chose Exit."); break;

            default: Console.WriteLine("Option not valid."); break;
        }
    }   
}
