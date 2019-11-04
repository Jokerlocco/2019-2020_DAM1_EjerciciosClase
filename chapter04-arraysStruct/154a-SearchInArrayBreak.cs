using System;

class SearchAndBreak
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
        foreach (long d in data)
        {
            if (d == search)
            {
                found = true;
                break;    // !!!!!!!!!!!!!!!!!!
            }
        }

        Console.WriteLine(found);
    }
}
