// Estimation of Pi using Leibniz's formula

using System;

public class LeibnizPIApproach
{
    public static void Main()
    {
        Console.Write("Terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());
                
        double sumOfTerms = 0;
        
        for(int i = 0; i < terms; i++)
        {
            if(i % 2 == 1)
            {
                sumOfTerms -= 1.0/(2*i+1);
            }
            else
            {
                sumOfTerms += 1.0/(2*i+1);
            }
        }
        
        double pi = sumOfTerms * 4;
        
        Console.Write("Pi is approximately " + pi);
    }
}
