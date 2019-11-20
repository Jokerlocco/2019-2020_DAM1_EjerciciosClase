using System;

class Program
{
    static void Main()
    {
        int[] vector = { 6, 5, 2, 7, 1, 3, 8 };
        for (int i = 1; i < vector.Length; i++)
        {
            int j = i - 1;
            while(j>=0 && vector[j]>vector[j+1])
            {
                int aux = vector[j];
                vector[j] = vector[j+1];
                vector[j+1] = aux;
                
                j = j - 1;
            }
        }
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i] + " ");
        }
        Console.WriteLine();
    }
}
