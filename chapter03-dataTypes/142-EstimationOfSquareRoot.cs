//Abraham García  - Square root cuadrada aproximada

using System;

class EstimationOfSquareRoot
{
    static void Main()
    {
        string text;
        int n=0;
        float i=1;
        
        do 
        {
            Console.Write("Number (\"end\" to finish)? ");
            text = Console.ReadLine();
            
            i=1;
            
            if (text != "end")
            {
                n = Convert.ToInt32(text);
                
                while (i*i < n)
                    i++;
                    
                if (i*i == n)
                    Console.WriteLine("Square root: {0} (exact)",i);
                else
                {
                    i--;
                    while (i*i < n)
                        i = i+0.01f;
                    
                    if (i*i > n)
                        i = i-0.01f;
                    
                    Console.WriteLine(
                        "Square root: {0} (not exact)",
                        i.ToString("0"));
                    Console.WriteLine(
                        "Square root with two decimal places: {0}",
                        i.ToString("0.00"));
                }
            }
            
        } while (text != "end");
    }
}
