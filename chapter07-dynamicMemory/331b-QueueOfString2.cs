// Queue of string (v2, generic)

using System;
using System.Collections.Generic;

class Queue1a
{
    static void Main()
    {
        Queue<string> q = new Queue<string>();
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
            data = q.Dequeue();
            if (! data.ToUpper().StartsWith("Z"))
                Console.WriteLine(data);
        }
    }
}
