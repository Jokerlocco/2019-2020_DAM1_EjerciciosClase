// Note: work in progress, not finished...

using System;
using System.Collections.Generic;

class structVideogames
{
    class Game : IComparable<Game>
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Platform { get; set; }
        public ushort Year { get; set; }
        public string Rating { get; set; }
        public string Comments { get; set; }

        public int CompareTo(Game other)
        {
            int titleComparsion = Title.CompareTo(other.Title);
            if (titleComparsion != 0) return titleComparsion;
            else return Platform.CompareTo(other.Platform);
        }

        public bool Contains(string text)
        {
            return (Title.ToUpper().Contains(text.ToUpper()) ||
                Category.ToUpper().Contains(text.ToUpper()) ||
                Platform.ToUpper().Contains(text.ToUpper()) ||
                Comments.ToUpper().Contains(text.ToUpper()));
        }

        public void Display()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Category);
            Console.WriteLine(Platform);
            Console.WriteLine(Year);
            Console.WriteLine(Rating);
            Console.WriteLine(Comments);
        }
    }

    static string AskForNotEmpty(string fieldName)
    {
        string answer;
        do
        {
            Console.Write(fieldName + ": ");
            answer = Console.ReadLine();

            if (answer == "")
                Console.WriteLine(fieldName + " can't be empty!");
        } while (answer == "");
        return answer;
    }

    static string AskForNewValue(string fieldName, string previousValue)
    {
        Console.WriteLine("Enter "+ fieldName + " + (it was: " + previousValue);
        string answer = Console.ReadLine();
        if (answer != "")
            return answer;
        else
            return previousValue;
    }


    static Game AskForGame()
    {
        Game g = new Game();
        Console.WriteLine("Adding new game...");
        g.Title = AskForNotEmpty("Title");
        g.Category= AskForNotEmpty("Category");

        do
        {
            string yearAsString;
            Console.Write("Year: ");
            yearAsString = Console.ReadLine();

            if (yearAsString == "")
                g.Year = 0;
            else
                g.Year = Convert.ToUInt16(yearAsString);

            if ((g.Year != 0) && (g.Year < 1940 || g.Year > 2100))
                Console.WriteLine("It must be between 1940 and 2100");

        } while ((g.Year != 0) && (g.Year < 1940 || g.Year > 2100));

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

        return g;
    }

    static void Main()
    {
        List<Game> games = new List<Game>();
        string option;
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
                    games.Add( AskForGame() );
                    break;

                case "2":
                    if (games.Count == 0)
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

                            for (int i = 0; i < games.Count; i++)
                            {
                                if (searchTitle == games[i].Title.ToUpper())
                                    games[i].Display();
                                else
                                    notFound = true;
                            }

                        }
                        else if (nOrTitle == "2")
                        {
                            Console.WriteLine("Select a entry, please: ");
                            int entry = Convert.ToInt32(Console.ReadLine()) - 1;
                            games[entry].Display();
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

                    for (int i = 0; i < games.Count; i++)
                    {
                        if ((games[i].Platform == platform) &&
                                (games[i].Category == cat))
                            Console.WriteLine("Entry " + (i + 1));
                            games[i].Display();
                            if (i % 21 == 20) Console.ReadLine();
                    }
                    break;

                case "4":
                    Console.Write("Enter text: ");
                    string newText = Console.ReadLine();

                    for (int i = 0; i < games.Count; i++)
                    {
                        if (games[i].Contains(newText))
                        {
                            Console.WriteLine("Entry " + (i + 1));
                            games[i].Display();
                            if (i % 21 == 20)
                                Console.ReadLine();
                        }
                    }
                    break;

                case "5":
                    Console.Write("Enter data entry: ");
                    int newData = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (newData > games.Count)
                        Console.WriteLine("Number too long");
                    else
                    {
                        games[newData].Title = AskForNewValue("Title",
                            games[newData].Title);
                        games[newData].Category = AskForNewValue("Category",
                            games[newData].Category);
                        games[newData].Platform = AskForNewValue("Platform",
                            games[newData].Platform);

                        Console.WriteLine("Enter year (before {0}: ",
                            games[newData].Year);
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
                                games[newData].Year = newYearINT;
                        }

                        Console.WriteLine("Enter note (before {0}: ",
                            games[newData].Rating);
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
                                games[newData].Rating = newNote;
                        }

                        Console.WriteLine("Enter comment (before {0}: ",
                            games[newData].Comments);
                        string newComment = Console.ReadLine();
                        if (newComment != "")
                            games[newData].Comments = newComment;
                    }
                    break;

                case "6":
                    Console.Write("Select entry to delete: ");
                    int delEntry = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (delEntry >= games.Count)
                        Console.WriteLine("Too long number");
                    else
                    {
                        Console.WriteLine("Do yo want to delete {0}?",
                            games[delEntry].Title);
                        Console.Write("y / n");
                        char delete = Convert.ToChar(Console.ReadLine());

                        if (delete == 'y')
                        {
                            games.RemoveAt(delEntry);
                        }
                        else if (delete == 'n')
                            Console.WriteLine("Operation cancelled");
                        else
                            Console.WriteLine("Not a valid option");

                    }
                    break;

                case "7":
                    games.Sort();
                    break;

                case "8":
                    for (int i = 0; i < games.Count; i++)
                    {
                        // TO DO: changes are not saved
                        games[i].Title.TrimStart();
                        games[i].Title.TrimEnd();
                        games[i].Category.TrimStart();
                        games[i].Category.TrimEnd();
                        games[i].Platform.TrimStart();
                        games[i].Platform.TrimEnd();
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
