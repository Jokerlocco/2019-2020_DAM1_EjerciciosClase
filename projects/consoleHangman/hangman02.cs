using System;
using System.Text;

class Hangman
{
    public static void Main()
    {
        string[] words = { "frozen", "madagascar", "kung fu panda" };
        string lettersUsed = "";
        int r = new Random().Next(0, words.Length);

        string wordToFind = words[r].ToUpper();
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
            Console.WriteLine("Failed: " + lettersUsed);
            Console.Write("Enter a letter: ");
            char c = Convert.ToChar(Console.ReadLine().ToUpper());

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
                lettersUsed += c;
                ShowStatus(attemptsRemaining);
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

    static void ShowStatus(int attemptsRemaining)
    {
        switch (attemptsRemaining)
        {
            case 7:
                Console.WriteLine("-");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 6:
                Console.WriteLine("-------");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 5:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 4:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 3:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 2:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 1:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|   / ");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 0:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|   / \\");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
        }
    }
}
