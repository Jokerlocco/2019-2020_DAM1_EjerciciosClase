using System;

class SearchInArray1 // Incorrect version 1
{
    static void Main()
    {
        const int MAX = 10;
        long[] data = new long[MAX];
        long search;

        for (int i = 0; i < MAX; i++)
        {
            Console.Write("Enter data " + (i + 1) + ": ");
            data[i] = Convert.ToInt64(Console.ReadLine());
        }

        Console.Write("Enter data to search: ");
        search = Convert.ToInt64(Console.ReadLine());

        for (int i = 0; i < MAX; i++)
        {
            if (data[i] == search)
                Console.WriteLine("Ok");
            else
                Console.WriteLine("No");  // Error
        }
    }
}
