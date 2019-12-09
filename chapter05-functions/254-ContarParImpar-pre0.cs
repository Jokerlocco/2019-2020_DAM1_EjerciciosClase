//Avelino Martinez Rodiguez
using System;

class FuncionContarParImpar
{
    static void ContarImparPar(int Numero,out int impares,out int pares)
    {
        impares = 0;
        pares = 0;
        for (int i = 0; i < Convert.ToString(Numero).Length; i++)
        {
            
            if (Convert.ToInt32(Convert.ToString(Numero)[i]) % 2 != 0)
            {
                impares++;
            }
            else
                pares++;
        }
    }

    static void Main()
    {
        int impares,pares;
        ContarImparPar(37372,out impares,out pares);
        Console.WriteLine("Impares "+impares+" Pares "+pares);
    }
}
