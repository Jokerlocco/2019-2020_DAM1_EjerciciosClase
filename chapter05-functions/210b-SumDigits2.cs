using System;

class SumDigitsOfAnInteger2
{
    static int SumDigits(int num)
    {
        string digits = num.ToString();
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += Convert.ToInt32(
                digits.Substring(i,1));
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine(SumDigits(123));
    }
}
