using System;

class MaxOf Array
{
    static int Max(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if(numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    static void Main()
    {
        int[] numbers = { 20, 30, -5, 2 };
        Console.WriteLine(Max(numbers));
    }
}
