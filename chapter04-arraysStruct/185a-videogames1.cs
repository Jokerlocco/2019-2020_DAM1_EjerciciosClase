using System;

class PCGames
{
    struct game
    {
        public string title;
        public string category;
        public string platform;
        public int year;
        public double clasification;
        public string comments;
    }
    static void Main()
    {
        const int MAX = 10000;
        int amount = 0;
        game[] games = new game[MAX];
        string option;

        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1-Add a game");
            Console.WriteLine("2-Show a game (enter a title or a register)");
            Console.WriteLine("3-Show all game for a platform and a category");
            Console.WriteLine("4-Look for games what contains a text");
            Console.WriteLine("5-Update a game");
            Console.WriteLine("6-Delete a game");
            Console.WriteLine("7-Alphabetic order");
            Console.WriteLine("8-Delete excess spacings ");
            Console.WriteLine("Q-Exit");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    if(amount < MAX)
                    {
                        Console.WriteLine("data " + (amount + 1) + ": ");
                        do
                        {
                            Console.WriteLine("enter the title");
                            games[amount].title = Console.ReadLine();
                            if (games[amount].title == "")
                            {
                                Console.WriteLine("The title is required");
                            }
                        } 
                        while (games[amount].title == "");

                        do
                        {
                            Console.WriteLine("enter the category");
                            games[amount].category = Console.ReadLine();
                            if (games[amount].category == "")
                            {
                                Console.WriteLine("The category is required");
                            }
                        }
                        while (games[amount].category == "");

                        Console.WriteLine("enter the platform");
                        games[amount].platform = Console.ReadLine();

                        Console.WriteLine("enter the year" );
                        games[amount].year = 
                                Convert.ToInt32(Console.ReadLine());
                        if(games[amount].year <= 1940 || 
                                games[amount].year >= 2100)
                        {
                            Console.WriteLine("year not valid");
                        }

                        Console.WriteLine("enter the clasification");
                        games[amount].clasification =
                                Convert.ToDouble(Console.ReadLine());
                        if (games[amount].clasification <= 0 ||
                                games[amount].clasification >= 10)
                        {
                            Console.WriteLine("clasification not valid");
                        }

                        Console.WriteLine("enter the comments");
                        games[amount].comments = Console.ReadLine();

                        Console.WriteLine("game introduced correctly!!");
                        amount++;
                    }
                    else
                    {
                        Console.WriteLine("database full");
                    }
                    break;
                case "2":
                    if (amount == 0)
                    {
                        Console.WriteLine("no data to disable");
                    }
                    else
                    {
                        Console.WriteLine(
                            "how do you look for," + 
                                " number of register or title(num or tit)???");
                        string choose = Console.ReadLine().ToLower();
                        //TODO --> SE PODRIA PONER TODO JUNTO ASI ?
                        // if(choose == "tit" || choose == "num") y luego 
                        if (choose == "tit")
                        {
                            Console.WriteLine("insert title to look for");
                            //string answer
                            string titleRead = Console.ReadLine();
                            for (int i = 0; i < amount; i++)
                            {
                                // if (games[i].title.ToLower() == answer 
                                //|| i == Convert.ToInt32(answer))
                                // (int) answer es incorrecto¿?
                                if (games[i].title.ToLower() == titleRead) 
                                {
                                    Console.WriteLine("   " + i + ": ");
                                    Console.WriteLine("title: " +
                                        games[i].title);
                                    Console.WriteLine("category: " + 
                                        games[i].category);
                                    Console.WriteLine("platform: " +
                                        games[i].platform);
                                    Console.WriteLine("year: " +
                                        games[i].year);
                                    Console.WriteLine("clasification: " +
                                        games[i].clasification);
                                    Console.WriteLine("comments: " +
                                        games[i].comments);
                                }
                            }
                        }
                        else if (choose == "num")
                        {
                            Console.WriteLine("insert the number of register");
                            int register = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < amount; i++)
                            {
                                if (i == register) 
                                {
                                    Console.WriteLine("   " + i + ": ");
                                    Console.WriteLine("title: " +
                                        games[i].title);
                                    Console.WriteLine("category: " +
                                        games[i].category);
                                    Console.WriteLine("platform: " +
                                        games[i].platform);
                                    Console.WriteLine("year: " +
                                        games[i].year);
                                    Console.WriteLine("clasification: " +
                                        games[i].clasification);
                                    Console.WriteLine("comments: " +
                                        games[i].comments);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(
                                    "you choose an incorrect option");
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("enter the platform");
                    string platform = Console.ReadLine().ToUpper();
                    Console.WriteLine("enter the category");
                    string category = Console.ReadLine().ToUpper();

                    for (int i = 0; i < amount; i++)
                    {
                        if(games[i].category.ToUpper() == category && 
                                games[i].platform.ToUpper() == platform)
                        {
                            Console.WriteLine("   " + i + ": ");
                            Console.WriteLine("title: " +
                                games[i].title);                           
                            Console.WriteLine("year: " +
                                games[i].year);
                            Console.WriteLine("clasification: " +
                                games[i].clasification);
                        }
                        if(i % 22 == 21)
                        {
                            Console.ReadLine();
                        }
                    }
                    break;
                case "4":
                    Console.WriteLine("enter the text to look for");
                    string text = Console.ReadLine().ToLower();
                    for (int i = 0; i < amount; i++)
                    {
                        if ((games[i].title.ToLower().Contains(text)) ||
                            (games[i].category.ToLower().Contains(text)) ||
                            (games[i].platform.ToLower().Contains(text)) ||
                            (games[i].comments.ToLower().Contains(text))
                            )
                        {
                            Console.WriteLine("   " + i + ": ");
                            Console.WriteLine("title: " +
                                games[i].title);
                            Console.WriteLine("year: " +
                                games[i].year);
                            Console.WriteLine("clasification: " +
                                games[i].clasification);
                        }
                        if (i % 22 == 21)
                        {
                            Console.ReadLine();
                        }
                    }
                    break;
                case "5":
                    Console.WriteLine(
                            "Enter the number the register to update");
                    int numUpdate = Convert.ToInt32(Console.ReadLine());
                    if(numUpdate < amount)
                    {
                        Console.WriteLine("enter the title (actual is {0}",
                            games[numUpdate].title);
                        Console.WriteLine("press enter to not modify");
                        string newTitle = Console.ReadLine();
                        if (newTitle != "")
                        {
                            games[numUpdate].title = newTitle;
                        }

                        Console.WriteLine("enter the category (actual is {0}",
                            games[numUpdate].category);
                        Console.WriteLine("press enter to not modify");
                        string newCategory = Console.ReadLine();
                        if (newCategory != "")
                        {
                            games[numUpdate].category = newCategory;
                        }

                        Console.WriteLine("enter the platform (actual is {0}",
                            games[numUpdate].platform);
                        Console.WriteLine("press enter to not modify");
                        string newPlatform = Console.ReadLine();
                        if (newPlatform != "")
                        {
                            games[numUpdate].platform = newPlatform;
                        }

                        Console.WriteLine("enter the year (actual is {0}",
                            games[numUpdate].year);
                        Console.WriteLine("press enter to not modify");
                        string newYear = Console.ReadLine();
                        if (newYear != "")
                        {
                            if(Convert.ToInt32(newYear) < 1940 ||
                                Convert.ToInt32(newYear) > 2100)
                            {
                                Console.WriteLine("year not valid");
                            }
                            else
                            {
                                games[numUpdate].year =
                                        Convert.ToInt32(newYear);
                            }
                        }

                        Console.WriteLine("enter the year (actual is {0}",
                            games[numUpdate].clasification);
                        Console.WriteLine("press enter to not modify");
                        string newClasification = Console.ReadLine();
                        if (newClasification != "")
                        {
                            if (Convert.ToInt32(newClasification) < 0 ||
                                Convert.ToInt32(newClasification) > 10)
                            {
                                Console.WriteLine("clasification not valid");
                            }
                            else
                            {
                                games[numUpdate].clasification =
                                        Convert.ToInt32(newClasification);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("number incorrect");
                    }
                    break;
                case "6":
                    Console.WriteLine("enter the number of game");
                    int positionDelete = 
                            Convert.ToInt32(Console.ReadLine()) - 1;
                    if(positionDelete >= amount)
                    {
                        Console.WriteLine("number of book incorrect");
                    }
                    else
                    {
                        Console.WriteLine("   " + positionDelete + ": ");
                        Console.WriteLine("title: " +
                            games[positionDelete].title);
                        Console.WriteLine("category: " +
                            games[positionDelete].category);
                        Console.WriteLine("platform: " +
                            games[positionDelete].platform);
                        Console.WriteLine("year: " +
                            games[positionDelete].year);
                        Console.WriteLine("clasification: " +
                            games[positionDelete].clasification);
                        Console.WriteLine("comments: " +
                            games[positionDelete].comments);
                        Console.WriteLine(
                            "are you sure to delete this? (YES or NO)");
                        string confirmation = Console.ReadLine();
                        if(confirmation.ToUpper() == "YES")
                        {
                            for (int i = positionDelete; i < amount; i++)
                            {
                                games[i] = games[i + 1];
                            }
                            Console.WriteLine("book deleted");
                            amount--;
                        }
                        else
                        {
                            Console.WriteLine("book not deleted");
                        }
                    }
                    break;
                case "7":
                    for (int i = 0; i < amount-1; i++)
                    {
                        for (int j = i + 1; j < amount; j++)
                        {
                            if(games[i].title.ToLower().
                                CompareTo(games[j].title.ToLower()) > 0)
                            {
                                game aux = games[i];
                                games[i] = games[j];
                                games[j] = aux;
                            }
                        }
                    }
                    // TODO -->COMO SE HACE LA SEGUNDA ORDENACION
                    break;
                case "8":
                    for (int i = 0; i < amount; i++)
                    {
                        games[i].title = games[i].title.Trim();
                        games[i].category = games[i].category.Trim();
                        games[i].platform = games[i].platform.Trim();
                        while(games[i].title.Contains("  "))
                        {
                            games[i].title.Replace("  ", " ");
                        }
                        while (games[i].category.Contains("  "))
                        {
                            games[i].category.Replace("  ", " ");
                        }
                        while (games[i].platform.Contains("  "))
                        {
                            games[i].platform.Replace("  ", " ");
                        }
                    }
                    break;
                case "Q":
                    Console.WriteLine("bye");
                    break;
                default:
                    Console.WriteLine("incorrect option");
                    break;
            }
        }
        while (option.ToUpper() != "Q");
    }
}
