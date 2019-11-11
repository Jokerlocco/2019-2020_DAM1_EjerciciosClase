using System;

public class Statistics2
{
    public static void Main()
    {
        const int MAX = 1000;
        int option;
        int amountOfData = 0;
        double[] data = new double[MAX];
        
        double search;
        bool found = false;
        
        double sum, average, max, min;
        
        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Show all");
            Console.WriteLine("3) Search");
            Console.WriteLine("4) Statistics");
            Console.WriteLine("0) Quit");
            
            option = Convert.ToInt32(Console.ReadLine());
            
            switch(option)
            {
                case 1:
                    if (amountOfData < MAX)
                    {
                        Console.Write("Enter data #{0}: ",
                            amountOfData + 1);
                        data[amountOfData] =
                            Convert.ToDouble(Console.ReadLine());
                        amountOfData++;
                    }
                    break;
                    
                case 2:
                    Console.Write("Data entered: ");
                    for(int i = 0; i < amountOfData; i++)
                        Console.Write(data[i] + " ");
                    Console.WriteLine();
                    break;
                    
                case 3:
                    found = false;
                    Console.WriteLine("Data to search?");
                    search = Convert.ToDouble(Console.ReadLine());
                    
                    for(int i = 0; i < amountOfData; i++)
                    {
                        if(search == data[i])
                            found = true;
                    }
                    if(found)
                        Console.WriteLine("Found!");
                    else
                        Console.WriteLine("Not found");
                    break;
                    
                case 4:
                    Console.WriteLine("Amount of data: " + amountOfData);
                    
                    sum = 0;
                    for(int i = 0; i < amountOfData; i++)
                        sum += data[i];
                    Console.WriteLine("Sum: " + sum);
                    
                    average = sum / amountOfData;
                    Console.WriteLine("Average: " + average);
                    
                    max = min = data[0];
                    for(int i = 0; i < amountOfData; i++)
                    {
                        if(data[i] > max) max = data[i];
                        if(data[i] < min) min = data[i];
                    }
                    Console.WriteLine("Max: " + max);
                    Console.WriteLine("Min: " + min);
                    
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
        } while(option != 0);
    }
}
