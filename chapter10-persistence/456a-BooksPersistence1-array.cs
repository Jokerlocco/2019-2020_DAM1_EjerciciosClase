// Gonzalo Arques

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Book
{
    protected string author;
    protected string title;
    protected int year;

    public string GetAuthor() { return author; }
    public string GetTitle() { return title; }
    public int GetYear() { return year; }

    public void SetAuthor(string author) { this.author = author; }
    public void SetTitle(string title) { this.title = title; }
    public void SetYear(int year) { this.year = year; }

    public void Save(string fileName, Book[] books, int amount)
    {
        IFormatter formatter = new BinaryFormatter();
        Stream outputFile = new FileStream(fileName,
            FileMode.Create, FileAccess.Write,
            FileShare.None);
        formatter.Serialize(outputFile, amount);
        formatter.Serialize(outputFile, books);
        outputFile.Close();
    }

    public void Load(string fileName, ref Book[] books, ref int amount)
    {
        IFormatter formatter = new BinaryFormatter();
        Stream inputFile = new FileStream(fileName,
            FileMode.Open, FileAccess.Read,
            FileShare.Read);
        amount = (int)formatter.Deserialize(inputFile);
        books = (Book[])formatter.Deserialize(inputFile);
        inputFile.Close();
    }
}

class Books
{
    static void Main()
    {
        const int CAPACITY = 25000;
        int amount = 0;
        Book book = new Book();
        Book[] books = new Book[CAPACITY];
        if (File.Exists("books.dat"))
        {
            book.Load("books.dat", ref books, ref amount);
        }

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
                    if (amount >= CAPACITY)
                    {
                        Console.WriteLine("Database full");
                    }
                    else
                    {
                        books[amount] = new Book();
                        Console.Write("Enter author: ");
                        books[amount].SetAuthor(Console.ReadLine());
                        Console.Write("Enter title: ");
                        books[amount].SetTitle(Console.ReadLine());
                        Console.Write("Enter year: ");
                        books[amount].SetYear(
                            Convert.ToInt32(Console.ReadLine()));
                        amount++;
                    }

                    for (int i = 0; i < amount - 1; i++)
                    {
                        for (int j = i + 1; j < amount; j++)
                        {
                            if (books[i].GetTitle().ToUpper().
                                CompareTo(books[j].GetTitle().ToUpper()) > 0)
                            {
                                Book aux = books[i];
                                books[i] = books[j];
                                books[j] = aux;
                            }
                        }
                    }

                    book.Save("books.dat", books, amount);

                    break;

                case "2": // Show all
                    if (amount == 0)
                        Console.WriteLine("No data to display");
                    else
                    {
                        for (int i = 0; i < amount; i++)
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
                    if (amount == 0)
                        Console.WriteLine("No data to search in");
                    else
                    {
                        Console.Write("Text to search? ");
                        string search = Console.ReadLine();
                        bool found = false;
                        for (int i = 0; i < amount; i++)
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

                    if (editPosition >= amount)
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

                    book.Save("books.dat", books, amount);

                    break;

                case "6": // Delete
                    int deletePosition;

                    Console.Write("Enter book number to delete: ");
                    deletePosition = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (deletePosition >= amount)
                    {
                        Console.WriteLine("There are not so many books");
                    }
                    else
                    {
                        Console.WriteLine("This is the book you are " +
                            "deleting:");
                        Console.WriteLine(books[deletePosition].GetAuthor());
                        Console.WriteLine(books[deletePosition].GetTitle());
                        Console.Write("Type Y to confirm deletion... ");

                        if (Console.ReadLine().ToUpper() == "Y")
                        {
                            for (int i = deletePosition; i < amount; i++)
                            {
                                books[i] = books[i + 1];
                            }
                            amount--;
                            Console.WriteLine("Deleted");
                        }
                        else
                            Console.WriteLine("Not deleted");
                    }

                    book.Save("books.dat", books, amount);

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