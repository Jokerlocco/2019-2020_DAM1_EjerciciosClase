using System;

class SumDigitsOfAnInteger1
{
    static int SumDigits(int num)
    {
        int sum = 0;
        while(num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
    
    static void Main()
    {
        Console.WriteLine(SumDigits(123));
    }
}
