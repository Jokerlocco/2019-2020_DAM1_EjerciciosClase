using System;
using System.Collections;

class StackForeach
{
    static void Main()
    {
        Stack myStack = new Stack();
        string data;
        do
        {
            Console.Write("Enter a number: ");
            data = Console.ReadLine();
            if(data != "")
            {
                myStack.Push(Convert.ToInt32(data));
            }
        } while (data != "");

        foreach(int i in myStack)
        {
            Console.WriteLine("{0}", i);
        }
        Console.WriteLine( myStack.Pop() );
    }
}
