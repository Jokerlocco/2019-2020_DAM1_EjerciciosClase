using System;
using System.Collections.Generic;

class Book : IComparable<Book>
{
    protected string author;
    protected string title;
    protected int year;

    public int CompareTo(Book other)
    {
        return title.CompareTo(other.title);
    }

    public string GetAuthor() { return author; }
    public string GetTitle() { return title; }
    public int GetYear() { return year; }

    public void SetAuthor(string author) { this.author = author; }
    public void SetTitle(string title) { this.title = title; }
    public void SetYear(int year) { this.year = year; }
}

class Books
{

    static void Main()
    {
        List<Book>books = new List<Book>();
        string option;

        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1- Add a new book");
            Console.WriteLine("2- Display all");
            Console.WriteLine("3- Search");
            Console.WriteLine("5- Edit");
            Console.WriteLine("6- Delete");
            Console.WriteLine("...");
            Console.WriteLine("X- Exit");
            option = Console.ReadLine().ToUpper();

            switch (option)
            {
                case "1": // Add
                    Book b  = new Book();
                    Console.Write("Enter author: ");
                    b.SetAuthor(Console.ReadLine());
                    Console.Write("Enter title: ");
                    b.SetTitle(Console.ReadLine());
                    Console.Write("Enter year: ");
                    b.SetYear(
                        Convert.ToInt32(Console.ReadLine()));
                    books.Add(b);

                    books.Sort();
                    break;

                case "2": // Show all
                    if (books.Count == 0)
                        Console.WriteLine("No data to display");
                    else
                    {
                        for (int i = 0; i < books.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ": "
                                + books[i].GetAuthor() + " - "
                                + books[i].GetTitle() + " - "
                                + books[i].GetYear());
                            if (i % 21 == 20)
                                Console.ReadLine(); // Pause after 21 rows
                        }
                    }
                    break;

                case "3": // Search
                    if (books.Count == 0)
                        Console.WriteLine("No data to search in");
                    else
                    {
                        Console.Write("Text to search? ");
                        string search = Console.ReadLine();
                        bool found = false;
                        for (int i = 0; i < books.Count; i++)
                        {
                            if (books[i].GetAuthor().ToLower().Contains(
                                search.ToLower()))
                            {
                                Console.WriteLine((i + 1) + ": "
                                    + books[i].GetAuthor() + " - "
                                    + books[i].GetTitle() + " - "
                                    + books[i].GetYear());
                                found = true;
                            }
                        }
                        if (!found)
                            Console.WriteLine("Not found");
                    }
                    break;

                case "4": // Search 2
                    Console.WriteLine("Soon...");
                    break;

                case "5": // Edit
                    Console.Write("Enter book number to edit: ");
                    int editPosition = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (editPosition >= books.Count)
                    {
                        Console.WriteLine("There are not so many books");
                    }
                    else
                    {
                        Console.Write("Enter author (it was {0}): ",
                            books[editPosition].GetAuthor());
                        string newText = Console.ReadLine();
                        if (newText != "")
                        {
                            books[editPosition].SetAuthor(newText);
                            if (newText == newText.ToUpper())
                                Console.WriteLine("Beware: all uppercase");
                        }

                        Console.Write("Enter title (it was {0}): ",
                            books[editPosition].GetTitle());
                        newText = Console.ReadLine();
                        if (newText != "")
                            books[editPosition].SetTitle(newText);

                        Console.Write("Enter year (it was {0}): ",
                            books[editPosition].GetYear());
                        newText = Console.ReadLine();
                        if (newText != "")
                            books[editPosition].SetYear(
                                Convert.ToInt32(newText));
                    }
                    break;

                case "6": // Delete
                    int deletePosition;

                    Console.Write("Enter book number to delete: ");
                    deletePosition = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (deletePosition >= books.Count)
                    {
                        Console.WriteLine("There are not so many books");
                    }
                    else
                    {
                        Console.WriteLine("This is the book you are deleting:");
                        Console.WriteLine(books[deletePosition].GetAuthor());
                        Console.WriteLine(books[deletePosition].GetTitle());
                        Console.Write("Type Y to confirm deletion... ");

                        if (Console.ReadLine().ToUpper() == "Y")
                        {
                            books.RemoveAt(deletePosition);
                            Console.WriteLine("Deleted");
                        }
                        else
                            Console.WriteLine("Not deleted");
                    }
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
