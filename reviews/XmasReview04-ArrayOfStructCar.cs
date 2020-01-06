// Pablo Conde 

/*Create a program that asks the user for the brand, model and power
of 5 cars, which will be stored in an array of struct. Then it will 
display the brand, model and power of the most powerful car. If there are 
several cars that have the same power, all of them will be shown.*/

using System;

class CarModels
{
    struct car
    {
        public string brand;
        public string model;
        public float power;
    }
    
    static void Main()
    {
        const int AMOUNT = 5;
        car[] cars = new car[AMOUNT];
        
        for (int i = 0; i < cars.Length; i++)
        {
            Console.Write("Car " + (i+1) + " brand: ");
            cars[i].brand = Console.ReadLine();
            
            Console.Write("Car " + (i+1) + " model: ");
            cars[i].model = Console.ReadLine();
            
            Console.Write("Car " + (i+1) + " power: ");
            cars[i].power = Convert.ToSingle(Console.ReadLine());
        }
        Console.WriteLine();
        
       SortByPower(cars);
       
       for (int i = 0; i < cars.Length; i++)
       {
            if(cars[0].power == cars[i].power)
                Console.WriteLine(cars[i].brand + " / " + cars[i].model
                + " / " + cars[i].power);
       }
        
    }
    
    static car[] SortByPower (car[] cars )
    {
        for (int i = 0; i < cars.Length - 1; i++)
        {
            for (int j = i + 1; j < cars.Length; j++)
            {
                if(cars[i].power < cars[j].power)
                {
                    car aux = cars[i];
                    cars[i] = cars[j];
                    cars[j] = aux;
                }
            }
        }
        return cars;
    }
}
