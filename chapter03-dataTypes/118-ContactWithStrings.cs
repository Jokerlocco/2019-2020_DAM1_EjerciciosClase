// Daniel García
// Name (contact with strings)

using System;

class EnterYourname
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        if ( name == "Daniel" )
            Console.Write("Hi, " + name);
        else
            Console.Write("I don't know who are you, " + name);
    }
}
