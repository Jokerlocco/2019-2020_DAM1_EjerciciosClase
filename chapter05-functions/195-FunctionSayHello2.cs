using System;

class FunctionSayHello2
{
    static void SayHello(string name, int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine("Hi, " +name + "!!!");
        }
    }
    
    static void Main()
    {
        Console.WriteLine("...");
        SayHello("Saúl", 5);
        Console.WriteLine("---");
    }
}
