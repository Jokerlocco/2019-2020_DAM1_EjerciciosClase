using System;

class House
{
    public int Area { get; set; }
    public string Color { get; set; }

    public House(float area, string color)
    {
        Area = (int)area;
        Color = color;
    }

    public override string ToString()
    {
        return GetType() +
            ": " + Color +
            ", " + Area + "m2";
    }
}

// --------------

class Flat : House
{
    public Flat() : base(80, "white")
    {
    }
}

// --------------

class SmallFlat : Flat
{
    public SmallFlat()
    {
        Area = 45;
    }
}

// --------------

class HouseTest
{
    static void Main()
    {
        House h = new House(120, "red");
        Flat flat = new Flat();
        SmallFlat sf = new SmallFlat();

        House[] myHouses = new House[3];
        myHouses[0] = h;
        myHouses[1] = flat;
        myHouses[2] = sf;

        foreach (House house in myHouses)
        {
            Console.WriteLine(house);
        }

        sf.Color = "yellow";
        sf.Area = 47;
        Console.WriteLine(sf);
    }

}
