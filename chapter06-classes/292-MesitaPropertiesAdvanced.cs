/*
Mesa + Mesita + Propiedades (avanzado)
*/

using System;

class Mesa
{
    protected byte largo;
    public ushort Largo
    {
        get { if (largo < 0) return 0; else return largo; }
        set { largo = (byte) value; }
    }

    protected byte ancho;
    public ushort Ancho
    {
        get { return ancho; }
        set { ancho = (byte) value; }
    }

    protected string color;
    public string Color
    {
        get { return color; }
    }


    public Mesa(ushort largo, ushort ancho, string color)
    {
        this.largo = (byte) largo;
        this.color = color;
        this.ancho = (byte) ancho;
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
