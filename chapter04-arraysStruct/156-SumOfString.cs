// Cristina Francés
// Sum of the numbers in a string such as "20 30 40"

using System;

class SumOfAString
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string with numbers and spaces: ");
        string answer = Console.ReadLine();
        
        string [] numbers = answer.Split();
        int sum = 0;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += Convert.ToInt32(numbers[i]);
        }
        
        Console.WriteLine(sum);
    }
}
