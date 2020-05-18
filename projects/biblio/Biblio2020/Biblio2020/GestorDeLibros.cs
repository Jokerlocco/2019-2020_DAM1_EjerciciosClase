using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio2020
{
    class GestorDeLibros
    {
        private int fichaActual;
        private ListaDeLibros datos;
        private bool terminado;

        public GestorDeLibros()
        {
            datos = new ListaDeLibros();
            fichaActual = 0;
            terminado = false;
        }

        private void PrepararConsola()
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
        }

        /// <summary>
        /// Bucle principal del gestor de libros
        /// </summary>
        public void Ejecutar()
        {
            PrepararConsola();
            do
            {
                Console.Clear();
                DibujarMenus();
                MostrarFicha(fichaActual);
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                switch(tecla.KeyChar)
                {
                    case '1': RetrocederAAnterior(); break;
                    case '2': AvanzarAPosterior(); break;
                    case '5': Anyadir(); break;
                    case '0': terminado = true; break;
                }
            }
            while (!terminado);
        }

        /// <summary>
        /// Dibuja menú superior e inferior
        /// No borra antes la pantalla
        /// </summary>
        private void DibujarMenus()
        {
            // Info superior
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(1, 0);
            Console.WriteLine("Libros (ficha actual: "+
                (fichaActual+1) + "/" +
                datos.Cantidad +")");
            Console.SetCursorPosition(65, 0);
            Console.WriteLine("N.C., 2020");
            Console.WriteLine( " " + new string('-', 78));

            // Línea inferior, con opciones
            Console.SetCursorPosition(0, 21);
            Console.WriteLine(" " + new string('-', 78));
            Console.WriteLine("            1- Anterior, 2-Posterior, 5-Añadir" +
                ", 0-Terminar");
        }

        /// <summary>
        /// Muestra una ficha, la que está en la posición
        /// que se indique como parámetro
        /// </summary>
        /// <param name="numero">número de ficha a mostrar</param>
        private void MostrarFicha(int numero)
        {
            if ((numero < 0) || (numero >= datos.Cantidad))
                return;

            Console.WriteLine();
            Libro l = datos.Get(numero);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("Titulo");
            Console.WriteLine("Autor");
            Console.WriteLine("Editorial");
            Console.WriteLine("Paginas");
            Console.WriteLine("Categoria");
            Console.WriteLine("Año");
            Console.WriteLine("Ubicación");
            Console.WriteLine("Observaciones");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(20, 5);
            Console.WriteLine(l.Titulo);
            Console.SetCursorPosition(20, 6);
            Console.WriteLine(l.Autor);
            Console.SetCursorPosition(20, 7);
            Console.WriteLine(l.Editorial);
            Console.SetCursorPosition(20, 8);
            Console.WriteLine(l.Paginas);
            Console.SetCursorPosition(20, 9);
            Console.WriteLine(l.Categoria);
            Console.SetCursorPosition(20, 10);
            Console.WriteLine(l.Anyo);
            Console.SetCursorPosition(20, 11);
            Console.WriteLine(l.Ubicacion);
            Console.SetCursorPosition(5, 13);
            Console.WriteLine(l.Observaciones);
        }

        /// <summary>
        /// Avanza a ña ficha posterior, si existe
        /// </summary>
        private void AvanzarAPosterior()
        {
            if (fichaActual < datos.Cantidad-1)
                fichaActual++;
        }

        /// <summary>
        /// Retrocede a la ficha anterior, si existe
        /// </summary>
        private void RetrocederAAnterior()
        {
            if (fichaActual > 0)
                fichaActual--;
        }

        /// <summary>
        /// Pide datos para una nueva ficha y la añade
        /// </summary>
        private void Anyadir()
        {
            Libro l = new Libro();
            Console.Clear();
            DibujarMenus();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("Titulo?");
            Console.WriteLine("Autor");
            Console.WriteLine("Editorial");
            Console.WriteLine("Paginas");
            Console.WriteLine("Categoria");
            Console.WriteLine("Año");
            Console.WriteLine("Ubicación");
            Console.WriteLine("Observaciones");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(20, 5);
            l.Titulo = Console.ReadLine();
            Console.SetCursorPosition(20, 6);
            l.Autor = Console.ReadLine();
            Console.SetCursorPosition(20, 7);
            l.Editorial = Console.ReadLine();
            Console.SetCursorPosition(20, 8);
            l.Paginas = Convert.ToInt32( Console.ReadLine() );
            Console.SetCursorPosition(20, 9);
            l.Categoria = Console.ReadLine();
            Console.SetCursorPosition(20, 10);
            l.Anyo = Convert.ToInt32( Console.ReadLine() );
            Console.SetCursorPosition(20, 11);
            l.Ubicacion = Console.ReadLine();
            Console.SetCursorPosition(5, 13);
            l.Observaciones = Console.ReadLine();

            datos.Incluir(l);
        }
    }
}
