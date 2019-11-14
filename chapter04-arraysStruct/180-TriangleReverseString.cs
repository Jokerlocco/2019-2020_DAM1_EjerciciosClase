//Abraham García

using System;

class TriangleOfStringReversed
{
    static void Main()
    {
        Console.WriteLine("Enter some text: ");
        string text = Console.ReadLine().ToUpper();

        string result = "";
        for (int i = text.Length-1; i >=  0; i--)
        {
            result += text.Substring(i,1);
            Console.WriteLine(result);
        }
    }
}
