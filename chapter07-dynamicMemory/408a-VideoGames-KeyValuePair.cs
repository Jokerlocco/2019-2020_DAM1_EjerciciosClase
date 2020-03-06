//Abraham García + Nacho + Sergio Gumpert - Videogames (V3: SortedList)

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
using System.Collections.Generic;

class Game : IComparable<Game>
{
    public string Title { get; set; }
    public string Category { get; set; }
    public string Platform { get; set; }
    public ushort Year { get; set; }
    public string Rating { get; set; }
    public string Comments { get; set; }

    public int CompareTo(Game g)
    {
        int result = this.Title.CompareTo(g.Title);
        if (result == 0)
            result = this.Platform.CompareTo(g.Platform);
        return result;
    }
    public override string ToString()
    {
        return Title + "\n" + Category + "\n" +  Platform + "\n" +  Year 
                + "\n" +  Rating + "\n" +  Comments;
    }
}

class VideogamesManagementSystemVersion2
{
    static void Main()
    {
        SortedList<string,Game> videoGame = new SortedList<string,Game>();
        string option;
        string key;
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
                case "1": //ADD GAME
                    Game g = new Game();
                    Console.WriteLine("Adding new game...");
                    
                    bool validKey;
                    do
                    {
                        validKey = true;
                        Console.Write("Code to identify this game: ");
                        key = Console.ReadLine();

                        if (key == "")
                        {
                            Console.WriteLine("Code can't be empty!");
                            validKey = false;
                        }
                        
                        if (videoGame.ContainsKey(key))
                        {
                            Console.WriteLine("Code can't be duplicated!");
                            validKey = false;
                        }
                    } while (! validKey);
                    
                    
                    do
                    {
                        Console.Write("Title: ");
                        g.Title = Console.ReadLine();

                        if (g.Title == "")
                            Console.WriteLine("Title can't be empty!");

                    } while (g.Title == "");

                    do
                    {
                        g.Category = Console.ReadLine();

                        if (g.Category == "")
                            Console.WriteLine("Title can't be empty!");

                    } while (g.Category == "");

                    do
                    {
                        string yearAsString;
                        Console.Write("Year: ");
                        yearAsString = Console.ReadLine();

                        if (yearAsString == "")
                            g.Year = 0;
                        else
                            g.Year =
                                Convert.ToUInt16(yearAsString);

                        if ((g.Year != 0) &&
                                (g.Year < 1940 ||
                                g.Year > 2100))
                            Console.WriteLine
                                ("It must be between 1940 and 2100");

                    } while ((g.Year != 0) &&
                                (g.Year < 1940 ||
                                g.Year > 2100));

                    do
                    {
                        Console.Write("Rating: ");
                        g.Rating = Console.ReadLine();

                        if ((g.Rating != "") &&
                                ((Convert.ToDouble(g.Rating) < 0) ||
                                (Convert.ToDouble(g.Rating) > 10)))
                            Console.WriteLine("Please, between 0 and 10");

                    } while ((g.Rating != "") &&
                                ((Convert.ToDouble(g.Rating) < 0) ||
                                (Convert.ToDouble(g.Rating) > 10)));


                    Console.Write("Platform: ");
                    g.Platform = Console.ReadLine();
                    Console.Write("Comments: ");
                    g.Comments = Console.ReadLine();

                    

                    videoGame.Add(key, g);



                    break;

                case "2": //SHOW DATA
                
                    bool notFound = false;
                    Console.WriteLine("By number or by title? ");
                    Console.WriteLine("1. By Code");
                    Console.WriteLine("2. By title");


                    string nOrTitle = Console.ReadLine();
                    if (nOrTitle == "1")
                    {

                        Console.WriteLine("Game code? ");
                        string gameCode = Console.ReadLine();

                        if (videoGame.ContainsKey(gameCode))
                            Console.WriteLine(videoGame[gameCode]);
                        else
                            Console.WriteLine("Not found");
                    }
                    
                    else if (nOrTitle == "2")
                    {

                        Console.WriteLine("Game code? ");
                        string gameCode = Console.ReadLine();

                        if (videoGame.ContainsKey(gameCode))
                            Console.WriteLine(videoGame[gameCode]);
                        else
                            Console.WriteLine("Not found");
                            
                        foreach (string x in videoGame.Keys)
                        {
                            Console.WriteLine(videoGame[x]);
                            j++;
                            if (j % 21 == 20)
                                Console.ReadLine();
                        }    
                    }


                    break;

                case "3": // Show all
                    Console.Write("Enter platform: ");
                    string platform = Console.ReadLine();
                    Console.Write("Enter category: ");
                    string cat = Console.ReadLine();
                    int j = 0;
                    foreach (string x in videoGame.Keys)
                    {
                        Console.WriteLine(videoGame[x]);
                        j++;
                        if (j % 21 == 20)
                            Console.ReadLine();
                    }
                    break;

                case "4": //SEARCH FROM TEXT
                    Console.Write("Enter text: ");
                    string newText = Console.ReadLine();
                    j = 0;
                    foreach (string x in videoGame.Keys)
                    {
                        
                        if (videoGame[x].Title.ToUpper().Contains
                                (newText.ToUpper()) ||
                                videoGame[x].Category.ToUpper().Contains
                                (newText.ToUpper()) ||
                                videoGame[x].Platform.ToUpper().Contains
                                (newText.ToUpper()) ||
                                videoGame[x].Comments.ToUpper().Contains
                                (newText.ToUpper()))
                        {
                            Console.WriteLine
                                ("Entry " + (j + 1));
                            Console.WriteLine
                                (videoGame[x].Title);
                            Console.WriteLine
                                (videoGame[x].Year);
                            Console.WriteLine
                                (videoGame[x].Rating);
                            if (j % 21 == 20)
                                Console.ReadLine();
                        
                        }
                        j++;
                    }
                    break;

                case "5": // EDIT DATA
                    Console.WriteLine("Game code? ");
                    string gameCodeToEdit = Console.ReadLine();

                    Console.WriteLine("Enter title (before {0}: ",
                        videoGame[gameCodeToEdit].Title);
                    string newTitle = Console.ReadLine();
                    if (newTitle != "")
                        videoGame[gameCodeToEdit].Title = newTitle;

                    Console.WriteLine("Enter category (before {0}: ",
                        videoGame[gameCodeToEdit].Category);
                    string newCat = Console.ReadLine();
                    if (newCat != "")
                        videoGame[gameCodeToEdit].Category = newCat;

                    Console.WriteLine("Enter platform (before {0}: ",
                        videoGame[gameCodeToEdit].Platform);
                    string newPlatform = Console.ReadLine();
                    if (newPlatform != "")
                        videoGame[gameCodeToEdit].Platform = newPlatform;

                    Console.WriteLine("Enter year (before {0}: ",
                        videoGame[gameCodeToEdit].Year);
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
                            videoGame[gameCodeToEdit].Year = newYearINT;
                    }

                    Console.WriteLine("Enter note (before {0}: ",
                        videoGame[gameCodeToEdit].Rating);
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
                            videoGame[gameCodeToEdit].Rating = newNote;
                    }

                    Console.WriteLine("Enter comment (before {0}: ",
                        videoGame[gameCodeToEdit].Comments);
                    string newComment = Console.ReadLine();
                    if (newComment != "")
                        videoGame[gameCodeToEdit].Comments = newComment;

                    break;

                case "6": //DELETE GAME
                    Console.WriteLine("Game code? ");
                    string gameCodeToDelete = Console.ReadLine();

                    Console.WriteLine("Do yo want to delete {0}?",
                        videoGame[gameCodeToDelete].Title);
                    Console.Write("y / n");
                    char delete = Convert.ToChar(Console.ReadLine());

                    if (delete == 'y')
                    {
                        videoGame.Remove(gameCodeToDelete);
                    }
                    else if (delete == 'n')
                        Console.WriteLine("Operation cancelled");
                    else
                        Console.WriteLine("Not a valid option");


                    break;

                case "7": //SORT
                    Console.WriteLine("Sorted.");
                    break;

                case "8": // Correct ortography 
                    foreach (string i in videoGame.Keys)
                    {
                        videoGame[i].Title.TrimStart();
                        videoGame[i].Title.TrimEnd();
                        videoGame[i].Category.TrimStart();
                        videoGame[i].Category.TrimEnd();
                        videoGame[i].Platform.TrimStart();
                        videoGame[i].Platform.TrimEnd();
                    }
                        /* while (videoGame[i].title.Contains("  "));
                             videoGame[i].title.Replace("  "," ");
                         while (videoGame[i].cat.Contains("  "));
                             videoGame[i].cat.Replace("  "," ");
                         while (videoGame[i].platform.Contains("  "));
                             videoGame[i].platform.Replace("  "," ");*/
                    
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
