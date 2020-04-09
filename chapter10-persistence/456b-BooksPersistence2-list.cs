//Lautaro Álvaro Fernández

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Book : IComparable<Book>
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
    
	public int CompareTo(Book b)
    {
        return this.title.ToUpper().CompareTo(b.title.ToUpper());
    }
    
}

class Books
{
	public static void Save(List<Book> g)
    {
        IFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream("books.dat",
        FileMode.Create, FileAccess.Write, FileShare.None);
        formatter.Serialize(stream, g);
        stream.Close();
    }
    
    public static List<Book> Load()
    {
        List<Book> g = new List<Book>();
        if (!File.Exists("books.dat"))
        {
            return g;
        }
        else
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream("books.dat",
                FileMode.Open, FileAccess.Read, FileShare.Read);
                g = (List<Book>)formatter.Deserialize(stream);
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
        List<Book> books = Load();
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
					Book newBook = new Book();
					Console.Write("Enter author: ");
					newBook.SetAuthor( Console.ReadLine() );
					Console.Write("Enter title: ");
					newBook.SetTitle( Console.ReadLine() );
					Console.Write("Enter year: ");
					newBook.SetYear(
						Convert.ToInt32(Console.ReadLine()));
					
					books.Add(newBook);
					books.Sort();
					Save(books);
                    
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
                    Save(books);
                    
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
                    Save(books);
                    
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
