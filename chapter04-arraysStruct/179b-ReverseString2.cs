//Abraham García - String reversed

using System;

class StringReversed
{
    static void Main()
    {
        Console.WriteLine("Enter some text: ");
        string text = Console.ReadLine();

        string result = "";
        for (int i = text.Length-1; i >=  0; i--)
        {
            result += text[i];
        }
        
        Console.WriteLine(result);
    }
}
