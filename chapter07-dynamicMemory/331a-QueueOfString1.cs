// Queue of string (v1)

using System;
using System.Collections;

class Queue1a
{
    static void Main()
    {
        Queue q = new Queue();
        string data;
        
        // Read data
        do
        {
            Console.Write("Enter some text: ");
            data = Console.ReadLine();
            if (data != "")
                q.Enqueue(data);
        }
        while(data != "");
        
        // Display data
        Console.WriteLine("Texts not starting with Z:");
        while(q.Count > 0)
        {
            data = (string) q.Dequeue();
            if (! data.ToUpper().StartsWith("Z"))
                Console.WriteLine(data);
        }
    }
}
