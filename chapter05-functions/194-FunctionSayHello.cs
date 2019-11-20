using System;

class FunctionSayHello
{
    static void SayHello(string name)
    {
        Console.WriteLine("Hi, " +name + "!!!");
    }
    
    static void Main()
    {
        Console.WriteLine("...");
        SayHello("Ruth");
        Console.WriteLine("---");
    }
}
