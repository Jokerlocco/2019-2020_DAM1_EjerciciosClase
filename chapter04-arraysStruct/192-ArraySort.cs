using System;

class SortArray
{
    static void Main()
    {
        int[] vector = { 6, 5, 2, 7, 1, 3, 8 };
        Array.Sort(vector);
        
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i] + " ");
        }
        Console.WriteLine();
    }
}
