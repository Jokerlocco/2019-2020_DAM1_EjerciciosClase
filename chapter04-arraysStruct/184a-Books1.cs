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
            Console.WriteLine("...");
            Console.WriteLine("X- Exit");
            option = Console.ReadLine().ToUpper();

            switch (option)
            {
                case "1":
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
