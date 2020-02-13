using System;
using System.Collections;

class EnumeratorForStack
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

        IEnumerator myEnumerator = myStack.GetEnumerator();
        while(myEnumerator.MoveNext())
        {
            Console.WriteLine("{0}", myEnumerator.Current);
        }
        Console.WriteLine( myStack.Pop() );
    }
}
