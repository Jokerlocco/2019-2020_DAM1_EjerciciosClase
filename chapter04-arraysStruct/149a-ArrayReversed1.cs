using System;

class ArrayReversed
{
    static void Main(string[] args)
    {
        int[] data = new int[5];

        for (int number = 0; number < 5; number++)
        {
            Console.Write("Enter data {0} of 5: ", number + 1);
            data[number] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 4; i >= 0; i--)
        {
            Console.WriteLine(data[i]);
        }
    }
}
