//Joel Martinez

using System;

class MaximoComunDivisor
{
    static int mcd(int num1, int num2)
    {
        if (num2 == 0)
        {
            return num1;
        } 
        
        int aux = 0;
        while (num2 != 0)
        {
            aux = num1;
            num1 = num2;
            num2 = aux % num2;
        }
        
        return num1;
    }
    
    static int mcdR(int num1, int num2)
    {
        if (num2 == 0)
        {
            return num1;
        } 
        
        return mcdR(num1, num2 % num1);
    }
    
    static void Main()
    { 
        int num1 = 18;
        int num2 = 12;
        Console.WriteLine(mcd(num1, num2));
        Console.WriteLine(mcdR(num1, num2));
    }
}
