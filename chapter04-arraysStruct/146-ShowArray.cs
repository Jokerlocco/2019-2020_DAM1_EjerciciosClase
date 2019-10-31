//Sergio Gumpert

using System;

class ShowArray
{
    static void Main()
    {
        string[] days = new string[7];
        days[0] = "Monday";
        days[1] = "Tuesday";
        days[2] = "Wednesday";
        days[3] = "Thursday";
        days[4] = "Friday";
        days[5] = "Saturday";
        days[6] = "Sunday";

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine(days[i]);
        }

        foreach (string day in days)
        {
            Console.WriteLine( day );
        }
    }
}
