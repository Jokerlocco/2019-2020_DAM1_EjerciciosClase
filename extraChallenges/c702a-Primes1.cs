//Avelino Martinez Rodriguez

using System;

class ListaDePrimos
{
    static void Main()
    {
        Console.Write("Introduzca un numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i < numero; i++)
        {
            bool esPrimo = true;
            for (int j = 2; j < i-1; j++)
                if (i % j == 0)
                    esPrimo = false;
            if (esPrimo)
                Console.Write(i + " ");
        }
    }
}
