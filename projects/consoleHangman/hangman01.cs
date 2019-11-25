using System;
using System.Text;

class Hangman
{
    public static void Main()
    {
        string[] words = { "frozen", "madagascar", "kung fu panda" };
        int r = new Random().Next(0, words.Length);

        string wordToFind = words[r];
        StringBuilder currentStatus = new StringBuilder(
            new string('-', wordToFind.Length));
        for (int i = 0; i < wordToFind.Length; i++)
        {
            if (wordToFind[i] == ' ')
                currentStatus[i] = ' ';
        }

        int attemptsRemaining = 8;
        bool wordFound = false;
        do
        {
            Console.WriteLine(currentStatus);
            Console.WriteLine("Attempts remaining: " + attemptsRemaining);
            Console.Write("Enter a letter: ");
            char c = Convert.ToChar(Console.ReadLine());

            bool letterFound = false;
            for (int i = 0; i < wordToFind.Length; i++)
            {
                if (wordToFind[i] == c)
                {
                    currentStatus[i] = c;
                    letterFound = true;
                }
            }
            if (!letterFound)
            {
                Console.WriteLine("Oops!");
                attemptsRemaining--;
            }

            if (currentStatus.ToString() == wordToFind)
                wordFound = true;
        }
        while (!wordFound && attemptsRemaining > 0 );

        if (wordFound)
            Console.WriteLine("You did it!");
        else
            Console.WriteLine("It was " + wordToFind);
    }
}
