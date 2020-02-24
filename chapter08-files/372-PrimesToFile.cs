// Joel Martinez

using System;
using System.IO;

class Prime
{
    static void Main()
    {
        using (StreamWriter prime = new StreamWriter("primes.txt"))
        {
            Console.Write("Enter the max number to check: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= num; i++)
            {
                int divider = 0;
                for (int e = 1; e <= i; e++)
                {
                    if (i % e == 0)
                    {
                        divider++;
                    }
                }

                if (divider == 2)
                {
                    prime.Write(i + " ");
                }
            }
        }
        Console.WriteLine("File created correctly");
    }
}
