// Pablo Vigara Fernandez

using System;

class Reto
{
    static void Main()
    {
        Console.Write("Number (m): ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Prime numbers: ");
        for (int i = 2; i < m; i++)
            if (IsPrime(i))
                Console.Write(i + " ");
    }
    public static bool IsPrime(int number)
    {
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var limit = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= limit; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }
}
