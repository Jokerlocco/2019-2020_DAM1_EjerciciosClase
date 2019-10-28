// DAVID BERENGUER ANTON
// HexTable (v2)
using System;

class HexTable
{
    static void Main()
    {
        int num = 0;
        for (int i = 0; i < 256; i+=16)
        {
            Console.Write(i.ToString("000") + ": ");
            for (int j = 0; j < 16; j++)
            {
                Console.Write(num.ToString("X2") + " ");
                num++;
            }
            Console.WriteLine();
        }
    }
}
