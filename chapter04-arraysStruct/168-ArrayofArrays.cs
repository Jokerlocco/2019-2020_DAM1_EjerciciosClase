using System;

class ArrayOfArrays
{
    static void Main()
    {
        int ROWS = 2;
        double[][] data = new double[ROWS][];

        // Get data

        for (int row = 0; row < data.Length; row++)
        {
            Console.WriteLine("Size of row {0}? ", row+1);
            int columns = Convert.ToInt32(Console.ReadLine());
            data[row] = new double[columns];
            for (int column = 0; column < columns; column++)
            {
                Console.Write("Enter data for pos {0},{1}: ",
                    row + 1, column + 1);
                data[row][column] = Convert.ToDouble(Console.ReadLine());
            }
        }
        Console.WriteLine();

        // Average of each row

        for (int row = 0; row < data.Length; row++)
        {
            Console.Write("The average of row {0} is ", row + 1);
            double sum = 0;
            for (int column = 0; column < data[row].Length; column++)
            {
                sum += data[row][column];
            }
            Console.WriteLine(sum / data[row].Length);
        }


        // Glonal average

        double sumTotal = 0;
        int amount = 0;
        foreach (double[] row in data)
        {
            foreach (double d in row)
            {
                sumTotal += d;
                amount++;
            }
        }
        Console.WriteLine("Global average is " +
            sumTotal / amount);
    }
}
