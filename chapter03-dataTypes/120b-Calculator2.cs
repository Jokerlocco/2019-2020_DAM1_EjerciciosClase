//Abraham García - calculadoraV2

using System;

class calculadora
{
    static void Main()
    {
        double n1,n2;
        char op;
        byte correct = 1;
        double result=0;
        
        Console.Write("Enter the first number: ");
        n1=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the operation: ");
        op=Convert.ToChar(Console.ReadLine());
        Console.Write("Enter the second number: ");
        n2=Convert.ToDouble(Console.ReadLine());
        
        switch (op)
        {
            case '+':
                result = n1 + n2;
                break;
            case '-':
                result = n1 - n2;
                break;
            case '/':
                result = n1 / n2;
                break;
            case 'x':
            case '*':
            case '.':
                result = n1 * n2;
                break;
            default:
                correct = 0;
                Console.WriteLine("That operator is not valid");
                break;
        }
        
        if (correct == 1)
            Console.WriteLine("{0} {1} {2} = {3}",n1,op,n2,result);
    }
}
        
        
