using System.Collections.Generic;
using System;

public class QueueReview
{
    public static void Main()
    {
        Queue<float> q = new Queue<float>();
        string option;
        do
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Show all");
            Console.WriteLine("3. Show head");
            Console.WriteLine("0. Quit");
            option = Console.ReadLine();
            
            switch(option)
            {
                case "1":
                    Console.Write("Enter data: ");
                    q.Enqueue( Convert.ToSingle( Console.ReadLine() ));
                    break;
                
                case "2":
                    Console.Write("Previous contents: ");
                    while (q.Count > 0)
                        Console.Write(q.Dequeue() + " ");
                    Console.WriteLine();
                    break;
                    
                case "3":
                    Console.WriteLine("Head: " + q.Peek() );
                    break;
            }
            
        }
        while (option != "0");
        Console.WriteLine("Data remaining: " + q.Count );
    }
    
}
