using System;

class SearchInterrupted
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

        bool found = false;
        int pos = 0;
        while ( pos < MAX && ! found )  // <---
        {
            if (data[pos] == search)
                found = true;
            pos++;
        }
        Console.WriteLine(found);
    }
}
