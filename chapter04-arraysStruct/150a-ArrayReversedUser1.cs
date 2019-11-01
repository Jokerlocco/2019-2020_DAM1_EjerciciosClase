//Ruth Martínez Iborra

using System;

class Numericos
{
    static void Main(string[] args)
    {
        int amount;

        Console.Write("How many data? ");
        amount = Convert.ToInt32(Console.ReadLine());

        int[] data = new int[amount];

        for (int number = 0; number < amount; number++)
        {
            Console.Write("Enter data {0}: ", number + 1);
            data[number] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = amount -1; i >= 0; i--)
        {
            Console.WriteLine(data[i]);
        }
    }
}
