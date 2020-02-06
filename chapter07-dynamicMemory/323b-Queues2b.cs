// Displaying data in a queue (for)

using System;
using System.Collections;

class Queues2b
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

        int max = myQueue.Count;
        for (int i = 0; i < max; i++)
        {
            Console.WriteLine( myQueue.Dequeue() );
        }
    }
}
