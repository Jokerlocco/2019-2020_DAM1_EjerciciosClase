//Saúl Cánovas Navarro


using System;

class IfSwitchChar
{
    static void Main()
    {
        char symbol;

        Console.Write("Enter a symbol: ");
        symbol = Convert.ToChar(Console.ReadLine());

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
            case '9': Console.WriteLine("Digit"); break;
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u': Console.WriteLine("Vowel"); break;
            case '"':
            case '\'': Console.WriteLine("Quotation mark"); break;
            default: Console.WriteLine("Another symbol"); break;
        }

        if(symbol <= '9' && symbol >= '0')
        {
            Console.WriteLine("Digit");
        }
        else if(symbol == 'a' || symbol == 'e' || symbol == 'i' 
            || symbol == 'o' || symbol == 'u')
        {
            Console.WriteLine("Vowel");
        }
        else if(symbol == '"' || symbol == '\'' )
        {
            Console.WriteLine("Quotation mark");
        }
        else
        {
            Console.WriteLine("Another symbol");
        }
    }
}
