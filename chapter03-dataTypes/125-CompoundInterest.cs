//Francisco jimenez velasco
using System;
class Intereses
{
    static void Main()
    {       
        Console.Write("Enter the amount of money: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        Console.Write("Rate (0,1 for 10%): ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Quantity of years: ");
        int years = Convert.ToInt32(Console.ReadLine());
        
        // Console.WriteLine( amount * Math.Pow(1+rate, years) );
        
        double multiplier = rate + 1;        
        for(int  j = 1 ; j < years ;j++)
        {
            multiplier *= (rate + 1);
        }
        
        double result = amount * multiplier;
        Console.Write(result);
    }
}
