using System;

class Palindrome1
{
    static bool IsPalindrome(string text)
    {
        string textReversed = "";
        
        for (int i = text.Length-1; i >= 0; i--)
        {
            textReversed += text[i];
        }
        
        if (text == textReversed)
            return true;
        else
            return false;
    }
    
    static void Main()
    {
        bool result = IsPalindrome("radar");
        Console.WriteLine("radar -> " + result);
    }
}
