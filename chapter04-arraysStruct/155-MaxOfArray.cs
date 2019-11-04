// Pablo Conde
// Array of 10 numbers + find the max

using System;

class ListaDeNumeros
{
    static void Main()
    {
        const int SIZE = 5;
        long[] data = new long [SIZE];
        long max;
        
        for (int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter number: ");
            data[i] = Convert.ToInt64(Console.ReadLine()); 
        }
     
        max = data[0];
        for (int j = 0; j < SIZE; j++)
        {
            if (data[j] > max)
                max = data[j];
        }
        Console.WriteLine("Max is: " + max);
    }
}
