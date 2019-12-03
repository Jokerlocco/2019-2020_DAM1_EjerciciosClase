//Sergio Gumpert

using System;

class Ejercicio
{
    static int AmountOfDigits(uint number)
    {
        int digits = 1;
        while (number >= 10)
        {
            number = number / 10;
            digits++;
        }
        return digits;
    }

    static int AmountOfDigitsR(uint number)
    {
        if (number < 10)
            return 1;
        else
            return 1 + AmountOfDigitsR(number / 10);
    }

    static void Main(string[] args)
    {
        Console.Write(AmountOfDigits(987));
        if (AmountOfDigitsR(1005) != 4) Console.Write("Falla!");
    }
}
