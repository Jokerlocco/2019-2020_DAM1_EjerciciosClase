using System;

class SearchInArray2  // Incorrect version 2
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

        bool found = false;
        for (int i = 0; i < MAX; i++)
        {
            if (data[i] == search)
                found = true;
            else
                found = false; // Error
        }
        Console.WriteLine(found);
    }
}
