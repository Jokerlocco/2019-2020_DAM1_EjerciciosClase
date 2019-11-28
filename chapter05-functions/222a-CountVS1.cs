//Daniel Contreras

using System;

class ExerciseCountVS
{
    static void CountVS(string word, 
        out int vowels, 
        out int spaces)
    {
        vowels = 0;
        spaces = 0;
        foreach (char c in word)
        {
            if (c == ' ')
            {
                spaces++;
            }
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                vowels++;
            }
        }
    }


    static void Main()
    {
        string word = "Esta es una frase";
        int spaces;
        int vowels;

        CountVS(word, out vowels, out spaces);
        Console.WriteLine("vowels: " + vowels);
        Console.WriteLine("spaces: " + spaces);
    }
}
