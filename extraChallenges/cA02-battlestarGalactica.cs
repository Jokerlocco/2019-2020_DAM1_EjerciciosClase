//Pablo Conde - 24/04/2020
//Source: Tuenti Contest 2019, Challenge 2

// Nota: solución no correcta, falla con el segundo caso de prueba

/*
3
7
Galactica:A,B,C
A:E,D
B:D
C:D,F
D:F
E:New Earth
F:New Earth
4
Galactica:A,B,C
B:New Earth
C:New Earth
A:New Earth
5
Galactica:A,B,C
B:F
C:F
A:F
F:New Earth
*/

using System;

class Battlestar
{
    static void Main()
    {
        int cases, totalPlanets, numPaths;
        int analyzed = 1;
        
        cases = Convert.ToInt32(Console.ReadLine());
    
        do
        {
            totalPlanets = Convert.ToInt32(Console.ReadLine());
            
            //We count the different paths from Galactica
            numPaths = Console.ReadLine().Split(',').Length;
            
            //We add the paths from all the planets with 2 or more paths
            //If a planet has only 1 path will be discarted as this is not a new one
            for (int planet = 0; planet < totalPlanets - 1; planet++)
                numPaths += Console.ReadLine().Split(',').Length - 1;
            
            Console.WriteLine("Case #" + analyzed + ": " + numPaths);
            analyzed++;
        }
        while(analyzed <= cases);
    }
}
