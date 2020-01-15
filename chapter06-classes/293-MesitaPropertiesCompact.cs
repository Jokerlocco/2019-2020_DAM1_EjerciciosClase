/*
Mesa + Mesita + Propiedades (compacto)
*/

using System;

class Mesa
{
    public ushort Largo { get; set; }
    public ushort Ancho { get; set; }
    public string Color { get; set; }

    public Mesa(ushort largo, ushort ancho, string color)
    {
        Largo = largo;
        Color = color;
        Ancho = ancho;
    }

    public Mesa(ushort largo, ushort ancho)
        : this(largo, ancho, "blanco")
    {
    }


    public override string ToString()
    {
        return Largo + "-" + Ancho + "-" + Color;
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
        Console.WriteLine(mesas[0].Largo);

        mesas[1] = new Mesita("marrón");
        mesas[2] = new Mesa(23, 34);
        mesas[3] = new Mesita("marrón");
        mesas[4] = new Mesa(24, 35, "marrón");
    }
}
