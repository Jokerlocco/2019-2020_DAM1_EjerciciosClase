using System;
using System.IO;

class OversizedArray
{
    static void Main()
    {
        const int MAX_CAPACITY = 10000;
        string[] data = new string[MAX_CAPACITY];
        int amount = 0;
        string option;
        if (File.Exists("friends.txt"))
        {
            data = File.ReadAllLines("friends.txt");
            for (int i = 0; i < MAX_CAPACITY; i++)
            {
                if (data[i] != "")
                    amount++;
            }
        }

        do
        {
            Console.WriteLine("1- Add data");
            Console.WriteLine("2- Show data");
            Console.WriteLine("3- Move data");
            Console.WriteLine("4- Delete data:");
            Console.WriteLine("0- Quit");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    if (amount < MAX_CAPACITY)
                    {
                        Console.WriteLine("Tell me... ");
                        data[amount] = Console.ReadLine();
                        amount++;
                    }
                    else
                    {
                        Console.WriteLine("Database full");
                        Console.WriteLine("Please purchase PRO version");
                    }
                    break;
                    
                case "2":
                    for (int i = 0; i < amount; i++)
                    {
                        Console.WriteLine((i + 1) + " " + data[i]);
                    }
                    break;

                case "3":
                    Console.Write("Which position: ");
                    int positionToInsert = 
                        Convert.ToInt32(Console.ReadLine()) - 1;
                                        
                    if (positionToInsert >= amount)
                    {
                        Console.WriteLine("There are not so many records");
                    }
                    else 
                    {
                        Console.Write("What data: ");
                        string newData = Console.ReadLine();
                        for (int i = amount; i > positionToInsert; i--)
                        {
                            data[i] = data[i - 1];
                        }
                        data[positionToInsert] = newData;
                        amount++;
                    }
                    break;

                case "4":
                    Console.Write("Which position: ");
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
                case "0":
                    Console.Write("Bye!");
                    break;
                default:
                    Console.Write("Wrong option");
                    break;
            }
            
        }
        while (option != "0") ;
        File.WriteAllLines("friends.txt", data);
    }
}

