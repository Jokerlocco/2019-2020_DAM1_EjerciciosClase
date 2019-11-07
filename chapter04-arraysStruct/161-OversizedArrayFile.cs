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
            data = File.ReadAllLines("friends.txt");
        for (int i = 0; i < MAX_CAPACITY; i++)
        {
            if (data[i] != "")
                amount++;
        }

        do
        {
            Console.WriteLine("1- Add data");
            Console.WriteLine("2- Show data");
            Console.WriteLine("0- Quit");
            option = Console.ReadLine();

            if (option == "1")
            {
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
            }
            else if (option == "2")
            {
                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine( (i+1) +": "+ data[i]);
                }
            }

        }
        while (option != "0");
        File.WriteAllLines("friends.txt", data);
    }
}
