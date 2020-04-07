//kiko
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
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
}

class VideogamesManagementSystemVersion2
{

    public static void Save(List<Game> g)
    {
        IFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream("game.dat",
        FileMode.Create, FileAccess.Write, FileShare.None);
        formatter.Serialize(stream, g);
        stream.Close();
    }
    
    public static List<Game> Load()
    {
        List<Game> g = new List<Game>();
        if (!File.Exists("game.dat"))
        {
            return g;
        }
        else
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream("game.dat",
                FileMode.Open, FileAccess.Read, FileShare.Read);
                g = (List<Game>)formatter.Deserialize(stream);
                stream.Close();
                return g;
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        return null;

    }
    

    static void Main()
    {
        List<Game> videoGame = Load();
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
                    Game g = new Game();
                    Console.WriteLine("Adding new game...");
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
                    videoGame.Add(g);
                    Save(videoGame);

                    break;

                case "2":
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

                        for (int i = 0; i < videoGame.Count; i++)
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

                        Console.WriteLine(videoGame[entry].Title);
                        Console.WriteLine(videoGame[entry].Category);
                        Console.WriteLine(videoGame[entry].Platform);
                        Console.WriteLine(videoGame[entry].Year);
                        Console.WriteLine(videoGame[entry].Rating);
                        Console.WriteLine(videoGame[entry].Comments);

                    }
                    else
                        Console.WriteLine("Select a valid option");

                    if (notFound)
                        Console.Write("That title couldn't be found");

                    break;

                case "3": // Show all
                    Console.Write("Enter platform: ");
                    string platform = Console.ReadLine();
                    Console.Write("Enter category: ");
                    string cat = Console.ReadLine();

                    for (int i = 0; i < videoGame.Count; i++)
                    {
                        if (videoGame[i].Platform == platform)
                        {
                            for (int j = 0; j < videoGame.Count; j++)
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

                    for (int i = 0; i < videoGame.Count; i++)
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
                    Save(videoGame);
                    break;

                case "6":
                    Console.Write("Select entry to delete: ");
                    int delEntry = Convert.ToInt32(Console.ReadLine()) - 1;

                    Console.WriteLine("Do yo want to delete {0}?",
                        videoGame[delEntry].Title);
                    Console.Write("y / n");
                    char delete = Convert.ToChar(Console.ReadLine());

                    if (delete == 'y')
                    {
                        videoGame.RemoveAt(delEntry);
                        Save(videoGame);
                    }
                    else if (delete == 'n')
                        Console.WriteLine("Operation cancelled");
                    else
                        Console.WriteLine("Not a valid option");


                    break;

                case "7":
                    videoGame.Sort();
                    Save(videoGame);
                    break;

                case "8":
                    for (int i = 0; i < videoGame.Count; i++)
                    {
                        videoGame[i].Title = videoGame[i].Title.Trim();
                        videoGame[i].Category = videoGame[i].Category.Trim();   
                        videoGame[i].Platform = videoGame[i].Platform.Trim();
                    }
                    Console.WriteLine("Ortography corrected");
                    Save(videoGame);
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
