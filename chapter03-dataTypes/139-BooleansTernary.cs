//Saúl Cánovas Navarro

using System;

class BooleansTernary
{
    static void Main()
    {
        int num1, num2;
        bool bothEven;

        Console.Write("Enter a number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        bothEven = num1 % 2 == 0 && num2 % 2 == 0 ? true : false;
        
        // Note: alternative way, not using a ternary:
        bothEven = num1 % 2 == 0 && num2 % 2 == 0;
    }
}
