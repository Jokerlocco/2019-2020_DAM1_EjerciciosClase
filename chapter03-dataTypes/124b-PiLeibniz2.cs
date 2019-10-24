//DAVID BERENGUER ANTON
// triangulo 
using System;

class triangulo 
{
    static void Main()
    {
        double suma, res, num;
        int terminos;
        Console.WriteLine("numero de terminos");
        terminos = Convert.ToInt32(Console.ReadLine());

        num = 1;
        suma = 0;

        for(int i = 1; i <= terminos; i++)
        {
            if(i % 2 == 0)
            {
                suma = suma - (1 / num);
            }
            else
            {
                suma = suma + (1 / num);
            }
            num += 2;
        }
        res = suma * 4;
        Console.WriteLine("la aproximacion de PI es " + res);

    }
}
