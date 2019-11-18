//Abraham García - Videogames

using System;

class structVideogames
{
    struct game
    {
        public string title;
        public string cat;
        public string platform;
        public ushort year;
        public double note;
        public string comments;
    }
    
    static void Main()
    {
        const int MAX = 10000;
        
        game[] videoGame = new game[MAX];
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
                        Console.WriteLine("Adding new game...");
                        do
                        {
                            Console.Write("Title: ");
                            videoGame[amount].title = Console.ReadLine();
                            
                            if (videoGame[amount].title == "")
                                Console.WriteLine("Title can't be empty!");
                            
                            Console.Write("Category: ");
                            videoGame[amount].cat = Console.ReadLine();
                            
                            if (videoGame[amount].cat == "")
                                Console.WriteLine("Title can't be empty!");
                            
                        } while (videoGame[amount].title == "" ||
                            videoGame[amount].cat == "");
                        
                        do
                        {
                            Console.Write("Year: ");
                            videoGame[amount].year = Convert.ToUInt16
                                (Console.ReadLine());
                                
                            if (videoGame[amount].year < 1940 || 
                            videoGame[amount].year > 2100)
                                Console.WriteLine
                                    ("It must be between 1940 and 2100");
                        
                        } while (videoGame[amount].year < 1940 || 
                            videoGame[amount].year > 2100);
                            
                        do
                        {
                            Console.Write("Note: ");
                            videoGame[amount].note = Convert.ToDouble
                                (Console.ReadLine());
                                
                            if (videoGame[amount].note < 0 ||
                            videoGame[amount].note > 10)
                                Console.WriteLine("Please, between 0 and 10");
                            
                        } while (videoGame[amount].note < 0 ||
                            videoGame[amount].note > 10);
                            
                        Console.Write("Platform: ");
                            videoGame[amount].platform = Console.ReadLine();
                        Console.Write("Comments: ");
                            videoGame[amount].comments = Console.ReadLine();
                        
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
                                if (searchTitle == videoGame[i].title.
                                    ToUpper())
                                {
                                    Console.WriteLine(videoGame[i].title);
                                    Console.WriteLine(videoGame[i].cat);
                                    Console.WriteLine(videoGame[i].platform);
                                    Console.WriteLine(videoGame[i].year);
                                    Console.WriteLine(videoGame[i].note);
                                    Console.WriteLine(videoGame[i].comments);
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
                                    Console.WriteLine(videoGame[entry].title);
                                    Console.WriteLine(videoGame[entry].cat);
                                    Console.WriteLine(videoGame[entry].platform);
                                    Console.WriteLine(videoGame[entry].year);
                                    Console.WriteLine(videoGame[entry].note);
                                    Console.WriteLine(videoGame[entry].comments);
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
                        if (videoGame[i].platform == platform)
                        {
                            for (int j = 0; j < amount; j++)
                            {
                                if (videoGame[j].cat == cat)
                                {
                                    Console.WriteLine
                                        ("Entry " + (j+1));
                                    Console.WriteLine
                                        (videoGame[j].title);
                                    Console.WriteLine
                                        (videoGame[j].year);
                                    Console.WriteLine
                                        (videoGame[j].note);
                                    if (j %21 == 20)
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
                        if (videoGame[i].title.ToUpper().Contains
                            (newText.ToUpper()) ||
                            videoGame[i].cat.ToUpper().Contains
                            (newText.ToUpper()) ||
                            videoGame[i].platform.ToUpper().Contains
                            (newText.ToUpper()) ||
                            videoGame[i].comments.ToUpper().Contains
                            (newText.ToUpper()))
                        {
                            Console.WriteLine
                                ("Entry " + (i+1));
                            Console.WriteLine
                                (videoGame[i].title);
                            Console.WriteLine
                                (videoGame[i].year);
                            Console.WriteLine
                                (videoGame[i].note);
                            if (i %21 == 20)
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
                            videoGame[newData].title);
                        string newTitle = Console.ReadLine();
                        if (newTitle != "")
                            videoGame[newData].title = newTitle;
                            
                        Console.WriteLine("Enter category (before {0}: ",
                            videoGame[newData].cat);
                        string newCat = Console.ReadLine();
                        if (newCat != "")
                            videoGame[newData].cat = newCat;
                            
                        Console.WriteLine("Enter platform (before {0}: ",
                            videoGame[newData].platform);
                        string newPlatform = Console.ReadLine();
                        if (newPlatform != "")
                            videoGame[newData].platform = newPlatform;
                            
                        Console.WriteLine("Enter year (before {0}: ",
                            videoGame[newData].year);
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
                                videoGame[newData].year = newYearINT;
                        }
                        
                        Console.WriteLine("Enter note (before {0}: ",
                            videoGame[newData].note);
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
                                videoGame[newData].note = newNoteDOUBLE;
                        }
                        
                        Console.WriteLine("Enter comment (before {0}: ",
                            videoGame[newData].comments);
                        string newComment = Console.ReadLine();
                        if (newComment != "")
                            videoGame[newData].comments = newComment;
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
                            videoGame[delEntry].title);
                        Console.Write("y / n");
                        char delete = Convert.ToChar(Console.ReadLine());
                        
                        if (delete == 'y')
                        {
                            for (int i = delEntry; i < amount; i++)
                                videoGame[i]= videoGame[i+1];
                                
                            amount--;
                        }
                        else if (delete == 'n')
                            Console.WriteLine("Operation cancelled");
                        else
                            Console.WriteLine("Not a valid option");
                            
                    }
                    break;
                    
                case "7":
                    for (int i = 0; i < amount-1; i++)
                    {
                        for (int j = i+1; j < amount; j++)
                        {
                            if (videoGame[i].title.CompareTo(
                                videoGame[j].title) > 0)
                            {
                                game aux = videoGame[i];
                                videoGame[i] = videoGame[j];
                                videoGame[j] = aux;
                            }
                        }
                    }
                    break;
                    
                case "8":
                    for (int i = 0; i < amount; i++)
                        {
                            videoGame[i].title.TrimStart();
                            videoGame[i].title.TrimEnd();
                            videoGame[i].cat.TrimStart();
                            videoGame[i].cat.TrimEnd();
                            videoGame[i].platform.TrimStart();
                            videoGame[i].platform.TrimEnd();
                            
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
