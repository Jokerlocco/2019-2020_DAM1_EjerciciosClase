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
        ConsolaMejorada cm;

        public GestorDeLibros()
        {
            datos = new ListaDeLibros();
            cm = new ConsolaMejorada();
            fichaActual = 0;
            terminado = false;
        }

        private void PrepararConsola()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
        }

        /// <summary>
        /// Bucle principal del gestor de libros
        /// </summary>
        public void Ejecutar()
        {
            PrepararConsola();
            cm.DibujarVentana(20, 9, 40, 7, "ve");
            cm.Escribir(32, 12, "Gestor de libros", "am");
            Console.ReadKey(true);
            cm.CambiarColorFondo("az");
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
            cm.Escribir(1, 21, new string('-', 78), "bl");
            cm.Escribir(10, 22, "1 - Anterior    2-Posterior   5-Añadir" +
                "    0-Terminar", "bl");
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

            cm.Escribir(20, 5, l.Titulo, "gr");
            cm.Escribir(20, 6, l.Autor, "gr");
            cm.Escribir(20, 7, l.Editorial, "gr");
            cm.Escribir(20, 8, l.Paginas.ToString(), "gr");
            cm.Escribir(20, 9, l.Categoria, "gr");
            cm.Escribir(20, 10, l.Anyo.ToString(), "gr");
            cm.Escribir(20, 11, l.Ubicacion, "gr");
            cm.Escribir(5, 13, l.Observaciones, "gr");
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
            l.Titulo = Console.ReadLine();
            l.Autor = cm.Pedir(20, 6, 40, "");
            l.Editorial = cm.Pedir(20, 7, 20, "");
            l.Paginas = Convert.ToInt32( cm.Pedir(20, 8, 4, "") );
            l.Categoria = cm.Pedir(20, 9, 30, ""); ;
            l.Anyo = Convert.ToInt32(cm.Pedir(20, 10, 4, ""));
            l.Ubicacion = cm.Pedir(20, 11, 40, "");
            l.Observaciones = cm.Pedir(5, 13, 70, "");

            datos.Incluir(l);
        }
    }
}
