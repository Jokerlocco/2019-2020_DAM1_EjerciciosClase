class House
{
    protected int area;
    protected string color;
    protected string type;

    public House(float area, string color)
    {
        this.area = (int) area;
        this.color = color;
        type = "House";
    }

    public float GetArea() { return area; }
    public string GetColor() { return color; }

    public void SetArea(float area) { this.area = (int)area; }
    public void SetColor(string color) { this.color = color; }

    public virtual void Show()
    {
        System.Console.WriteLine(type + ": " + color +
            ", " + area + "m2");
    }
}

// --------------

class Flat : House
{
    public Flat() : base(80, "white")
    {
        type = "Flat";
    }
}

// --------------

class SmallFlat : Flat
{
    public SmallFlat()
    {
        area = 45;
        type = "SmallFlat";
    }
}

// --------------

class HouseTest
{
    static void Main()
    {
        House h = new House( 120, "red");
        Flat flat = new Flat();
        SmallFlat sf = new SmallFlat();

        House[] myHouses = new House[3];
        myHouses[0] = h;
        myHouses[1] = flat;
        myHouses[2] = sf;

        foreach (House house in myHouses)
        {
            house.Show();
        }

        sf.SetColor("yellow");
        sf.SetArea(47);
        sf.Show();
    }
    
}
