using System;

public class Search2
{
    public static void Main()
    {
        int[] data = { 10, 20, 30, 40, 50, 60, 70, 80};
        
        Console.WriteLine("Enter the data to search for: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        bool found = false;
        int i =0 ;
        while(i < data.Length && ! found)
        {
            if(data[i]==num)
            {
               found = true;
            }
            i++;
        }
        if(found)
            Console.WriteLine("Found");
        else
            Console.WriteLine("Not found");
    }
}
