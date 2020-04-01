//Lautaro Álvaro Fernández

using System;
using System.IO;

class Diary
{
    static void Main()
    {
        StreamWriter file = File.CreateText("agenda.txt");
        
        Console.Write(" Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        
        DateTime day = new DateTime(year, 01, 01);
        int nextYear = day.Year + 1;
        bool nextMonth = true;
        
        while ( day.Year < nextYear )
        {
            int month = day.Month;
            if ( nextMonth )
            {
                file.WriteLine("-- " + day.ToString("MMMM") + " " 
                    + day.Year.ToString() + " --");
            }
            
            file.WriteLine(day.ToString("dddd") + ", " + day.Day + ": ");
            
            day = day.AddDays(1);
            
            if ( day.Month != month )
            {
                nextMonth = true;
                file.WriteLine();
            }
            else
                nextMonth = false;
        }
        file.Close();
        
        Console.WriteLine(" - Diary created - ");
    }
}
