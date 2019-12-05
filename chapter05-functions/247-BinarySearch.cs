using System;

public class Search2
{
    public static void Main()
    {
        int[] data = { 10, 20, 30, 40, 50, 60, 70, 80 };

        // Test for iterative version
        if (BinSearch(data, 30, 0, data.Length - 1))
            Console.WriteLine("30 found");
        else
            Console.WriteLine("30 not found");

        if (BinSearch(data, 35, 0, data.Length - 1))
            Console.WriteLine("35 found");
        else
            Console.WriteLine("35 not found");

        // Test for recursive version
        if (BinSearchR(data, 30, 0, data.Length - 1))
            Console.WriteLine("30 found");
        else
            Console.WriteLine("30 not found");

        if (BinSearchR(data, 35, 0, data.Length - 1))
            Console.WriteLine("35 found");
        else
            Console.WriteLine("35 not found");
    }

    static bool BinSearch(int[] data, int num, int left, int right)
    {
        bool found = false;
        while (left <= right && !found)
        {
            int middle = left + (right - left) / 2;
            if (data[middle] == num)
                found = true;
            else if (data[middle] < num)
                left = middle + 1;
            else
                right = middle - 1;
        }
        return found;
    }

    static bool BinSearchR(int[] data, int num, int left, int right)
    {
        if (left > right)
            return false;
        int middle = left + (right - left) / 2;
        if (data[middle] == num)
            return true;
        else if (data[middle] < num)
            return BinSearchR(data, num, middle + 1, right);
        else
            return BinSearchR(data, num, left, middle - 1);
    }
}
