// Is the name of a month valid?

using System;

class SearchMonth
{
    static void Main()
    {
        bool found = false;
        
        string[] months = { 
            "January", "February", "March", 
            "April", "May", "June", 
            "July", "August", "September", 
            "October", "November","December"};
            
        Console.Write("Enter a month: ");
        string userMonth = Console.ReadLine();
        
        foreach(string m in months)
            if(userMonth == m)
                found = true;
        
        if(found)
            Console.WriteLine("{0} is a real month", userMonth);
        else
            Console.WriteLine("{0} is NOT a real month", userMonth);
    }
}
