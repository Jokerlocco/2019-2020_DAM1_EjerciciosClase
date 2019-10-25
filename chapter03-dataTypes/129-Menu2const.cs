// Sergio Gumpert
//

using System;

class Menu
{
    static void Main()
    {
        const byte PLAY = 1;
        const byte LOAD = 2;
        const byte EXIT = 0;
        
        Console.WriteLine( PLAY +". Play");
        Console.WriteLine( LOAD +". Load");
        Console.WriteLine( EXIT +". Exit");

        byte opcion = Convert.ToByte(Console.ReadLine());

        switch (opcion)
        {
            case PLAY: Console.WriteLine("You choose Play."); break;
            case LOAD: Console.WriteLine("You choose Load."); break;
            case EXIT: Console.WriteLine("You choose Exit."); break;

            default: Console.WriteLine("Option not valid."); break;
            }
        }   
}
