//Abraham García - RecuadroRedondeado

using System;

class recuadrito
{
    static void MostrarRecuadroRedondeado(int anchura, int altura)
    {
        for (int i = 0; i < altura; i++)
        {
            for (int j = 0; j < anchura; j++)
            {
                if ((i == 0 && j == 0) || 
                    (i == altura-1 && j == anchura-1))
                    Console.Write("/");
                else if ((i == 0 && j == anchura-1) || 
                    (i == altura-1 && j == 0))
                    Console.Write("\\");
                else if ((i != 0 && i != altura-1)
                    && (j == 0 || j == anchura-1))
                    Console.Write("|");
                else if ((i == 0 || i == altura-1) &&
                    (j != 0 && j != anchura-1))
                    Console.Write("-");
                else
                    Console.Write(" ");
            }
            
        Console.WriteLine();
        }   
    }
    
    static void Main()
    {
        Console.Write("Anchura: ");
        int anchura = Convert.ToInt32(Console.ReadLine());
        Console.Write("Altura: ");
        int altura = Convert.ToInt32(Console.ReadLine());
        
        MostrarRecuadroRedondeado(anchura,altura);
    }
}
