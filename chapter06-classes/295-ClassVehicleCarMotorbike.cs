using System;

class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Wheels { get; set; }


    public Vehicle(string brand, string model, int wheels)
    {
        Brand = brand;
        Model = model;
        Wheels = wheels;
    }

    public virtual void Display()
    {
        Console.WriteLine(Brand + ", " + Model +
            ", " + Wheels + " wheels");
    }
}

// --------------

class Car : Vehicle
{
    public Car(string brand, string model)
        : base(brand, model, 4)
    {
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("(Car)");
    }
}

// --------------

class Motorbike : Vehicle
{
    public Motorbike(string brand, string model)
        : base(brand, model, 2)
    {
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("(Motorbike)");
    }
}

// --------------

class Motorbike3wheels : Motorbike
{
    public Motorbike3wheels(string brand, string model)
        : base(brand, model)
    {
        Wheels = 3;
    }
}

// --------------

class VehicleTest
{
    static void Main()
    {
        Vehicle v = new Vehicle("Fiat", "Cinquecento", 4);
        Car c = new Car("DeTomaso", "Pantera");
        Motorbike m = new Motorbike("Yamaha", "MT-07");

        Vehicle[] myVehicles = new Vehicle[3];
        myVehicles[0] = v;
        myVehicles[1] = c;
        myVehicles[2] = m;

        foreach (Vehicle vehicle in myVehicles)
        {
            vehicle.Display();
        }
    }
}
