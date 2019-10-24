//Pablo Ferrándiz
using System;
class Ejercicio 
{
    static void Main ()
    {
        long n1, n2;
        char operation;
        
        Console.Write("Enter the first number: ");
        n1 = Convert.ToInt64(Console.ReadLine());
        Console.Write("Enter the operation: ");
        operation = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter the second number: ");
        n2 = Convert.ToInt64(Console.ReadLine());
        
        switch (operation) 
        {
            case 'x':
            case '*':
            case '·': Console.WriteLine("{0} {1} {2} = {3}" 
                                        ,n1, operation, n2, n1*n2); break;
            case '+': Console.WriteLine("{0} {1} {2} = {3}" 
                                        ,n1, operation, n2, n1+n2); break;
            case '-': Console.WriteLine("{0} {1} {2} = {3}"
                                        ,n1, operation, n2, n1-n2); break;
            case '/': Console.WriteLine("{0} {1} {2} = {3}"
                                        ,n1, operation, n2, n1/n2); break;
            default: Console.WriteLine("That operator is not valid"); break;
        }
    }
}
