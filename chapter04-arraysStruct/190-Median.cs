using System;

public class Median
{
    public static void Main()
    {
        const int SIZE = 7;
        int[] data = new int[SIZE];

        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter data {0}: ", i+1);
            data[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < SIZE - 1; i++)
        {
            for(int j = i+1 ; j < SIZE; j++)
            {
                if(data[i] > data[j])
                {
                    int aux = data[i];
                    data[i] = data[j];
                    data[j] = aux;
                }
            }
        }
        
        Console.WriteLine("Median: {0}", data[ SIZE/2 ]);
        Console.WriteLine("Min: {0}", data[ 0 ]);
        Console.WriteLine("Max: {0}", data[ SIZE-1 ]);
    }
}
