using System;

class CountLetter
{
    static int Count(string text, char c)
    {
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == c)
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
