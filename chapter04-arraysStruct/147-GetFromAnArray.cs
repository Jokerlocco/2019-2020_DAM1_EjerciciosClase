// Jose Valera

using System;

class diasSemana
{
    static void Main()
    {
        string[] days = new string[7];
        byte n;
       
        Console.Write("Number of day (1=Monday): ");
        n = Convert.ToByte(Console.ReadLine());

        days[0] = "Monday";
        days[1] = "Tuesday";
        days[2] = "Wednesday";
        days[3] = "Thursday";
        days[4] = "Friday";
        days[5] = "Saturday";
        days[6] = "Sunday";
       
       Console.WriteLine(days[n - 1]);
    }
}
