//Alberto Girón Serna

using System;

class InitializedArray
{
    static void Main ()
    {
        string[] days= {"Monday", "Tuesday", "Wednesday", "Thursday",
             "Friday", "Saturday", "Sunday"};
        
        Console.Write("Number of day (1 to seven): ");
        int d = Convert.ToByte(Console.ReadLine());
        if(d >= 1 && d <= 7)
            Console.WriteLine("The day is: "+ days[d-1]);
        else
            Console.WriteLine("1 to 7, please");
    }
}
