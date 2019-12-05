using System;

public class Search2
{
    public static void Main()
    {
        int[] data = { 10, 20, 30, 40, 50, 60, 70, 80 };

        Console.WriteLine("Enter the data to search for: ");
        int num = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        int left = 0, right = data.Length - 1;
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


        if (found)
            Console.WriteLine("Found");
        else
            Console.WriteLine("Not found");
    }
}
