//Avelino Martinez Rodriguez
//Ex.140: switch + String

using System;

class SwitchString
{
    static void Main()
    {
        string text;
        Console.Write("Enter an operator or delimiter: ");
        text = Console.ReadLine();

        switch (text)
        {
            case "<":
            case ">":
            case "<=":
            case ">=":
            case "==":
            case "!=":
                Console.WriteLine("It is a comparator");
                break;
            case "+":
            case "-":
            case "*":
            case "/":
            case "%":
                Console.WriteLine("It is a operator");
                break;
            case "\"":
            case "'":
                Console.WriteLine("It is a text delimiter");
                break;
            default:
                Console.WriteLine("Not valid");
                break;
        }
        
        if (text == "<" || text == ">" || text == "<=" ||
            text == ">=" || text == "==" || text == "!=")
            Console.WriteLine("It is a comparator");
        else if (text == "+" || text == "-" ||
            text == "*" || text == "/" || text == "%")
            Console.WriteLine("It is a operator");
        else if (text == "\"" || text == "'")
            Console.WriteLine("It is a text delimiter");
        else
            Console.WriteLine("No es valido");
    }
}     
