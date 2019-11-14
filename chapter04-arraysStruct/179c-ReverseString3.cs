//Abraham García - String reversed

using System;

class StringReversed
{
    static void Main()
    {
        Console.WriteLine("Enter some text: ");
        string text = Console.ReadLine();

        char[] letters = text.ToCharArray();
        Array.Reverse(letters);
        string result = new string(letters);

        Console.WriteLine(result);
    }
}
