using System;

class Medio
{

    protected string autor;
    protected int tamanyo;
    protected string formato;

    public void SetAutor(string autor) { this.autor = autor; }
    public void SetTamanyo(int tamanyo) { this.tamanyo = tamanyo; }
    public void SetFormato(string formato) { this.formato = formato; }

    public string GetAutor() { return autor; }
    public int GetTamanyo() { return tamanyo; }
    public string GetFormato() { return formato; }

    public Medio (string autor, int tamanyo, string formato)
    {
        this.autor = autor;
        this.tamanyo = tamanyo;
        this.formato = formato;
    }

    public virtual void Display()
    {
        Console.WriteLine(autor + ", " + tamanyo +
            ", " + formato);
    }
}

// --------------

class Imagen : Medio
{
    protected int ancho;
    protected int alto;

    public Imagen(string autor, int tamanyo, string formato, int ancho, int alto)
        : base(autor, tamanyo, formato)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    public void SetAncho(int ancho) { this.ancho = ancho; }
    public void SetAlto(int alto) { this.alto = alto; }

    public int GetAncho() { return ancho; }
    public int GetAlto() { return alto; }

    public override void Display()
    {
        base.Display();
        Console.WriteLine(", " + ancho + ", " + alto);
    }
}

// --------------

class Sonido : Medio
{
    protected bool estereo;
    protected int kbps;
    protected int duracion;

    public Sonido 
        (string autor, int tamanyo, string formato, bool estereo, int kbps, int duracion)
            : base(autor, tamanyo, formato)
    {
        this.estereo = estereo;
        this.kbps = kbps;
        this.duracion = duracion;
    }

    public void SetEstereo(bool estereo) { this.estereo = estereo; }
    public void SetKbps(int kbps) { this.kbps = kbps; }
    public void SetDuracion(int duracion) { this.duracion = duracion; }

    public bool GetEstereo() { return estereo; }
    public int GetKbps() { return kbps; }
    public int GetDuracion() { return duracion; }

    public override void Display()
    {
        base.Display();
        Console.WriteLine(", " + estereo + ", " + kbps + ", " + duracion);
    }
}

// --------------

class Video : Medio
{
    protected string codec;
    protected int ancho;
    protected int alto;
    protected int duracion;

    public Video
        (string autor, int tamanyo, string formato, string codec, int ancho, int alto, int duracion)
            : base(autor, tamanyo, formato)
    {
        this.codec = codec;
        this.ancho = ancho;
        this.alto = alto;
        this.duracion = duracion;
    }

    public void SetCodec(string codec) { this.codec = codec; }
    public void SetAncho(int ancho) { this.ancho = ancho; }
    public void SetAlto(int alto) { this.alto = alto; }
    public void SetDuracion(int duracion ) { this.duracion = duracion; }

    public string GetCodec() { return codec; }
    public int GetAncho() { return ancho; }
    public int GetAlto() { return alto; }
    public int GetDuracion() { return duracion; }

    public override void Display()
    {
        base.Display();
        Console.WriteLine(", " + codec + ", " + ancho + ", " + alto + ", " + duracion);
    }
}

// --------------

class PruebaDeMedios
{
    static void Main()
    {
        Medio[] medios = new Medio[4];

        medios[0] = new Medio("1", 1, "mp3");
        medios[1] = new Imagen("1", 1, "mp3", 5, 5);
        medios[2] = new Sonido("1", 1, "mp3", true, 4, 4);
        medios[3] = new Video("1", 1, "mp3", "Hola", 1, 1, 30);

        foreach (Medio mediosTest in medios)
        {
            mediosTest.Display();
        }
    }
}
