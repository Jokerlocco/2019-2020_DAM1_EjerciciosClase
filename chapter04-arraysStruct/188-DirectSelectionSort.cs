using System;

class DirectSelection
{
    static void Main()
    {
        int[] vector = { 6, 5, 2, 7, 1, 3, 8 };
        foreach (int n in vector)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
        
        
        int aux;
        for (int i = 0; i < vector.Length-1; i++)
        {
            int posMin = i;
            for (int j = i+1; j < vector.Length; j++)
            {
                if(vector[j] < vector[posMin])
                    posMin = j;
            }
            
            if (vector[i] != vector[posMin])
            {
                aux = vector[i];
                vector[i] = vector[posMin];
                vector[posMin] = aux;
            }
            
            Console.Write("Step " + (i+1) + ": ");
            foreach (int n in vector)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("Result :");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i] + " ");
        }
        Console.WriteLine();
    }
}
