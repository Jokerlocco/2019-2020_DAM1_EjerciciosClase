//Pablo Miguel Climent Gonzálvez

using System;

class FuncionRombo 
{
    static void DibujarRombo(int anchura,char c)
    {
        int nEspacios = (anchura+1)/2-1;
        int nCaracter = 1;
        int nFilas = anchura;

        if (anchura%2==0)
        {
            nEspacios = anchura/2-1;
            nCaracter = 2;
            nFilas = anchura -1;
        }

        for (int fila=1 ; fila<=nFilas; fila++)
        {
            for (int espacios=1 ; espacios<=nEspacios ; espacios++)
                Console.Write(" ");

            for (int caracteres=1 ; caracteres<=nCaracter ; caracteres++)
                Console.Write(c);

            Console.WriteLine();

            if (fila < (nFilas+1)/2)
            {
                nEspacios--;
                nCaracter+=2;
            }
            else
            {
                nEspacios++;
                nCaracter-=2;
            }
        }
    }
    
    static void Main()
    {
        DibujarRombo(7, '*');
        DibujarRombo(8, 'x');
    }
}
