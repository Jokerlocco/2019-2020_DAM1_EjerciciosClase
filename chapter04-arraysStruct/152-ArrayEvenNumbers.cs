//ArrayImpares
//By Renato Bueno

using System;

class ArrayEvenNumbers
{
    static void Main()
    {
        const int MAX = 10;
        short [] data = new short[MAX];

        Console.WriteLine("Entering data...");
        for(int i = 0; i < MAX; i++)
        {
            Console.Write("Enter the number " + (i + 1) + ": ");
            data[i] = Convert.ToInt16(Console.ReadLine());
        }

        Console.WriteLine("Data in the odd positions...");
        for (int i = 0; i < MAX; i++)
        {
            if (i % 2 == 0)
                Console.Write("Pos " + (i+1) +": " + data[i]);
            Console.WriteLine();
        }
        
        Console.WriteLine("Even data...");  
        bool found = false;      
        for(int i = 0; i < MAX; i++)
        {
            if(data[i] % 2 == 0)
            {
                found = true;
                Console.WriteLine(data[i]);
            }
        }
        if (!found)
            Console.WriteLine("There's no even numbers");
    }
}
