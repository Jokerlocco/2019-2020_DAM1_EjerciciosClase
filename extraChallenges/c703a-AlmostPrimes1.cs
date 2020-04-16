//Abraham García - Reto 7.03 - Casi Primos

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
*/

using System;

class CasiPrimos
{
    static void Main()
    {
        //Con números grandes tarda demasiado...

        int casos = Convert.ToInt32(Console.ReadLine());
        bool debugging = true;

        for (int i = 0; i < casos; i++)
        {
            DateTime start = DateTime.Now;
            string casiPrimos = Console.ReadLine();
            int casiPrimo1 = Convert.ToInt32(casiPrimos.Split()[0]);
            int casiPrimo2 = Convert.ToInt32(casiPrimos.Split()[1]);
            int resultado = 0;

            for (int j = casiPrimo1; j <= casiPrimo2; j++)
            {
                casiPrimo1 = j;
                int divisor = 2;
                int comprobarCasiPrimo = 0;

                while (comprobarCasiPrimo <= 2 && casiPrimo1 != 1)
                {
                    if (casiPrimo1 % divisor == 0)
                    {
                        casiPrimo1 /= divisor;
                        comprobarCasiPrimo++;
                    }
                    else
                        divisor++;
                }
                if (comprobarCasiPrimo == 2)
                    resultado++;
            }
            Console.WriteLine(resultado);
            if (debugging)
                Console.WriteLine(" Taken: " + (DateTime.Now-start));
        }
    }
}
