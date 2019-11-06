//Sergio Gumpert

/*
Sample input
963123456789012 1
2 3
4   5 -1

Sample output
963123456789013
5
8
*/

using System;

class HardSum
{
    static void Main()
    {
        string sumandos = Console.ReadLine();
        
        while (sumandos != "")
        {
            string[] parts = sumandos.Split();
            long suma = 0;
            foreach (string s in parts)
            {
                if (s != "")
                    suma = suma + (Convert.ToInt64(s));
            }
            Console.WriteLine(suma);
            
            sumandos = Console.ReadLine();
        }
    }
}
