using System;

class Palindrome2
{
    static bool IsPalindrome(string text)
    {
        string textReversed = "";
        
        for (int i = text.Length-1; i >= 0; i--)
        {
            textReversed += text[i];
        }
        
        return text == textReversed;
    }
    
    static void Main()
    {
        bool result = IsPalindrome("radar");
        Console.WriteLine("radar -> " + result);
    }
}
