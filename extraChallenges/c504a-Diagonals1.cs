//kiko

/*
input
5
RUURU
output
3

input
17
UUURRRRRUUURURUUU
output
13

input
4
RURU
output
2

input
4
URUR
output
2
 
input
4
UURUR
output
3
*/

using System;
class Diagonal
{
    static void Main()
    {
        int length = Convert.ToInt32(Console.ReadLine());
        string moves = Console.ReadLine();
        
        int diagonals = 0;
        moves = moves.Replace("UR", "D");
        string moves2 = moves.Replace("D", "");
        diagonals = moves.Length-moves2.Length;
        moves = moves2.Replace("RU", "D");

        Console.WriteLine(diagonals + moves.Length);
    }
}
