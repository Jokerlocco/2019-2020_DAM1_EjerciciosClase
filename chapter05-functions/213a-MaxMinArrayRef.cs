using System;

class MaxMinArray
{
    static void MaxMin( int[] num, ref int max, ref int min)
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
        
        MaxMin(num, ref max, ref min);
        
        Console.WriteLine(max);
        Console.WriteLine(min);
    }
}
