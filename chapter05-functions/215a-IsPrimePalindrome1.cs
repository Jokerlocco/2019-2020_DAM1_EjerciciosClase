// Function IsPrime
// First approach, slow, timed
// Time taken on i7 7700 HQ:
// 10.000 to 30.000: 26 found, 3.763 s
// 100.000 to 400.000: 0 found, 10 min 40.306 s

using System;

class PrimePalindrome1
{
    static bool IsPrimePalindrome(long number)
    {
        if (IsPrime(number) && IsPalindrome(number.ToString()))
          return true;
        else
          return false;
    }
    
    static bool IsPrime(long number)
    {
        int dividers = 0;
        for (int i = 1; i <= number; i++)
        {
            if(number % i == 0)
                dividers++;
        }
        return dividers == 2;
    }

    static bool IsPalindrome(string s)
    {
        string reversed = "";
        for(int i = s.Length-1; i >= 0; i--)
        {
            reversed += s[i];
        }
        if (s == reversed)
            return true;
        else
            return false;
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
