// Class House + Flat + SmallFlat

class House
{
    protected int area;
    protected string color;

    public House(float area, string color)
    {
        this.area = (int) area;
        this.color = color;
    }

    public float GetArea() { return area; }
    public string GetColor() { return color; }

    public void SetArea(float area) { this.area = (int)area; }
    public void SetColor(string color) { this.color = color; }
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
        area = 45;
    }
}

// --------------

class HouseTest
{
    static void Main()
    {
        House h = new House( 120, "red");
        System.Console.WriteLine("House: " + h.GetColor() +
            ", " + h.GetArea() + "m2");
        Flat flat = new Flat();
        System.Console.WriteLine("Flat: " + flat.GetColor() +
            ", " + flat.GetArea() + "m2");
        SmallFlat sf = new SmallFlat();
        System.Console.WriteLine("Small Flat: " + sf.GetColor() +
            ", " + sf.GetArea() + "m2");
        sf.SetColor("yellow");
        sf.SetArea(47);
        System.Console.WriteLine("Small Flat corrected: " + 
            sf.GetColor() + ", " + 
            sf.GetArea() + "m2");
    }
    
}
