//Kiko
using System;
using System.Collections.Generic;

class Prime
{
    static void Main()
    {
        Console.WriteLine("Type an integer number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        DateTime start = DateTime.Now;
        List<int> prime = new List<int>();
        prime.Add(2);
        bool stop = false;
        int j = 0;

        for (int i = 2; i <= num; i++)
        {
            stop = false;
            j = 0;
            while (j < prime.Count && !stop)
            {
                float result=  i / prime[j];

                if (result < prime[j])
                {
                    prime.Add(i);
                    Console.Write(i + " ");
                    stop = true;
                }
                
                else if(i % prime[j]== 0)
                {
                    stop = true;
                }
                j++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Total Time: "+(DateTime.Now-start));
   
    }
}

