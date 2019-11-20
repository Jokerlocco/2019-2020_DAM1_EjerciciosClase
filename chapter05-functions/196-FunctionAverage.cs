// Pablo Vigara Fernández
// Function Average (of 3 real numbers)

using System;

class FunctionAverage
{
    static double Average(double num1, 
        double num2, double num3)
    {
        return (num1 + num2 + num3) / 3;
    }

    static void Main()
    {
        Console.Write("Num 1: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Num 2: ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Num 3: ");
        double n3 = Convert.ToDouble(Console.ReadLine());
        
        double result = Average(n1, n2, n3);
        
        Console.WriteLine("Result: {0}", result);
    }
}
