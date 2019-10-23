//Abraham García - Symbols

using System;

class Symbols
{
    static void Main()
    {
        char symbol;
        
        Console.Write("Introduce símbolo: ");
        symbol=Convert.ToChar(Console.ReadLine());
        
        if (symbol >= '0' && symbol <= '9')
            Console.WriteLine("Digit");
        else if (symbol == '+' || symbol == '-' || symbol == '*'
                    || symbol == '/'|| symbol == '%')
            Console.WriteLine("Operator");
        else if (symbol == '.' || symbol == ',' || symbol == ';'
                    || symbol == ':')
            Console.WriteLine("Punctuation symbol");
        else
            Console.WriteLine("Another symbol");
            
        switch (symbol)
        {
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                Console.WriteLine("Digit");
                break;
            case '+':
            case '-':
            case '*':
            case '/':
            case '%':
                Console.WriteLine("Operator");
                break;
            case '.':
            case ',':
            case ';':
            case ':':
                Console.WriteLine("Punctuation symbol");
                break;
            default:
                Console.WriteLine("Another symbol");
                break;
        }
    }
}
