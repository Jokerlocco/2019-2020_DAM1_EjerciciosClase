using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio2020
{
    class ListaDeLibros
    {
        private List<Libro> lista = new List<Libro>();
        public int Cantidad { get { return lista.Count; } }

        public ListaDeLibros()
        {
            Cargar();
        }

        public Libro Get(int n)
        {
            return lista[n];
        }

        public void Incluir (Libro l)
        {
            lista.Add(l);
            Guardar();
        }

        public void Cargar()
        {
            if (!File.Exists("libros.txt"))
                return;

            lista = new List<Libro>();
            StreamReader fichero = new StreamReader("libros.txt");
            int cantidad = Convert.ToInt32(fichero.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(
                    new Libro(
                        fichero.ReadLine(), // Titulo
                        fichero.ReadLine(), // Autor
                        fichero.ReadLine(), // Edit
                        Convert.ToInt32(fichero.ReadLine()), // Pags
                        fichero.ReadLine(), // Categ
                        Convert.ToInt32(fichero.ReadLine()), // Anyo
                        fichero.ReadLine(), // Ubic
                        fichero.ReadLine() // Observ
                     )
                 );
            }
            fichero.Close();
        }

        public void Guardar()
        {
            StreamWriter fichero = new StreamWriter("libros.txt");
            fichero.WriteLine(Cantidad);
            foreach(Libro l in lista)
            {
                fichero.WriteLine(l.Titulo);
                fichero.WriteLine(l.Autor);
                fichero.WriteLine(l.Editorial);
                fichero.WriteLine(l.Paginas);
                fichero.WriteLine(l.Categoria);
                fichero.WriteLine(l.Anyo);
                fichero.WriteLine(l.Ubicacion);
                fichero.WriteLine(l.Observaciones);
            }
            fichero.Close();
        }


    }
}
