// Pablo Vigara Fernández
// Is a number a valid integer?

using System;

class IntegerNumber
{
    static bool IsInteger(string num)
    {        
        foreach (char x in num)
            if (x < '0' || x > '9')
                return false;
        return true;
    }
    
    
    static void Main ()
    {
        
        if (IsInteger(Console.ReadLine()))
        {
            Console.WriteLine("It is an integer number");
        }
        else
            Console.WriteLine("It is not an integer number");
    }
}
