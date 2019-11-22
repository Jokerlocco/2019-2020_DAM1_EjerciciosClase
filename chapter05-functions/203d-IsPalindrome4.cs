using System;

class Palindrome
{
    static bool IsPalindrome(string text)
    {
        int left = 0, right = text.Length-1;
        
        while (left <= right)
        {
            if (text[left] != text[right])
                return false;
            left ++;
            right --;
        }
        return true;
    }
    
    public static void Main()
    {
        bool result = IsPalindrome("radar");
        Console.WriteLine("radar -> " + result);
    }
}
