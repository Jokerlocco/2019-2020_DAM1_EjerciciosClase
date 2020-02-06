// ArrayList -> generic list

using System;
using System.Collections.Generic;

class ArrayList2
{
    static void Main()
    {
        List<int> myData = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter data " + (i + 1) + ": ");
            int data = Convert.ToInt32(Console.ReadLine());

            myData.Add(data);
        }

        for (int i = myData.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(myData[i]);
        }
    }
}
