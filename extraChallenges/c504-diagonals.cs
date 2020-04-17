//kiko
using System;
class Diagonal
{
    static void Main()
    {
        int length = Convert.ToInt32(Console.ReadLine());
        string moves = Console.ReadLine();
        moves = moves.Replace("UR", "D");
        moves = moves.Replace("RU", "D");
        Console.WriteLine(moves.Length);
    }
}
