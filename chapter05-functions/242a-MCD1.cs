//Pablo Conde
//Contar Mm

using System;

class MaxComunDivisor
{
    static void Main()
    {
        int a = 51;
        int b = 17;
        
        Console.WriteLine(Mcd(a, b));
        Console.WriteLine(McdR(a, b));
        
    } 
    
    static int Mcd( int a, int b)
    {
        bool encontrado = false;
        int min, max;
        
        if (a < b)
        {
            min = a;
            max = b;
            
        }
        else
        {
           min = b;
            max = a; 
        }
            
        
        int mcd = 1;
        int i = max;
        
        while ( i >= 1 && !encontrado)
        {
            if(min % i == 0 && max % i == 0)
            {
               mcd = i;
               encontrado = true; 
            }
            i--;
        }
        
        return mcd;
    }
    static int McdR (int a, int b)
    {
        if (b == 0)
            return a;
        
        return McdR(b, a%b);
    }
 
}
