using System;

class SumaArgs
{
    static int Main (string[] args)
    {
        long numero, suma = 0;
        
        if (args.Length == 0)
        {
            Console.WriteLine("Debe indicar los numeros a sumar");
            return 1;
        }
        
        try
        {
            for (int i = 0; i < args.Length; i ++)
            {
                numero = Convert.ToInt64(args[i]);
                
                if (numero > 0)
                    suma += numero;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Sólo se pueden sumar números");
            return 2;
        }

        Console.WriteLine("Suma: " + suma);
        return 0;
    }
}
