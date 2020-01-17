// Pablo Vigara Fernandez

using System;

class Medio
{

    public string Autor { get; set; }
    public int Tamanyo { get; set; }
    public string Formato { get; set; }

    public Medio (string autor, int tamanyo, string formato)
    {
        this.Autor = autor;
        this.Tamanyo = tamanyo;
        this.Formato = formato;
    }

    public virtual void Display()
    {
        Console.WriteLine("Autor: " + Autor + ", Tamaño: " + Tamanyo +
            ", Formato: " + Formato);
    }
}

// --------------

class Imagen : Medio
{
    public int Ancho { get; set; }
    public int Alto { get; set; }

    public Imagen(string autor, int tamanyo, string formato, int ancho, int alto)
        : base(autor, tamanyo, formato)
    {
        this.Ancho = ancho;
        this.Alto = alto;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine(", Ancho: " + Ancho + ", Alto: " + Alto);
    }
}

// --------------

class Sonido : Medio
{
    public bool Estereo { get; set; }
    public int Kbps { get; set; }
    public int Duracion { get; set; }

    public Sonido 
        (string autor, int tamanyo, string formato, bool estereo, int kbps, int duracion)
            : base(autor, tamanyo, formato)
    {
        this.Estereo = estereo;
        this.Kbps = kbps;
        this.Duracion = duracion;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine(", Estereo: " + Estereo + ", Kbps: "
            + Kbps + ", Duracion: " + Duracion);
    }
}

// --------------

class Video : Medio
{
    public string Codec { get; set; }
    public int Ancho { get; set; }
    public int Alto { get; set; }
    public int Duracion { get; set; }

    public Video
        (string autor, int tamanyo, string formato, string codec, int ancho, int alto, int duracion)
            : base(autor, tamanyo, formato)
    {
        this.Codec = codec;
        this.Ancho = ancho;
        this.Alto = alto;
        this.Duracion = duracion;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine(", " + Codec + ", " + Ancho + ", " + Alto + ", " + Duracion);
    }
}

// --------------

class PruebaDeMedios
{
    static void Main()
    {
        Medio[] medios = new Medio[4];

        medios[0] = new Medio("Pablo Vigara", 34, "mp3");
        medios[1] = new Imagen("Peter Parker", 50, "mp3", 500, 600);
        medios[2] = new Sonido("Luis Fonsi", 65, "mp3", true, 43, 185);
        medios[3] = new Video("Daddy Yankee", 1, "mp3", "H.264", 550, 650, 243);

        foreach (Medio mediosTest in medios)
        {
            mediosTest.Display();
        }
    }
}
