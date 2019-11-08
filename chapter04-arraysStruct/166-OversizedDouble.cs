using System;
using System.IO;

class Statistics1
{
    static void Main()
    {
        const int MAX = 1000;
        double[] data = new double[MAX];
        int amount = 0;
        char option;

        do
        {
            Console.WriteLine("A- Add data");
            Console.WriteLine("S- Show data");
            Console.WriteLine("I- Insert data");
            Console.WriteLine("D- Delete data:");
            Console.WriteLine("Q- Quit");
            option = Convert.ToChar(Console.ReadLine());
            switch (option)
            {
                case 'a':
                case 'A':
                    if (amount < MAX)
                    {
                        Console.WriteLine("Enter data at pos {0} ",
                            amount+1);
                        data[amount] = 
                            Convert.ToDouble(Console.ReadLine());
                        amount++;
                    }
                    else
                    {
                        Console.WriteLine("Database full");
                    }
                    break;
                    
                case 's':
                case 'S':
                    if (amount == 0)
                        Console.WriteLine("No data to display");
                    else
                    {
                        for (int i = 0; i < amount; i++)
                        {
                            Console.WriteLine((i + 1) + ": " + data[i]);
                            if (i % 22 == 21)
                            {
                                Console.Write("Press Enter to continue... ");
                                Console.ReadLine();
                            }
                        }
                    }
                    break;

                case 'i':
                case 'I':
                    Console.Write("Which position to insert (1 to {0}): ",
                        amount);
                    int positionToInsert = 
                        Convert.ToInt32(Console.ReadLine()) - 1;
                                        
                    if (positionToInsert >= amount)
                    {
                        Console.WriteLine("There are not so many records");
                    }
                    else 
                    {
                        Console.Write("What data: ");
                        double newData = 
                            Convert.ToDouble( Console.ReadLine());
                        for (int i = amount; i > positionToInsert; i--)
                        {
                            data[i] = data[i - 1];
                        }
                        data[positionToInsert] = newData;
                        amount++;
                    }
                    break;

                case 'd':
                case 'D':
                    Console.Write("Which position to delete (1 to {0}): ",
                        amount);
                    int positionToDelete = 
                        Convert.ToInt32(Console.ReadLine()) - 1;
                    if (positionToDelete >= amount)
                    {
                        Console.WriteLine("There are not so many records");
                    }
                    else 
                    {
                        for (int i = positionToDelete; i < amount; i++)
                        {
                            data[i] = data[i + 1];
                        }
                        amount--;
                    }
                    break;
                case 'q':
                case 'Q':
                    Console.Write("Bye!");
                    break;
                default:
                    Console.Write("Wrong option");
                    break;
            }
            
        }
        while ((option != 'q') && (option != 'Q'));
    }
}

