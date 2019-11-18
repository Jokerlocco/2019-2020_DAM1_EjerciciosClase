// TO DO
// ¿Descripcion?
// ¿ 2 - Numero?
// Sumar +1 a los numero de registro
// MEJORA PLS

using System;

class computerGames
{
    struct games
    {
        public string title;
        public string category;
        public string platform;
        public int year;
        public double rating;
        public string comments;
    }
    static void Main()
    {
        const int MAX = 10000;
        char option;
        games[] game = new games[MAX];
        int amount = 0;

        do
        {
            Console.WriteLine("1 - Add a new game");
            Console.WriteLine("2 - Show all the data of a certain game");
            Console.WriteLine
                ("3 - Show all games of a certain platform and category");
            Console.WriteLine("4 - Find games containing a certain text");
            Console.WriteLine("5 - Update a record");
            Console.WriteLine("6 - Delete a record");
            Console.WriteLine("7 - Sort data alphabetically");
            Console.WriteLine("8 - Eliminate redundant spaces");
            Console.WriteLine("Q - Quit the application");
            option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case '1': // Add a new game
                    if (amount > MAX)
                        Console.WriteLine("Database is full");
                    else
                    {
                        game[amount].title = ""; // MEJORA PLS
                        while (game[amount].title == "")
                        {
                            Console.Write("Title: ");
                            game[amount].title = Console.ReadLine();
                        }
                        Console.Write("Category: "); // TO DO ¿Descripcion?
                        game[amount].category = Console.ReadLine();
                        Console.Write("Platform: ");
                        game[amount].platform = Console.ReadLine();

                        while (game[amount].year < 1940
                            || game[amount].year > 2100)
                        {
                            Console.Write("Year: ");
                            game[amount].year =
                                Convert.ToInt32(Console.ReadLine());
                        }
                        game[amount].rating = 11; // MEJORA PLS
                        while (game[amount].rating < 0
                            || game[amount].rating > 10)
                        {
                            Console.Write("Rating: ");
                            game[amount].rating =
                                    Convert.ToDouble(Console.ReadLine());
                        }
                        Console.Write("Comments: ");
                        game[amount].comments = Console.ReadLine();
                        amount++;
                    }
                    break;

                case '2': // Show all the data of a certain game
                    char election;
                    int searchNumber;
                    string searchTitle;
                    bool found = false;
                    Console.Write
                        ("Search by number or exact title (n / t)? ");
                    election = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (election == 'N') // TO DO ¿Numero? 
                    {
                        Console.Write("Number: ");
                        searchNumber = Convert.ToInt32(Console.ReadLine()) + 1;
                        if (searchNumber < 0 || searchNumber > amount)
                        {
                            Console.WriteLine("No games at that number");
                        }

                        else
                        {
                            Console.Write(game[searchNumber].title + " - ");
                            Console.Write(game[searchNumber].category + " - ");
                            Console.Write(game[searchNumber].platform + " - ");
                            Console.Write(game[searchNumber].year + " - ");
                            Console.Write(game[searchNumber].rating + " - ");
                            Console.WriteLine(game[searchNumber].comments);
                        }
                    }
                    if (election == 'T')
                    {
                        Console.Write("Title: ");
                        searchTitle = Console.ReadLine().ToUpper();
                        for (int i = 0; i < amount; i++)
                        {
                            if (game[i].title == searchTitle)
                            {
                                Console.Write(game[i].title + " - ");
                                Console.Write(game[i].category + " - ");
                                Console.Write(game[i].platform + " - ");
                                Console.Write(game[i].year + " - ");
                                Console.Write(game[i].rating + " - ");
                                Console.WriteLine(game[i].comments);
                                found = true;
                            }
                        }
                        if (!found)
                            Console.Write("No games with that title");
                    }
                    else
                        Console.WriteLine("Wrong option");
                    break;

                case '3': // Show all games of a certain platform and category
                    string searchCategory;
                    string searchPlatform;
                    int countPlatCat = 0;
                    Console.Write("Category: ");
                    searchCategory = Console.ReadLine();
                    Console.Write("Platform: ");
                    searchPlatform = Console.ReadLine();

                    for (int i = 0; i < amount; i++)
                    {
                        if (game[i].category == searchCategory
                                && game[i].platform == searchPlatform)
                        {
                            Console.Write(i + " - ");
                            Console.Write(game[i].title + " - ");
                            Console.Write(game[i].year + " - ");
                            Console.WriteLine(game[i].rating);
                            countPlatCat++;

                            if (countPlatCat % 22 == 21)
                            {
                                Console.WriteLine
                                    ("Press ENTER to continue...");
                                Console.ReadLine();
                            }
                        }
                    }
                    break;

                case '4': // Find games containing a certain text
                    string searchText;
                    int countText = 0;
                    Console.Write("Text to search: ");
                    searchText = Console.ReadLine().ToUpper();

                    for (int i = 0; i < amount; i++)
                    {
                        if (game[i].title.ToUpper().Contains(searchText)
                            || game[i].category.ToUpper().Contains(searchText)
                            || game[i].platform.ToUpper().Contains(searchText)
                            || game[i].comments.ToUpper().Contains(searchText))
                        {
                            Console.Write(i + " - ");
                            Console.Write(game[i].title + " - ");
                            Console.Write(game[i].year + " - ");
                            Console.WriteLine(game[i].rating);
                            countText++;
                        }

                        if (countText % 22 == 21)
                        {
                            Console.WriteLine("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                    }
                    break;

                case '5': // Update a record
                    string newData;
                    Console.Write("Number of record: ");
                    searchNumber = Convert.ToInt32(Console.ReadLine());
                    if (searchNumber < 0 || searchNumber > amount)
                        Console.WriteLine("No record at that number");
                    else
                    {
                        Console.WriteLine("Old title: "
                            + game[searchNumber].title);
                        Console.Write("New title: ");
                        newData = Console.ReadLine();
                        if (newData != "")
                            game[searchNumber].title = newData;

                        Console.WriteLine("Old category: "
                            + game[searchNumber].category);
                        Console.Write("New category: ");
                        newData = Console.ReadLine();
                        if (newData != "")
                            game[searchNumber].category = newData;

                        Console.WriteLine("Old platform: "
                            + game[searchNumber].platform);
                        Console.Write("New platform: ");
                        newData = Console.ReadLine();
                        if (newData != "")
                            game[searchNumber].platform = newData;

                        while (game[searchNumber].year < 1940
                            || game[searchNumber].year > 2100)
                        {
                            Console.WriteLine("Old year: "
                                + game[searchNumber].year);
                            Console.Write("New year: ");
                            newData = Console.ReadLine();
                            if (newData != "")
                                game[searchNumber].year =
                                    Convert.ToInt32(newData);
                        }

                        while (game[searchNumber].rating < 0
                            || game[searchNumber].rating > 10)
                        {
                            Console.WriteLine("Old rating: "
                                + game[searchNumber].rating);
                            Console.Write("New rating: ");
                            newData = Console.ReadLine();
                            if (newData != "")
                                game[searchNumber].rating =
                                    Convert.ToDouble(newData);
                        }

                        Console.WriteLine("Old comments: "
                            + game[searchNumber].comments);
                        Console.Write("New comments: ");
                        newData = Console.ReadLine();
                        if (newData != "")
                            game[searchNumber].comments = newData;
                    }
                    break;

                case '6': // Delete a record
                    int posToDelete;
                    char confirmation;
                    Console.WriteLine("Position to delete: ");
                    posToDelete = Convert.ToInt32(Console.ReadLine());
                    if (posToDelete < 0 || posToDelete >= amount)
                        Console.WriteLine("No records at the position");
                    else
                    {
                        Console.WriteLine
                            ("This is the game you are deleting:");
                        Console.Write(game[posToDelete].title + " - ");
                        Console.Write(game[posToDelete].category + " - ");
                        Console.Write(game[posToDelete].platform + " - ");
                        Console.Write(game[posToDelete].year + " - ");
                        Console.Write(game[posToDelete].rating + " - ");
                        Console.WriteLine(game[posToDelete].comments);
                        Console.Write("Type Y to confirm deletion... ");
                        confirmation =
                            Convert.ToChar(Console.ReadLine().ToUpper());

                        if (confirmation == 'Y')
                        {
                            for (int i = posToDelete; i < amount; i++)
                            {
                                game[i] = game[i + 1];
                            }
                            amount--;
                            Console.WriteLine("Deleted");
                        }
                        else
                            Console.WriteLine("Not deleted");
                    }
                    amount--;
                    break;

                case '7': // Sort data alphabetically // TO DO
                    break;

                case '8': // Eliminate redundant spaces
                    for (int i = 0; i < amount; i++)
                    {
                        game[i].category = game[i].category.Trim();
                        game[i].platform = game[i].platform.Trim();
                        game[i].category =
                            game[i].category.Replace("  ", " ");
                        game[i].platform =
                            game[i].platform.Replace("  ", " ");
                    }
                    break;

                case 'Q': // Quit the application
                    Console.WriteLine("Bye!");
                    break;
            }
        }
        while (option != 'Q');


    }
}
