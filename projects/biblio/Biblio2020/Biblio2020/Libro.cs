using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio2020
{
    class Libro
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
    }
}
