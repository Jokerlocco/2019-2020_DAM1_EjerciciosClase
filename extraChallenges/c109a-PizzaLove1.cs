// Abraham García
// Pizza love
// https://contest.tuenti.net/resources/2017/Question_1.html

/*
Sample Input
3
3
8 8 8
2
5 3
4
3 4 5 6
Sample Output
Case #1: 3
Case #2: 1
Case #3: 3
*/

using System;

class Pizza
{
    static void Main()
    {
        int people,portions,cases;
        int totalPortions=0,pizza;

        cases=Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i <= cases; i++)
        {
            people=Convert.ToInt32(Console.ReadLine());
            pizza=0;
            totalPortions=0;
            
            for (int j = 1; j <= people; j++)
            {
                portions=Convert.ToInt32(Console.ReadLine());
                totalPortions += portions;
            }
            
            if (totalPortions%8==0)
                pizza = totalPortions / 8;
            else
                pizza = totalPortions / 8 + 1;

            Console.WriteLine("Case #{0}: {1}",i,pizza);
        } 
    }
}
       
