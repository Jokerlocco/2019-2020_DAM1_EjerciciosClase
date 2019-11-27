using System;

class MaxMinArray
{
    static void MaxMin( int[] num, out int max, out int min)
    {
        max = num[0];
        min = num[0];
        foreach ( int i in num )
        {
            if ( i > max )
                max = i;
            if ( i < min )
                min = i;
        }
    }
    
    static void Main()
    {     
        int[] num = {20, 30, -5, 2};
        int max;
        int min;
        
        MaxMin(num, out max, out min);
        
        Console.WriteLine(max);
        Console.WriteLine(min);
    }
}
