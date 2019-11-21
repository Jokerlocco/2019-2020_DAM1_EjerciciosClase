using System;

public class ArrayMax
{
    public static int  MaxOfArray(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if( numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    
    public static void Main()
    {
        int[] data = { 10, 20, 5, 2 };
        Console.WriteLine(
            "The max of the array is " + 
            MaxOfArray(data));
    }
}
