using System;

class Palindrome
{
    static bool IsPalindrome(string text)
    {
        int left = 0, right = text.Length-1;
        bool isPalind = true;
        
        while (left <= right && isPalind)
        {
            if (text[left] != text[right])
                isPalind = false;
            left ++;
            right --;
        }
        return isPalind;
    }
    
    public static void Main()
    {
        bool result = IsPalindrome("radar");
        Console.WriteLine("radar -> " + result);
    }
}
