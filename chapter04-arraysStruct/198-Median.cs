using System;

public class Median
{
    public static void Main()
    {
        // Ask for data
        Console.WriteLine("Type the quantity of numbers: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] data = new int[size];
        int sum=0;
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter data {0}: ", i + 1);
            data[i] = Convert.ToInt32(Console.ReadLine());
            sum +=data[i];
        }

        // Sorting: Bubble sort
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (data[i] > data[j])
                {
                    int aux = data[i];
                    data[i] = data[j];
                    data[j] = aux;
                }
            }
        }
        
        
        // Display results
        if(size % 2 !=0)
            Console.WriteLine("Median: {0}", data[size / 2]);
        else
        {
            int upperLimit = n/2;
            int lowerLimit = n/2 - 1;
            double averageOfCenterValues =
                ( data[lowerLimit] + data[upperLimit] ) / 2.0;
            Console.WriteLine("Median: {0},{1}", 
                averageOfCenterValues);
        }
                
        Console.WriteLine("Min: {0}", data[0]);
        Console.WriteLine("Max: {0}", data[size - 1]);
        Console.WriteLine("Average: {0}",sum/size);

    }
}
