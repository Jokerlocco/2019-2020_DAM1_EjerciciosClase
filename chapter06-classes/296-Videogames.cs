//Abraham García + Nacho - Videogames (V2: Classes)

/*
Create a C# program that can store up to 10000 computer games and other 
software. For each game, it must allow the user to store the following 
information:

    - Title (e.g. GranTurismo 6)
    - Category (e.g. Racing)
    - Platform (e.g. PS3)
    - Year (e.g. 2013)
    - Rating (e.g. 8.7)
    - Comments


The program should allow the user to perform the following operations :

1 - Add a new game (at the end of the existing data). The title and 
description cannot be empty. The year, if entered, must be from 1940 to 
2100. The rating, if entered, must be 0 to 10. No other validation must 
be done.

2 - Show all the data of a certain game (chose by number o exact title, 
case insensitive).

3 - Show all the games of a certain platform and category. You must 
display the record number, the title, year and rating, pausing after 
every 22 rows. 

4 - Find games containing a certain text (partial search, in any text 
field, not case sensitive). You must display the record number, the 
title, year and rating, pausing after every 22 rows.

5 - Update a record: ask the user for its number, display the previous 
value of each field and then user press Enter not to modify any of the 
data. The user should be warned (but not asked again) if he enters an 
incorrect record number. The year and rating, if entered, must be 
valid.

6 - Delete a record, in the position entered by the user. He should be 
warned (but not asked again) if he enters an incorrect record number. 
It should display the record to be deleted and ask for confirmation 
before the deletion.

7 - Sort data alphabetically, by title and (if necessary) platform.

8 - Eliminate redundant spaces: remove trailing spaces, leading spaces 
and duplicated spaces in description, category and platform.

Q - Quit the application (as we do not store the information on file, 
data will be lost). 

*/

using System;

class Game
{
    public string Title { get; set; }
    public string Category { get; set; }
    public string Platform { get; set; }
    public ushort Year { get; set; }
    public string Rating { get; set; }
    public string Comments { get; set; }
}

class VideogamesManagementSystemVersion2
{
    static void Main()
    {
        const int MAX = 10000;

        Game[] videoGame = new Game[MAX];
        string option;
        int amount = 0;

        do
        {
            Console.WriteLine("1. Add new videogame");
            Console.WriteLine("2. Show videogame data");
            Console.WriteLine("3. Show all games of a platform and category");
            Console.WriteLine("4. Search videogame by partial text");
            Console.WriteLine("5. Edit entry");
            Console.WriteLine("6. Delete entry");
            Console.WriteLine("7. Sort by title (and platform)");
            Console.WriteLine("8. Correct ortography");
            Console.WriteLine("Q. Exit");
            Console.WriteLine();
            Console.Write("Please, select an option: ");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    if (amount >= MAX)
                        Console.WriteLine("Not enough space");
                    else
                    {
                        videoGame[amount] = new Game();
                        Console.WriteLine("Adding new game...");
                        do
                        {
                            Console.Write("Title: ");
                            videoGame[amount].Title = Console.ReadLine();

                            if (videoGame[amount].Title == "")
                                Console.WriteLine("Title can't be empty!");

                        } while (videoGame[amount].Title == "");


                        do
                        {
                            videoGame[amount].Category = Console.ReadLine();

                            if (videoGame[amount].Category == "")
                                Console.WriteLine("Title can't be empty!");

                        } while (videoGame[amount].Category == "");

                        do
                        {
                            string yearAsString;
                            Console.Write("Year: ");
                            yearAsString = Console.ReadLine();

                            if (yearAsString == "")
                                videoGame[amount].Year = 0;
                            else
                                videoGame[amount].Year =
                                    Convert.ToUInt16(yearAsString);

                            if ((videoGame[amount].Year != 0) &&
                                    (videoGame[amount].Year < 1940 ||
                                    videoGame[amount].Year > 2100))
                                Console.WriteLine
                                    ("It must be between 1940 and 2100");

                        } while ((videoGame[amount].Year != 0) &&
                                    (videoGame[amount].Year < 1940 ||
                                    videoGame[amount].Year > 2100));

                        do
                        {
                            Console.Write("Rating: ");
                            videoGame[amount].Rating = Console.ReadLine();

                            if ((videoGame[amount].Rating != "") &&
                                    ((Convert.ToDouble(videoGame[amount].Rating) < 0) ||
                                    (Convert.ToDouble(videoGame[amount].Rating) > 10)))
                                Console.WriteLine("Please, between 0 and 10");

                        } while ((videoGame[amount].Rating != "") &&
                                    ((Convert.ToDouble(videoGame[amount].Rating) < 0) ||
                                    (Convert.ToDouble(videoGame[amount].Rating) > 10)));


                        Console.Write("Platform: ");
                        videoGame[amount].Platform = Console.ReadLine();
                        Console.Write("Comments: ");
                        videoGame[amount].Comments = Console.ReadLine();

                        amount++;
                    }
                    break;

                case "2":
                    if (amount == 0)
                        Console.WriteLine("List is empty");
                    else
                    {
                        bool notFound = false;
                        Console.WriteLine("By number or by title? ");
                        Console.WriteLine("1. By title");
                        Console.WriteLine("2. By number");

                        string nOrTitle = Console.ReadLine();
                        if (nOrTitle == "1")
                        {
                            Console.WriteLine("Select a title, please");
                            string searchTitle = Console.ReadLine().
                                ToUpper();

                            for (int i = 0; i < amount; i++)
                            {
                                if (searchTitle == videoGame[i].Title.
                                    ToUpper())
                                {
                                    Console.WriteLine(videoGame[i].Title);
                                    Console.WriteLine(videoGame[i].Category);
                                    Console.WriteLine(videoGame[i].Platform);
                                    Console.WriteLine(videoGame[i].Year);
                                    Console.WriteLine(videoGame[i].Rating);
                                    Console.WriteLine(videoGame[i].Comments);
                                }
                                else
                                    notFound = true;
                            }

                        }
                        else if (nOrTitle == "2")
                        {
                            Console.WriteLine("Select a entry, please: ");
                            int entry = Convert.ToInt32(Console.ReadLine()) - 1;

                            for (int i = 0; i < amount; i++)
                            {
                                if (entry == i)
                                {
                                    Console.WriteLine(videoGame[entry].Title);
                                    Console.WriteLine(videoGame[entry].Category);
                                    Console.WriteLine(videoGame[entry].Platform);
                                    Console.WriteLine(videoGame[entry].Year);
                                    Console.WriteLine(videoGame[entry].Rating);
                                    Console.WriteLine(videoGame[entry].Comments);
                                }
                                else
                                    notFound = true;
                            }

                        }
                        else
                            Console.WriteLine("Select a valid option");

                        if (notFound)
                            Console.Write("That title couldn't be found");
                    }
                    break;

                case "3":
                    Console.Write("Enter platform: ");
                    string platform = Console.ReadLine();
                    Console.Write("Enter category: ");
                    string cat = Console.ReadLine();

                    for (int i = 0; i < amount; i++)
                    {
                        if (videoGame[i].Platform == platform)
                        {
                            for (int j = 0; j < amount; j++)
                            {
                                if (videoGame[j].Category == cat)
                                {
                                    Console.WriteLine
                                        ("Entry " + (j + 1));
                                    Console.WriteLine
                                        (videoGame[j].Title);
                                    Console.WriteLine
                                        (videoGame[j].Year);
                                    Console.WriteLine
                                        (videoGame[j].Rating);
                                    if (j % 21 == 20)
                                        Console.ReadLine();
                                }
                            }
                        }
                    }
                    break;

                case "4":
                    Console.Write("Enter text: ");
                    string newText = Console.ReadLine();

                    for (int i = 0; i < amount; i++)
                    {
                        if (videoGame[i].Title.ToUpper().Contains
                            (newText.ToUpper()) ||
                            videoGame[i].Category.ToUpper().Contains
                            (newText.ToUpper()) ||
                            videoGame[i].Platform.ToUpper().Contains
                            (newText.ToUpper()) ||
                            videoGame[i].Comments.ToUpper().Contains
                            (newText.ToUpper()))
                        {
                            Console.WriteLine
                                ("Entry " + (i + 1));
                            Console.WriteLine
                                (videoGame[i].Title);
                            Console.WriteLine
                                (videoGame[i].Year);
                            Console.WriteLine
                                (videoGame[i].Rating);
                            if (i % 21 == 20)
                                Console.ReadLine();
                        }
                    }
                    break;

                case "5":
                    Console.Write("Enter data entry: ");
                    int newData = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (newData > amount)
                        Console.WriteLine("Number to long");
                    else
                    {
                        Console.WriteLine("Enter title (before {0}: ",
                            videoGame[newData].Title);
                        string newTitle = Console.ReadLine();
                        if (newTitle != "")
                            videoGame[newData].Title = newTitle;

                        Console.WriteLine("Enter category (before {0}: ",
                            videoGame[newData].Category);
                        string newCat = Console.ReadLine();
                        if (newCat != "")
                            videoGame[newData].Category = newCat;

                        Console.WriteLine("Enter platform (before {0}: ",
                            videoGame[newData].Platform);
                        string newPlatform = Console.ReadLine();
                        if (newPlatform != "")
                            videoGame[newData].Platform = newPlatform;

                        Console.WriteLine("Enter year (before {0}: ",
                            videoGame[newData].Year);
                        string newYear = Console.ReadLine();
                        if (newYear != "")
                        {
                            ushort newYearINT = Convert.ToUInt16(newYear);
                            if (newYearINT < 1940 ||
                            newYearINT > 2100)
                            {
                                Console.WriteLine
                                    ("It must be between 1940 and 2100");
                                Console.WriteLine("Operation cancelled");
                            }
                            else
                                videoGame[newData].Year = newYearINT;
                        }

                        Console.WriteLine("Enter note (before {0}: ",
                            videoGame[newData].Rating);
                        string newNote = Console.ReadLine();
                        if (newNote != "")
                        {
                            double newNoteDOUBLE = Convert.ToUInt16(newNote);
                            if (newNoteDOUBLE < 0 || newNoteDOUBLE > 10)
                            {
                                Console.WriteLine("Please, between 0 and 10");
                                Console.WriteLine("Operation cancelled");
                            }
                            else
                                videoGame[newData].Rating = newNote;
                        }

                        Console.WriteLine("Enter comment (before {0}: ",
                            videoGame[newData].Comments);
                        string newComment = Console.ReadLine();
                        if (newComment != "")
                            videoGame[newData].Comments = newComment;
                    }
                    break;

                case "6":
                    Console.Write("Select entry to delete: ");
                    int delEntry = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (delEntry >= amount)
                        Console.WriteLine("Too long number");
                    else
                    {
                        Console.WriteLine("Do yo want to delete {0}?",
                            videoGame[delEntry].Title);
                        Console.Write("y / n");
                        char delete = Convert.ToChar(Console.ReadLine());

                        if (delete == 'y')
                        {
                            for (int i = delEntry; i < amount; i++)
                                videoGame[i] = videoGame[i + 1];

                            amount--;
                        }
                        else if (delete == 'n')
                            Console.WriteLine("Operation cancelled");
                        else
                            Console.WriteLine("Not a valid option");

                    }
                    break;

                case "7":
                    for (int i = 0; i < amount - 1; i++)
                    {
                        for (int j = i + 1; j < amount; j++)
                        {
                            if ((videoGame[i].Title.CompareTo(
                                    videoGame[j].Title) > 0)
                                ||
                                (
                                (videoGame[i].Title ==
                                videoGame[j].Title)
                                &&
                                (videoGame[i].Platform.CompareTo(
                                videoGame[j].Platform) > 0))
                                )

                            {
                                Game aux = new Game();
                                aux = videoGame[i];
                                videoGame[i] = videoGame[j];
                                videoGame[j] = aux;
                            }
                        }
                    }
                    break;

                case "8":
                    for (int i = 0; i < amount; i++)
                    {
                        videoGame[i].Title.TrimStart();
                        videoGame[i].Title.TrimEnd();
                        videoGame[i].Category.TrimStart();
                        videoGame[i].Category.TrimEnd();
                        videoGame[i].Platform.TrimStart();
                        videoGame[i].Platform.TrimEnd();

                        /* while (videoGame[i].title.Contains("  "));
                             videoGame[i].title.Replace("  "," ");
                         while (videoGame[i].cat.Contains("  "));
                             videoGame[i].cat.Replace("  "," ");
                         while (videoGame[i].platform.Contains("  "));
                             videoGame[i].platform.Replace("  "," ");*/
                    }
                    Console.WriteLine("Ortography corrected");
                    break;
                case "q":
                case "Q":
                    Console.WriteLine("Bye!");
                    break;

                default:
                    Console.WriteLine("Select a valid option");
                    break;
            }

        } while (option != "q" && option != "Q");
    }
}
