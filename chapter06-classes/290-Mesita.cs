/*
Crea una clase Mesa, que tendrá un largo y un ancho (enteros cortos sin 
signos) y un "color" (string). Crea getters y setters, un constructor 
que dé valor a los 3 atributos (en el mismo orden en que se han 
definido: largo, ancho, color) y otro que dé valor al largo y al ancho, 
pero no al color, que se prefijará a "Blanco".

Crea una clase Mesita, que herede de Mesa. El constructor de la mesita 
prefijará el largo a 60 y el ancho a 40, pero permitirá indicar el 
color.

Crea un array de 5 mesas, de las cuales la segunda y la cuarta serán 
mesitas. Elige los tamaños que quieras para las mesas. Todas serán de 
color "Marrón" excepto la tercera.
*/

using System;

class Mesa
{
 
    protected ushort largo;
    protected ushort ancho;
    protected string color;

    public Mesa(ushort largo,ushort ancho, string color)
    {
        this.largo = largo;
        this.color = color;
        this.ancho = ancho;
    }
    
    /*
    public Mesa(ushort largo,ushort ancho) 
    {
        this.largo = largo;
        this.color = "blanco";
        this.ancho = ancho;
    }
    */
    
    public Mesa(ushort largo,ushort ancho) 
        : this (largo, ancho, "blanco")
    {
    }
    
    public void SetLargo(ushort largo)
    {
        this.largo = largo;
    }
    
    public void SetColor(string color)
    {
        this.color = color;
    }

    public void SetAncho(ushort ancho)
    {
        this.ancho = ancho;
    }

    
    public string GetColor()
    {
        return color;
    }
    public ushort GetLargo()
    {
        return largo;
    }

    public ushort GetAncho()
    {
        return ancho;
    }


    public override string ToString()
    {
        return largo + "-" + ancho +"-"+color;
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
        mesas[1] = new Mesita("marrón");
        mesas[2] = new Mesa(23, 34);
        mesas[3] = new Mesita( "marrón");
        mesas[4] = new Mesa(24, 35, "marrón");
    }
}
