// Nacho

// Almost prime = two (not necessarily distinct) prime factors.
// How many almost prime numbers there are in certain integer intervals?

// Time taken: 0:01.21 from 1 to 9.999.999 on Core i7 7700

/*
Sample input

6
1 10
10 20
30000 40000
300000 400000
2000000 5000000
1 9999999

Sample output

4
3
2329
20923
571990
1904324
*/

using System;
using System.IO;
using System.Collections.Generic;

public class AlmostPrime
{
    const long MAX = 100000000;
    static List<long> primes;
    static bool[] almostPrimes = new bool[MAX];
    
    static bool debugging = true;

    public static void GenerateListOfPrimes(long max)  // Sieve of Erasthotenes
    {
        primes = new List<long>();
        primes.Add(2);
        int maxSquareRoot = (int)(Math.Sqrt(max));
        bool[] discarded = new bool[(int)(max + 1)];

        for (int i = 3; i <= max; i += 2)
            if (!discarded[i])
            {
                primes.Add(i);
                if (i < maxSquareRoot)
                    for (int j = i * i; j <= max; j += 2 * i)
                        discarded[j] = true;
            }
        if (debugging) Console.WriteLine("Sieve finished");
    }


    public static void GenerateListOfAlmostPrimes(long max)
    {
        for (int i = 0; i < primes.Count; i ++)
            for (int j = 0; j <= i; j ++)
            {
                long n1 = primes[i];
                long n2 = primes[j];
                if (n1 * n2 > 100000000)
                    break;
                almostPrimes[n1*n2] = true;
            }
    }


    public static void ProcessAndDump(int min, int max)
    {        
        int count = 0;
        
        for (int i = min; i <= max; i++)
        {
            if (almostPrimes[i])
                count++;
        }
        Console.WriteLine( count );
    }


    public static void Main(string[] args)
    {
        DateTime start = DateTime.Now;
        if (debugging)
            Console.WriteLine("Generating primes...");
        GenerateListOfPrimes(MAX);
        if (debugging)
            Console.WriteLine("{0} primes found.", primes.Count);
            
        if (debugging)
            Console.WriteLine("Generating almost primes...");
        GenerateListOfAlmostPrimes(MAX);
        if (debugging)
            Console.WriteLine("Done");

        int cases = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < cases; i++)
        {
            string details = Console.ReadLine();
            string[] minMax = details.Split(' ');
            ProcessAndDump(
                Convert.ToInt32(minMax[0]), 
                Convert.ToInt32(minMax[1]));
        }
        if (debugging)
            Console.WriteLine(" Taken: " + (DateTime.Now-start));
    }
}
