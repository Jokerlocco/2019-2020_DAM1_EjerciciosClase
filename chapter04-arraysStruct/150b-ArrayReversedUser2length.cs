//Ruth Martínez Iborra

using System;

class Numericos
{
    static void Main(string[] args)
    {
        int[] data;
        int amount;

        Console.Write("How many data? ");
        amount = Convert.ToInt32(Console.ReadLine());

        data = new int[amount];

        for (int number = 0; number < data.Length; number++)
        {
            Console.Write("Enter data {0}: ", number + 1);
            data[number] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = data.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(data[i]);
        }
    }
}
