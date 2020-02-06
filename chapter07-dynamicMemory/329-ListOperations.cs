// Common operations with lists

using System;
using System.Collections.Generic;

/*
 * 1: Add data from 1 to 7
 * 2: Add 10
 * 3: Delete the second data
 * 4: Delete 5
 * 5: Insert 20 after 3rd data
 * 6: Check if 7 is out there
 * 7: Show data
 * 8: Sort
 * 9: Show again
*/
class ListOperations
{
    static void Main()
    {
        int[] d = { 1, 2, 3, 4, 5, 5, 7 };
        List<int> myData = new List<int>(d);


        // 1: Add data from 1 to 7
        // for (int i = 1; i <= 7; i++) myData.Add(i);

        // 2: Add 10
        myData.Add(10);

        // 3: Delete the second data
        myData.RemoveAt(1);

        // 4: Delete 5
        myData.Remove(5);

        // 5: Insert 20 after 3rd data
        myData.Insert(3, 20);

        // 6: Check if 7 is out there
        //if (myData.IndexOf(7) >= 0) Console.WriteLine("7 is there");
        if (myData.Contains(7)) Console.WriteLine("7 is there");

        // 7: Show data
        for (int i = 0; i < myData.Count; i++)
            Console.Write(myData[i] + " ");
        Console.WriteLine();

        // 8: Sort
        myData.Sort();

        // 9: Show again
        foreach (int n in myData)
            Console.Write(n + " ");
        Console.WriteLine();
    }
}
