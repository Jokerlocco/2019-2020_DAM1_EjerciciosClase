//Pablo Conde, edited by Nacho

/*

An emirp (prime spelled backwards) is a prime number that results in a 
different prime when its decimal digits are reversed.

The sequence of emirps begins 13, 17, 31, 37, 71, 73, 79, 97, 107, 113, 149, 
157, 167, 179, 199, 311, 337, 347, 359,... 

What is the sum of all emirps up to X?

Sample input
100
200
5000
65000
123456
654321
7654321
123456789

Sample output
418
1489
278175
19183366
148135601
1317845448
177587459444
???

*/

using System;

class EmirpNumbers
{
    static void Main()
    {
        string data = Console.ReadLine();
        while (data != null && data != "")
        {
            long max = Convert.ToInt64(data);
            SumEmirps(max);
            data = Console.ReadLine();
        }
    }

    static void SumEmirps(long upToX)
    {
        long sum = 0;

        while (upToX > 11)
        {
            if (IsPrime(upToX) && IsEmirp(upToX))
            {
                sum += upToX;
            }
            upToX--;
        }

        Console.WriteLine(sum);
    }

    static bool IsPrime(long number)
    {
        long dividers = 0;
        double root = Math.Sqrt(number) + 1;

        for (long i = 1; i < root; i++)
        {
            if (number % i == 0)
                dividers++;
        }
        return dividers < 2;
    }

    static bool IsEmirp(long number)
    {

        string numberString = number.ToString();
        string reverseNumberString = "";

        for (int i = numberString.Length - 1; i >= 0; i--)
        {
            reverseNumberString += numberString[i];
        }
        long reverseNumber = Convert.ToInt64(reverseNumberString);

        if (number != reverseNumber)
        {
            return IsPrime(reverseNumber);
        }
        else
            return false;

    }
}
