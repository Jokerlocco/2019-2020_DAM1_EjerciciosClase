// Jose Valera

/*
Team lunch

Example for 4 diners:
     O
   +---+
 O | 1 | O
   +---+
     O

4 diners -> 1 table

Example for 5 diners:
     O   O
   +---+---+
 O | 1 | 2 |
   +---+---+
     O   O

5 diners -> 2 tables

Sample Input
4
4
6
5
3

Sample Output
Case #1: 1
Case #2: 2
Case #3: 2
Case #4: 1
*/

using System;

class TeamLunch
{
    static void Main()
    {
        byte cases, example = 1;
        uint diners, tables;
        
        cases = Convert.ToByte(Console.ReadLine());
        
        while (cases > 0)
        {
            diners = Convert.ToUInt32(Console.ReadLine());
            
            if (diners > 4)
                tables = (diners - 1) / 2 ;
            
            else
                tables = 1;
            
            Console.WriteLine("Case #{0}: {1}", example, tables);
            
            cases--;
            example++;
        }
    }
}
