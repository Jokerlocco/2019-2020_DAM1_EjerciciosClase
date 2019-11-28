// Function IsPrimePalindrome
// Fourth approach, Faster IsPalindrome, timed
// Time taken on i7 7700 HQ:
// 10.000 to 30.000: 26 found, 0.010 s
// 100.000 to 400.000: 0 found, 0.031 s
// 10.000.000 to 50.000.000: 0 found, 3.001 s
// 200.000.000 to 300.000.000: 0 found, 7.833 s
// 2 to 500.000.000: 3485 found, 37.419 s
// 1.000.000.000 to 2.000.000.000: 0 found, 1 min 17.345 s

using System;

class PrimePalindrome4
{
    static bool IsPrimePalindrome(long number)
    {
        if (IsPalindrome(number.ToString()) && IsPrime(number))
          return true;
        else
          return false;
    }
    
    static bool IsPrime(long number)
    {
        long limit = (int) Math.Sqrt(number);
        for (long i = 2; i <= limit; i++)
        {
            if(number % i == 0)
                return false;
        }
        return true;
    }

    static bool IsPalindrome(string text)
    {
        int left = 0, right = text.Length-1;
        bool isPalind = true;
        
        while (left <= right && isPalind)
        {
            if (text[left] != text[right])
                isPalind = false;
            left ++;
            right --;
        }
        return isPalind;
    }

    
    static void Main()
    {
        Console.Write("Enter the lower limit: ");
        long lower = Convert.ToInt64(Console.ReadLine());
        Console.Write("Enter the upper limit: ");
        long upper = Convert.ToInt64(Console.ReadLine());

        DateTime start = DateTime.Now;
        
        long amountFound = 0;
        for (long i = lower; i <= upper; i++)
            if (IsPrimePalindrome(i))
                amountFound++;
        
        DateTime end = DateTime.Now;
        Console.WriteLine("Time taken: "+ (end-start));
        Console.WriteLine("Found: "+ amountFound);
    }
}
