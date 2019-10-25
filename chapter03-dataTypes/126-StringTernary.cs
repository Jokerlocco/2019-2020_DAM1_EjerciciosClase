//Abraham García - string condicional

using System;

class StringAndTernary
{
    static void Main()
    {
        string markAsText;
        int mark;
        
        Console.Write("mark? ");
        mark=Convert.ToInt32(Console.ReadLine());
        
        if (mark >= 60)
            markAsText = "passed";
        else
            markAsText = "failed";
        Console.WriteLine(markAsText);
        
        // -------
        
        markAsText = (mark >= 60) ? "passed" : "failed";
        Console.WriteLine(markAsText);
        
        // -------
        
        Console.WriteLine( 
            mark >= 60 ? "passed" : "failed");
        
    }
}
