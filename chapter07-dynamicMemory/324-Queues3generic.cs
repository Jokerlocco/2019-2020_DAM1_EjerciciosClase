// Queue + Generics

using System;
using System.Collections.Generic;

class Queues3
{
    static void Main()
    {
        Queue<int> myQueue = new Queue<int>();
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter data " + (i + 1) + ": ");
            int data = Convert.ToInt32(Console.ReadLine());

            myQueue.Enqueue(data);
        }

        int total = 0;
        while (myQueue.Count > 0)
        {
            int currentData = myQueue.Dequeue();
            Console.WriteLine(currentData);
            total += currentData;
        }
        Console.WriteLine("Total: " + total);
    }
}
