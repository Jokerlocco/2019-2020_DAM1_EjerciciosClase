using System;

class ArrayReversedConst
{
    static void Main(string[] args)
    {
        const int SIZE = 5;
        int[] data = new int[SIZE];

        for (int number = 0; number < SIZE; number++)
        {
            Console.Write("Enter data {0} of {1}: ", 
                number + 1, SIZE);
            data[number] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = SIZE-1; i >= 0; i--)
        {
            Console.WriteLine(data[i]);
        }
    }
}
