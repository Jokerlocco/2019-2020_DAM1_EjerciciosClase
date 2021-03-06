﻿using System;

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
    }
}
