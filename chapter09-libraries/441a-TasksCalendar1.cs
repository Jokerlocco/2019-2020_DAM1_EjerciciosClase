//Daniel García

using System;
using System.IO;

class TaskCalendar
{
    static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        string[] month = { "January", "February", "March", "April", "May",
            "June", "July", "August", "September", "October",
            "November", "December" };

        DateTime currentDay = new DateTime(year, 1, 1);

        try
        {
            StreamWriter output = new StreamWriter("diary.txt");

            for (int i = 0; i < 12; i++)
            {
                int currentMonth = currentDay.Month;
                output.WriteLine("-- " + month[currentDay.Month - 1] + " " 
                    + year + " --");
                while (currentMonth == currentDay.Month)
                {
                    output.WriteLine(currentDay.DayOfWeek + " " + currentDay.Day 
                        + ": ");
                    currentDay = currentDay.AddDays(1);
                }
                output.WriteLine();
            }

            output.Close();
            Console.WriteLine("File created");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (IOException)
        {
            Console.WriteLine("I/O exception");
        }
        catch (Exception error)
        {
            Console.WriteLine("Error! -> " + error);
        }
    }
}
