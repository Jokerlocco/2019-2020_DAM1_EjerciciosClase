using System;

class DividirIterRecurs
{
    static int Dividir (int num1, int num2)
    {
        int resultado = 0;
        for (int i = num1; i >= num2; i -= num2)
            resultado ++;
        return resultado;
    }
    
    static int DividirR (int num1, int num2)
    {
        if (num1 < num2)
            return 0;
        else
            return 1 + DividirR (num1 - num2, num2);
    }
    
    static void Main ()
    {
        Console.WriteLine("21 / 3 = " + Dividir (21, 3));
        Console.WriteLine("20 / 3 = " + Dividir (20, 3));
        Console.WriteLine("22 / 3 = " + Dividir (20, 3));
        Console.WriteLine("0 / 3 = " + Dividir (0, 3));
        
        Console.WriteLine("R 21 / 3 = " + DividirR (21, 3));
        Console.WriteLine("R 20 / 3 = " + DividirR (20, 3));
        Console.WriteLine("R 22 / 3 = " + DividirR (20, 3));
        Console.WriteLine("R 0 / 3 = " + DividirR (0, 3));
    }
}
