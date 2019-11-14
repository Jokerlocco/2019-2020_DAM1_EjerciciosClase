using System;

// TicTacToe, first step

class TicTacToe
{
    static void Main()
    {
        char[,] board = new char[3,3];
        for (int r = 0; r < 3; r++)
            for (int c = 0; c < 3; c++)
                board[r, c] = '·';

        Console.Write("Enter row: ");
        int row = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.Write("Enter column: ");
        int column = Convert.ToInt32(Console.ReadLine()) - 1;

        board[row, column] = 'X';

        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write(board[r, c]);
            }
            Console.WriteLine();
        }


    }
}
