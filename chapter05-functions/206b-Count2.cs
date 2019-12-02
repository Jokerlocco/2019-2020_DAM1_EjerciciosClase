using System;

class CountLetter2
{
    static int Count(string text, char c)
    {
        int count = 0;
        foreach (char l in text)
        {
            if (l == c)
                count++;
        }
        return count;
    }

    static void Main()
    {
        int amount = Count("madagascar", 'a');
        Console.WriteLine(amount);
    }
}
