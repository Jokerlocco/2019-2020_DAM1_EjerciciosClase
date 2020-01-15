/*
Mesa + Mesita + Propiedades
*/

using System;

class Mesa
{
    protected ushort largo;
    public ushort Largo
    {
        get { return largo; }
        set { largo = value; }
    }

    protected ushort ancho;
    public ushort Ancho
    {
        get { return ancho; }
        set { ancho = value; }
    }

    protected string color;
    public string Color
    {
        get { return color; }
        set { color = value; }
    }


    public Mesa(ushort largo, ushort ancho, string color)
    {
        this.largo = largo;
        this.color = color;
        this.ancho = ancho;
    }

    public Mesa(ushort largo, ushort ancho)
        : this(largo, ancho, "blanco")
    {
    }


    public override string ToString()
    {
        return largo + "-" + ancho + "-" + color;
    }
}

class Mesita : Mesa
{

    public Mesita(string color)
        : base(60, 40, color)
    {
    }
}


class Program
{
    static void Main()
    {
        Mesa[] mesas = new Mesa[5];

        mesas[0] = new Mesa(22, 33, "marrón");

        /*
        mesas[0].SetLargo(50);
        Console.WriteLine( mesas[0].GetLargo() );
        */

        mesas[0].Largo = 50;
        Console.WriteLine( mesas[0].Largo );

        mesas[1] = new Mesita("marrón");
        mesas[2] = new Mesa(23, 34);
        mesas[3] = new Mesita("marrón");
        mesas[4] = new Mesa(24, 35, "marrón");
    }
}
