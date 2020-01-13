using System;

class Motorbike
{
    private string brand;
    private string model;
    private static int wheels = 2;
      
    public string GetBrand() { return brand; }
    public int GetWheels() { return wheels; }

    public void SetBrand(string brand) { this.brand = brand; }
    public void SetWheels(int wheels) { Motorbike.wheels = wheels; }

    public void Show()
    {
        Console.WriteLine(brand + " - " + model + " - " + wheels);
    }

    public static void ShowAmountOfWheels()
    {
        Console.WriteLine(wheels);
    }
}


class PruebaDeMoto
{
    static void Main()
    {
        Motorbike.ShowAmountOfWheels();

        Motorbike m1 = new Motorbike();
        m1.SetBrand("Honda");
        m1.Show();

        Motorbike m2 = new Motorbike();
        m2.SetBrand("Yamaha");
        m2.SetWheels(3);  // !!!!!
        m2.Show();

        m1.Show();
    }
}
