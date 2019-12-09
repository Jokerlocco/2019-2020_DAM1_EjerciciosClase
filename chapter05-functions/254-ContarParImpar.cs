//Daniel García 

using System;

class FuncionContarParImpar 
{
    static void ContarImparPar( int numero, out int impares, out int pares )
    {
        pares = 0;
        impares = 0;

        string num = Convert.ToString( numero );
        
        foreach ( char n in num )
        {
            if ( Convert.ToInt32(n - '0') % 2 == 0 )
                pares++;
            else
                impares++;
        }
    }

    
    static void Main()
    {
        int pares, impares;

        Console.Write("Introduce un número: ");
        int numero = Convert.ToInt32( Console.ReadLine() );

        ContarImparPar( numero, out impares, out pares );

        Console.WriteLine("Impares: " + impares);
        Console.WriteLine("Pares: " + pares);
    }
}
