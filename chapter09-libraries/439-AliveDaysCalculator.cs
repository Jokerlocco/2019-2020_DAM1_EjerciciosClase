//Jose Valera 1ºDAM

using System;

class AliveDaysCalculator
{
    static void Main()
    {
        Console.WriteLine("Born Date");
        Console.Write("Day: ");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.Write("Month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        DateTime bornDate = new DateTime(year, month, day);
        DateTime currentDay = DateTime.Now;

        Console.WriteLine("Alive days: " + 
            (currentDay - bornDate).TotalDays);
    }
}
