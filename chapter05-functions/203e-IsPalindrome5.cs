using System;

class Palindrome
{
    static bool IsPalindrome(string text)
    {
        char[] letters = text.ToCharArray();
        Array.Reverse(letters);
        string textReversed = new string(letters);

        return text == textReversed;
    }

    public static void Main()
    {
        bool result = IsPalindrome("radar");
        Console.WriteLine("radar -> " + result);
    }
}
