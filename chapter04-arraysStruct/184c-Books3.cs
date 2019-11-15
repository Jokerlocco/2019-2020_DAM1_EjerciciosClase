// Version history
// 0.03 - Sort by title
// 0.02 - Add; sort by year
// 0.01 - Empty skeleton

using System;

class Books
{
    struct book
    {
        public string author;
        public string title;
        public int year;
    }
    static void Main()
    {
        const int CAPACITY = 25000;
        int amount = 0;
        book[] books = new book[CAPACITY];
        string option;

        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1- Add a new book");
            Console.WriteLine("...");
            Console.WriteLine("X- Exit");
            option = Console.ReadLine().ToUpper();

            switch (option)
            {
                case "1":
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

                    // TO DO ...
                    break;
                
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
}
