// Pablo Miguel Climent Gonzálvez

/*
Ejemplo de entrada

5
5 + -13
10 / 2
7 * 3
3 / 0
5 - 13

Ejemplo de salida

-8
5
21
ERROR
-8
*/

using System;

class CalculatingMachine
{
    static void Main()
    {
        ushort n;
        string operacion;
        int a,b;
        char simbolo;

        n=Convert.ToUInt16(Console.ReadLine());

        for (ushort i=1 ; i<=n ; i++)
        {
            operacion=Console.ReadLine();

            string[] descomposicion = operacion.Split();
            a = Convert.ToInt32(descomposicion[0]);
            b = Convert.ToInt32(descomposicion[2]);
            simbolo = Convert.ToChar(descomposicion[1]);

            if (simbolo=='+')
            {
                Console.WriteLine(a+b);
            }
            else if (simbolo=='-')
            {
                Console.WriteLine(a-b);
            }
            else if (simbolo=='*')
            {
                Console.WriteLine(a*b);
            }
            else if (simbolo=='/')
            {
                if (b==0)
                    Console.WriteLine("ERROR");
                else
                    Console.WriteLine(a/b);
            }
        }
    }
}
