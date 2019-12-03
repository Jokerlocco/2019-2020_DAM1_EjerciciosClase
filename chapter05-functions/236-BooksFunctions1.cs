// Version history
// 0.08 - Functions
// 0.07 - Delete
// 0.06 - Edit
// 0.05 - Search
// 0.04 - Display all; bugfix: count when adding
// 0.03 - Sort by title
// 0.02 - Add; sort by year
// 0.01 - Empty skeleton

using System;

class BooksAndFunctions
{
    struct book
    {
        public string author;
        public string title;
        public int year;
    }

    const int CAPACITY = 25000;
    static int amount = 0;
    static book[] books = new book[CAPACITY];

    static void Main()
    {
        string option;

        do
        {
            ShowMenu();
            option = Console.ReadLine().ToUpper();

            switch (option)
            {
                case "1": Add(); break;
                case "2": ShowAll(); break;
                case "3": Search(); break;
                case "4": // Search 2
                    Console.WriteLine("Soon...");
                    break;
                case "5": Edit(); break;
                case "6": Delete(); break;
                // TO DO ...
                case "X":
                    Console.WriteLine("Bye!!");
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
        }
        while (option != "X");
    }

    static void ShowMenu()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1- Add a new book");
        Console.WriteLine("2- Display all");
        Console.WriteLine("3- Search");
        Console.WriteLine("5- Edit");
        Console.WriteLine("6- Delete");
        Console.WriteLine("...");
        Console.WriteLine("X- Exit");
    }

    static void Add()
    {
        if (amount >= CAPACITY)
        {
            Console.WriteLine("Database full");
        }
        else
        {
            Console.Write("Enter author: ");
            books[amount].author = Console.ReadLine();
            Console.Write("Enter title: ");
            books[amount].title = Console.ReadLine();
            Console.Write("Enter year: ");
            books[amount].year =
                Convert.ToInt32(Console.ReadLine());
            amount++;
        }

        for (int i = 0; i < amount - 1; i++)
        {
            for (int j = i + 1; j < amount; j++)
            {
                if (books[i].title.ToUpper().
                    CompareTo(books[j].title.ToUpper()) > 0)
                {
                    book aux = books[i];
                    books[i] = books[j];
                    books[j] = aux;
                }
            }
        }

    }

    static void ShowAll()
    {
        if (amount == 0)
            Console.WriteLine("No data to display");
        else
        {
            for (int i = 0; i < amount; i++)
            {
                ShowOneBook(i);
                if (i % 21 == 20)
                    Console.ReadLine(); // Pause after 21 rows
            }
        }
    }

    static void Search()
    {
        if (amount == 0)
            Console.WriteLine("No data to search in");
        else
        {
            string search = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < amount; i++)
            {
                if (books[i].author.ToLower().Contains(
                    search.ToLower()))
                {
                    ShowOneBook(i);
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine("Not found");
        }
    }

    static void ShowOneBook(int i)
    {
        Console.WriteLine((i + 1) + ": "
            + books[i].author + " - "
            + books[i].title + " - "
            + books[i].year);
    }

    static void Edit()
    {
        Console.Write("Enter book number to edit: ");
        int position = Convert.ToInt32(Console.ReadLine()) - 1;

        if (position >= amount)
        {
            Console.WriteLine("There are not so many books");
        }
        else
        {
            Console.Write("Enter author (it was {0}): ",
                books[position].author);
            string newText = Console.ReadLine();
            if (newText != "")
            {
                books[position].author = newText;
                if (newText == newText.ToUpper())
                    Console.WriteLine("Beware: all uppercase");
            }

            Console.Write("Enter title (it was {0}): ",
                books[position].title);
            newText = Console.ReadLine();
            if (newText != "")
                books[position].title = newText;

            Console.Write("Enter year (it was {0}): ",
                books[position].year);
            newText = Console.ReadLine();
            if (newText != "")
                books[position].year =
                    Convert.ToInt32(newText);
        }
    }

    static void Delete()
    {
        int position;

        Console.Write("Enter book number to delete: ");
        position = Convert.ToInt32(Console.ReadLine()) - 1;

        if (position >= amount)
        {
            Console.WriteLine("There are not so many books");
        }
        else
        {
            Console.WriteLine("This is the book you are deleting:");
            Console.WriteLine(books[position].author);
            Console.WriteLine(books[position].title);
            Console.Write("Type Y to confirm deletion... ");

            if (Console.ReadLine().ToUpper() == "Y")
            {
                for (int i = position; i < amount; i++)
                {
                    books[i] = books[i + 1];
                }
                amount--;
                Console.WriteLine("Deleted");
            }
            else
                Console.WriteLine("Not deleted");
        }
    }
}
