// Displaying data in a queue (wrong version)

using System;
using System.Collections;

class Queues2a // Wrong version
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

        for (int i = 0; i < myQueue.Count; i++)  // !!!!
        {
            Console.WriteLine( myQueue.Dequeue() );
        }
    }
}
