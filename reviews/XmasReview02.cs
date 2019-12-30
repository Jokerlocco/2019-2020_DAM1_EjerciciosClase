//Pablo José Ferrándiz Navarro 

/* 

Xmas Review 01

Create a program that asks the user how many numbers they are going to sum and 
then asks for those numbers and shows their sum. If they enter a negative 
amount of numbers (or zero), they will be asked again as many times as needed. 
Finally, all data will be displayed.

*/

using System;

class Xmas02
{
    static void Main()
    {
        int numbersToSum;
        do
        {
            Console.Write("How many numbers do you want to sum?: ");
            numbersToSum = Convert.ToInt32(Console.ReadLine());
            
            if (numbersToSum <= 0)
            {   Console.WriteLine("Wrong amount");
            }
        }
        while (numbersToSum <= 0);
            
        double[] numbers = new double[numbersToSum];
        double totalSum = 0;
        
        for (int i = 0; i < numbersToSum; i++)
        {
            Console.Write("Enter number " + (i+1) + ": ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
            totalSum += numbers[i];
        }
        Console.WriteLine("Sum: " + totalSum);
        Console.Write("Data: ");
        for (int i = 0; i < numbersToSum; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}
