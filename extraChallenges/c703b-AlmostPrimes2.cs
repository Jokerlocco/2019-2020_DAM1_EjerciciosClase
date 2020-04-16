//Pablo Conde -16/04/2020

/*
A composite number is a positive integer that has at least one positive divisor other than one or the number itself. In other words, a composite number is any positive integer greater than one that is not a prime number.

For example, 14 = 2*7 and 18 = 2*3*3 are composite numbers.

We will say a number is "almost prime" if it has exactly two (not necessarily distinct) prime factors.

For example, the following numbers are almost prime: 6 = 2*3, 25 = 5*5. And the following numbers are not: 17 (prime), 81 = 3*3*3*3.

Please help us get an idea about how many almost prime numbers there are in certain integer intervals.

Input

The first line contains an integer T, the number of test cases. T lines follow, containing two integers each: A and B, separated by a space.

Output

For each test case, print the number of almost prime numbers P that verify A ≤ P ≤ B.

Constraints

1 ≤ T ≤ 100
1 ≤ A ≤ B ≤ 10^8

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

Time taken on i7 7700:

30000 40000 : 1.27 seg
300000 400000 : 3 min 20 seg
2000000 5000000 : interrupted after several minutes
1 9999999 : not tested

*/

using System;

class casiPrimos
{
    static void Main()
    {
        
        int veces = Convert.ToInt32(Console.ReadLine());
        bool debugging = true;
        for (int i = 0; i < veces; i++)
        {
            DateTime start = DateTime.Now;
            string[] limites = Console.ReadLine().Split(' ');
            int min = Convert.ToInt32(limites[0]);
            int max = Convert.ToInt32(limites[1]);
            
            int contador = 0;
            
            for (int j = min; j <= max; j++)
            {
                if(EsCasiPrimo(j))
                 contador++;
            }
            Console.WriteLine(contador);
            if (debugging)
                Console.WriteLine(" Taken: " + (DateTime.Now-start));
        }
    }

    
    public static bool EsCasiPrimo(int numero)
    {
        for (int i = 2; i < numero; i++)
        {
            if(EsPrimo(i))
            {
                if(numero % i == 0)
                {
                    if(EsPrimo(numero / i))
                      return true;
                      
                    else
                      return false;
                }
            }
        }        
        return false;
    }
    
    
    public static bool EsPrimo(int num)
    {
        if (num == 2) return true;
        if (num % 2 == 0) return false;
      

        var limit = (int)Math.Floor(Math.Sqrt(num));

        for (int i = 3; i <= limit; i += 2)
            if (num % i == 0)
                return false;
        
        return true;
    }
}
