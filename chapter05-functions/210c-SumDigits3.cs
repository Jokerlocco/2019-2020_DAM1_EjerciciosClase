using System;

class SumDigitsOfAnInteger3
{
    static int SumDigits(int num)
    {
        string digits = num.ToString();
        int sum = 0;
        foreach (char c in digits)
        {
            sum += Convert.ToInt32(c - '0');
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine(SumDigits(123));
    }
}
