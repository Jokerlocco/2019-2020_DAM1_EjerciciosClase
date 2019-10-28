// DAVID BERENGUER ANTON
// Hex Table
using System;

class HexTable
{
    static void Main()
    {
        int num = 0;
        for (int i = 0; i < 256; i+=16)
        {
            Console.Write(i + ": ");
            for (int j = 0; j < 16; j++)
            {
                if(num < 16)
                {
                    Console.Write("0");
                }
                Console.Write(Convert.ToString(num, 16) + " ");
                num++;
            }
            Console.WriteLine();
        }
    }
}
