using System;

namespace Biblio2020
{
    class Libro : IComparable<Libro>
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Paginas { get; set; }
        public string Categoria { get; set; }
        public int Anyo { get; set; }
        public string Ubicacion { get; set; }
        public string Observaciones { get; set; }

        public Libro()
        {
        }

        public Libro(string titulo, string autor, string editorial,
            int paginas, string categoria, int anyo,
            string ubicacion, string observaciones)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            Paginas = paginas;
            Categoria = categoria;
            Anyo = anyo;
            Ubicacion = ubicacion;
            Observaciones = observaciones;
        }

        public bool Contiene(string texto)
        {
            return Titulo.ToUpper().Contains(texto.ToUpper())
                || Autor.ToUpper().Contains(texto.ToUpper())
                || Editorial.ToUpper().Contains(texto.ToUpper())
                || Categoria.ToUpper().Contains(texto.ToUpper())
                || Ubicacion.ToUpper().Contains(texto.ToUpper())
                || Observaciones.ToUpper().Contains(texto.ToUpper());
        }

        public int CompareTo(Libro otro)
        {
            return Titulo.CompareTo(otro.Titulo);
        }

        public override string ToString()
        {
            return Titulo + " - " + Autor + " - " + Categoria;
        }
    }
}
