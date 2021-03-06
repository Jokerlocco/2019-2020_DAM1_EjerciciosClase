﻿using System;

namespace ColeccMP3
{
    public class MP3 : IComparable<MP3>
    {
        public string Artista { get; set; }
        public string Titulo { get; set; }
        public string Fichero { get; set; }
        public string Categoria { get; set; }
        public string Ubicacion { get; set; }
        public int TamanyoKB { get; set; }
        public DateTime Fecha { get; set; }

        public int CompareTo(MP3 otro)
        {
            return String.Compare(this.Titulo,
                    otro.Titulo, true);
        }

        public bool Contiene(string texto)
        {
            return Titulo.ToUpper().Contains(texto.ToUpper())
                || Artista.ToUpper().Contains(texto.ToUpper())
                || Fichero.ToUpper().Contains(texto.ToUpper())
                || Categoria.ToUpper().Contains(texto.ToUpper())
                || Ubicacion.ToUpper().Contains(texto.ToUpper());
        }

    }
}
