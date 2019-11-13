// Francisco Jiménez velasco
// Repeated rows in an array?

using System;

class Array3x3
{
    static void Main()
    {
        const int ROWS = 3;
        const int COLUMNS = 3;

        long[,] array = new long[ROWS, COLUMNS];

        for (int row = 0; row < ROWS; row++)
        {
            for (int column = 0; column < COLUMNS; column++)
            {
                Console.WriteLine("Enter the value for ({0},{1})",
                    row + 1, column + 1);
                array[row, column] = Convert.ToInt64(Console.ReadLine());
            }
        }
        if ((array[0, 0] == array[1, 0]
                && array[0, 1] == array[1, 1]
                && array[0, 2] == array[1, 2])
            || (array[0, 0] == array[2, 0]
                && array[0, 1] == array[2, 1]
                && array[0, 2] == array[2, 2])
            || (array[1, 0] == array[2, 0]
                && array[1, 1] == array[2, 1]
                && array[1, 2] == array[2, 2]))
        {
            Console.Write("At least on row is repeated");
        }
        else
        {
            Console.Write("There are no repeated rows");
        }
    }
}
