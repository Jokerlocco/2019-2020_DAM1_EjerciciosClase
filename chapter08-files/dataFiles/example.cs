using System;

class SumTwoNumbers
{
    static void Main()
    {
        int a, b;
        int sum;
        
        Console.WriteLine("Enter a number:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number:");
        b = Convert.ToInt32(Console.ReadLine());
        
        sum = a + b;
        Console.Write("Their sum is:");
        Console.WriteLine(sum);
    }
}
