using System;

public class FunctionIsCircularPrime
{
    public static bool IsPrime(long x)
    {
        for(long i = 2; i < x / 2; i++)
        {
            if(x % i == 0)
                return false;
        }
        return true;
    }
    
    public static bool IsCircularPrime(long x)
    {
        string numberStr = x.ToString();
        int size = numberStr.Length;
        
        for(int i = 0; i < size; i++)
        {
            if(!IsPrime( Convert.ToInt64(numberStr) ))
                return false;
            numberStr = numberStr.Substring(1) + numberStr[0];
        }
        return true;
    }
    
    
    public static void Main()
    {
        for (long i = 1; i<= 10000; i++)
            if (IsCircularPrime(i))
                Console.Write(i + " ");
    }
}
