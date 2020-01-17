using System;

class Vector2D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Length
    {
        get { return Math.Sqrt(X * X + Y * Y); }
    }

    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return "<" + X + "," + Y + ">";
    }

    public void Add(Vector2D v)
    {
        X += v.X;
        Y += v.Y;
    }
    
    public static Vector2D Add(
        Vector2D v1, Vector2D v2)
    { 
        return new Vector2D(v1.X+v2.X, v1.Y+v2.Y);
    }
}

// -----------------------


class Program
{
    static void Main()
    {
        Vector2D v = new Vector2D(3, 4);
        Console.WriteLine(v);
        Console.WriteLine("Length = " + v.Length);
        v.Add(new Vector2D(5, 2));
        Console.WriteLine(v);
        
        Vector2D v2 = new Vector2D(-1, 5);
        Vector2D v3 = Vector2D.Add(v , v2);
        Console.WriteLine( v3 );
    }
}
