// Francisco Jiménez

/*
Challenge 7.01 - Emirps (T)

An emirp (prime spelled backwards) is a prime number that results in a 
different prime when its decimal digits are reversed.

The sequence of emirps begins 13, 17, 31, 37, 71, 73, 79, 97, 107, 113, 149, 
157, 167, 179, 199, 311, 337, 347, 359,... 

What is the sum of all emirps up to X?

Sample input
100
200
5000
65000
123456
654321

Sample output
418
1489
278175
19183366
148135601
1317845448
*/

using System;
class Emirp2
{
    static bool Primo(int n)
    {
        int divisores = 0;
        int i = 1;
        while (i <= n && divisores <= 2)
        {
            if (n % i == 0)
            {
                divisores++;
            }

            i++;
        }
        if (divisores == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static bool Emirp(int n)
    {
        string numero = n.ToString();
        string numeroReverso = "";
        for (int i = numero.Length - 1; i >= 0; i--)
        {
            numeroReverso += numero[i];
        }

        if (numeroReverso == numero)
        {
            return false;
        }

        int numero2 = Convert.ToInt32(numeroReverso);
        if (Primo(n) && Primo(numero2))
            return true;
        else
            return false;
    }

    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int suma = 0;
        for (int i = 1; i <= n; i++)
        {
            if (Emirp(i))
            {
                suma += i;
            }
        }
        Console.WriteLine(suma);
    }

}
