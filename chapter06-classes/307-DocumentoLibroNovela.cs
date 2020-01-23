// Sergio Gumpert
using System;


abstract class Documento
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Ubicacion { get; set; }

    public Documento(string titulo,string autor, string ubicacion)
    {
        Titulo = titulo;
        Autor = autor;
        Ubicacion = ubicacion;
    }

    public Documento(string titulo,string autor)
        : this(titulo,autor,"Ubicación desconocida.")
    {
    }

    public virtual bool Contiene (string texto)
    {
        if (Titulo.ToUpper().Contains(texto.ToUpper())
                || (Autor.ToUpper().Contains(texto.ToUpper()))
                || (Ubicacion.ToUpper().Contains(texto.ToUpper())))
            return true;
        else
            return false;
    }

    public override string ToString()
    {
        return Titulo + " - " + Autor + " - " + Ubicacion;
    }

}

class Libro : Documento
{
    public uint Paginas { get; set; }
    
    public Libro (string Titulo,string Autor,string Ubicacion,uint Paginas)
        : base(Titulo,Autor,Ubicacion)
    {
        this.Paginas = Paginas;
    }

    public Libro(string Titulo, string Autor) : base(Titulo, Autor)
    {
        this.Paginas = 0;
    }

    public override string ToString()
    {
        return base.ToString() + " - " + Paginas;
    }


}

sealed class Novela : Libro
{
    public Novela(string Titulo, string Autor, string Ubicacion, uint Paginas)
                : base(Titulo, Autor, Ubicacion,Paginas)
    {
    }


    public override string ToString()
    {
        return base.ToString() + " - Novela.";
    }
    
    
    public override bool Contiene (string texto)
    {
        return base.Contiene(texto) ||
            texto.ToUpper().Contains("NOVELA");
    }
}


/*
class NovelaTerror : Novela
{
}
*/

class Prueba
{
    static void Main()
    {

        Documento[] datos = new Documento[3];
        //Documento d1 = new Documento("1dam", "NachoCabanes");

        datos[0] = new Libro("1dam", "NachoCabanes");
        datos[1] = new Libro("2dam", "NachoCabanes", "SanVicente", 560);
        datos[2] = new Novela("3Daw", "NachoCabanes", "SanVicente3", 660);

        for (int i = 0; i < datos.Length; i++)
        {
            Console.WriteLine(datos[i]);
        }
        
        foreach(Documento d in datos)
        {
            if (d.Contiene("dam"))
                Console.WriteLine(d);
        }

    }
}
