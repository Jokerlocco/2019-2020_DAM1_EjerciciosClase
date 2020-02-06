// Contact with queues

using System;
using System.Collections;

class Queues1
{
    static void Main()
    {
        Queue myQueue = new Queue();
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter data "+(i+1)+ ": ");
            int data = Convert.ToInt32( Console.ReadLine() );

            myQueue.Enqueue(data);
        }

        int currentData;
        int total = 0;
        for (int i = 0; i < 5; i++)
        {
            currentData = (int) myQueue.Dequeue();
            Console.WriteLine(currentData);
            total += currentData;
        }
        Console.WriteLine("Total: "+total);
    }
}
