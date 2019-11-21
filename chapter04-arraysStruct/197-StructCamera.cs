using System;

public class StructCamera
{
    struct camera
    {
        public string brand;
        public string model;
        public float mp;
        public float price;
    }

    public static void Main()
    {
        int option;
        const int SIZE = 100;
        camera[] c = new camera[SIZE];
        int amount = 0;

        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add camera");
            Console.WriteLine("2. View cameras");
            Console.WriteLine("3. Delete a camera");
            Console.WriteLine("0. Exit");
            Console.Write("Enter option: ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1: // Add
                    if (amount >= SIZE)
                        Console.WriteLine("Database full");
                    else
                    {
                        Console.Write("Enter brand of camera: ");
                        c[amount].brand = Console.ReadLine();

                        Console.Write("Enter model of camera: ");
                        c[amount].model = Console.ReadLine();

                        Console.Write("Enter resolution of camera (MP): ");
                        c[amount].mp = Convert.ToSingle(Console.ReadLine());

                        Console.Write("Enter price of the camera: ");
                        c[amount].price = Convert.ToSingle(Console.ReadLine());

                        amount++;
                    }
                    break;

                case 2: // View all
                    for (int i = 0; i < amount; i++)
                        Console.WriteLine("Camera {0}: {1} {2}, {3} MP, {4} €",
                            i + 1, c[i].brand, c[i].model, c[i].mp, c[i].price);
                    break;

                case 3: // Delete
                    Console.Write("Enter camera number to delete: ");
                    int pos = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (pos >= amount)
                    {
                        Console.WriteLine("There are not so many cameras");
                    }
                    else
                    {
                        for (int i = pos; i < amount; i++)
                        {
                            c[i] = c[i + 1];
                        }
                        amount--;
                        Console.WriteLine("Deleted");
                    }
                    break;

                case 0:
                    Console.WriteLine("See you soon");
                    break;

                default:
                    Console.WriteLine("Wrong option");
                    break;

            }
        }
        while (option != 0);
    }
}
