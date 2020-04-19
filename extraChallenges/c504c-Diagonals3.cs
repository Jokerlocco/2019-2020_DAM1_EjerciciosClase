//Pablo Conde -17/04/2020  Andando en diagonal
//http://codeforces.com/problemset/problem/954/A

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

class AndandoEnDiagonal
{
    static void Main()
    {
        int longitud = Convert.ToInt32(Console.ReadLine());
        string secuencia = Console.ReadLine().ToUpper();
        
       while(secuencia.Contains("UR") || secuencia.Contains("RU"))
       {
           string cambio = "";
           int posUR = secuencia.IndexOf("UR");
           int posRU = secuencia.IndexOf("RU");
           
           if(posUR >= 0 && posRU >= 0)
           {
               if(posUR < posRU)
                cambio = "UR";
                
               else
                cambio = "RU";
                
            }
            else if(posUR < 0)
                cambio = "RU";
                
            else if(posRU < 0)
                cambio = "UR";
                
            secuencia = secuencia.Replace(cambio, "D");
        }
        Console.WriteLine(secuencia.Length);
    }
}
