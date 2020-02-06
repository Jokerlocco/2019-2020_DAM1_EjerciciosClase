// Displaying data in a queue (while)

using System;
using System.Collections;

class Queues2c
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

        while (myQueue.Count > 0)
        {
            Console.WriteLine( myQueue.Dequeue() );
        }
    }
}
