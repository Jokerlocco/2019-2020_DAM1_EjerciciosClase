// Contact with ArrayList

using System;
using System.Collections;

class ArrayList1
{
    static void Main()
    {
        ArrayList myData = new ArrayList();
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter data " + (i + 1) + ": ");
            int data = Convert.ToInt32(Console.ReadLine());

            myData.Add(data);
        }

        for (int i = myData.Count-1; i >= 0; i--)
        {
            Console.WriteLine(myData[i]);
        }
    }
}
