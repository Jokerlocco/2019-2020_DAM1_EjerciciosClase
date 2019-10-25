using System;

class EnumsExample
{
    enum options { PLAY = 1, LOAD, EXIT = 10 };

    static void Main()
    {
        Console.WriteLine( options.PLAY );
        Console.WriteLine( (int) options.PLAY );

        Console.WriteLine( (int) options.EXIT );
        Console.WriteLine( (int) options.LOAD );
    }
}
