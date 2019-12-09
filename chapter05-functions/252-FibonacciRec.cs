//Alberto Girón Serna

using System;
class FuncionFibonacci
{
    
    static int Fibonacci (int num)
    {
        if (num == 0)
        {
            return 0;
        }
        else if (num == 1)
        {
            return 1;
        }
        else 
        {
            return Fibonacci (num - 1) + Fibonacci (num - 2);
        }
    }
    
    static void Main ()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write(Fibonacci(i)+" ");
        }
        Console.WriteLine();
        
        Console.Write("Introduce un numero: ");
        Console.WriteLine(Fibonacci(Convert.ToInt32(Console.ReadLine())));
    }
}
