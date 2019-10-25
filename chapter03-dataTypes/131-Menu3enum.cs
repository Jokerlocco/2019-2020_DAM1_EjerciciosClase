// Sergio Gumpert
//

using System;

class Menu
{
    enum options { EXIT,PLAY,LOAD};
    static void Main()
    {
        Console.WriteLine((int)options.PLAY+". Play");
        Console.WriteLine((int)options.LOAD+". Load");
        Console.WriteLine((int)options.EXIT+". Exit");

        byte opcion = Convert.ToByte(Console.ReadLine());

        switch (opcion)
        {
            case (int)options.PLAY:
                Console.WriteLine("You choose Play."); break;
            case (int)options.LOAD:
                Console.WriteLine("You choose Load."); break;
            case (int)options.EXIT:
                Console.WriteLine("You choose Exit."); break;

            default: Console.WriteLine("Option not valid."); break;
        }
    }   
}
