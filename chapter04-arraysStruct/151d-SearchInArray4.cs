using System;

class SearchInArray4 // Search using a count
{
    static void Main(string[] args)
    {
        const int MAX = 5;
        long[] data = new long[MAX];
        long search;

        for (int i = 0; i < MAX; i++)
        {
            Console.Write("Enter data " + (i + 1) + ": ");
            data[i] = Convert.ToInt64(Console.ReadLine());
        }

        Console.Write("Enter data to search: ");
        search = Convert.ToInt64(Console.ReadLine());

        int amount = 0;
        for (int i = 0; i < MAX; i++)
        {
            if (data[i] == search)
                amount ++;
        }
        Console.WriteLine( amount > 0);
    }
}
