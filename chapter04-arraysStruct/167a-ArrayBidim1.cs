//Pablo Conde
//Array bidimesional

using System;


class ArrayBi
{
    static void Main()
    {
        int ROWS = 2, COLUMNS = 3;
        double[,] data = new double[ROWS, COLUMNS];

        // Get data

        for (int row = 0; row < ROWS; row++)
        {
            for (int column = 0; column < COLUMNS; column++)
            {
                Console.Write("Enter data for pos {0},{1}: ",
                    row+1, column+1);
                data[row,column] = Convert.ToDouble(Console.ReadLine());
            }

        }
        Console.WriteLine();
        
        // Average
        
        double sumTotal = 0;
        for (int row = 0; row < ROWS; row++)
        {
            Console.Write("The average of row {0} is ", row+1);
            double sum = 0;
            for (int column = 0; column < COLUMNS; column++)
            {
                sum += data[row,column];
                sumTotal += data[row,column];
            }
            Console.WriteLine( sum / COLUMNS );

        }
        Console.WriteLine("Global average is " +
            sumTotal / (ROWS*COLUMNS) );
        
        
        // Global average, alternate way
        
        sumTotal = 0;
        foreach(double d in data)
        {
            sumTotal += d;
        }
        Console.WriteLine("Global average (2) is " +
            sumTotal / (ROWS*COLUMNS) );
    }
}
