using System;
class funcionFibonacciIter
{
    
    static int Fibonacci (int num)
    {
        if (num == 0)
            return 0;
        else if (num == 1)
            return 1;
        else 
        {
            int ultimo = 1;
            int penultimo = 0;
            
            int suma = 1;
            for (int i = 2; i <= num; i++)
            {
                suma = ultimo + penultimo;
                penultimo = ultimo;
                ultimo = suma;
            }
            return suma;
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
