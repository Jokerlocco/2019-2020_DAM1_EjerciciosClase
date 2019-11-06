using System;

class DayOfTheYear
{
    static void Main()
    {
        int[] daysInAMonth = {31, 28, 31, 30, 31, 30,
            31, 31, 30, 31, 30, 31};
        int sum = 0;

        Console.Write("Enter the number of month (1 to 12): ");
        int monthNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of day: ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        for(int i = 0 ;i < monthNumber-1 ; i++)
            sum += daysInAMonth[i];
        sum += dayNumber;

        Console.WriteLine("It is the day number {0} of the year",
            sum);
    }
}
