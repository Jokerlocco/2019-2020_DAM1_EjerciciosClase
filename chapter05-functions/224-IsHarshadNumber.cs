using System;

class HarshadNumber
{
    static bool IsHarshadNumber(int num)
    {
        string digits = num.ToString();
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += Convert.ToInt32(
                digits.Substring(i,1));
        } 
        return num % sum == 0;
    }

    static void Main()
    {
        int num = 152;

        if (IsHarshadNumber(num))
        {
            Console.WriteLine("{0} is a Harshad number", num);
        }
        else
        {
            Console.WriteLine("{0} is not a Harshad number", num);
        }
    }
}
