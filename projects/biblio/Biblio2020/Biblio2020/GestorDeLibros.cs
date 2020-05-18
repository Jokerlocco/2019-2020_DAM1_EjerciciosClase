using System;
using System.Collections.Generic;

namespace Biblio2020
{
    class GestorDeLibros
    {
        private int fichaActual;
        private ListaDeLibros datos;
        private bool terminado;
        private string textoBusqueda=""; // Compartido, para conservar entre búsquedas
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
            do
            {
                cm.CambiarColorFondo("az");
                Console.Clear();
                DibujarMenus();
                MostrarFicha(fichaActual);
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.F1)
                    MostrarAyuda();
                else if (tecla.Key == ConsoleKey.RightArrow)
                    AvanzarAPosterior();
                else if (tecla.Key == ConsoleKey.LeftArrow)
                    RetrocederAAnterior();
                else if (tecla.Key == ConsoleKey.Home)
                    fichaActual = 0;
                else if (tecla.Key == ConsoleKey.End)
                    fichaActual = datos.Cantidad - 1;
                else
                    switch (tecla.KeyChar)
                    {
                        case '1': RetrocederAAnterior(); break;
                        case '2': AvanzarAPosterior(); break;
                        case '3': IrANumero(); break;
                        case '4': Buscar(); break;
                        case '5': Anyadir(); break;
                        case '6': Modificar(); break;
                        case '7': MostrarMenuListados(); break;
                        case 'B': case 'b': Borrar(); break;
                        case 'L': case 'l': MostrarMenuListados(); break;
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
            cm.Escribir(3, 22, 
                "1-Anterior    2-Posterior   3-Número   4-Buscar   5-Añadir   6-Modificar", 
                "bl");
            cm.Escribir(15, 23, "7-Listados   B-Borrar   F1-Ayuda   0-Terminar", "bl");
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
            l.Titulo = cm.Pedir(20, 5, 40, "");
            l.Autor = cm.Pedir(20, 6, 40, "");
            l.Editorial = cm.Pedir(20, 7, 20, "");
            l.Paginas = Convert.ToInt32( cm.Pedir(20, 8, 4, "") );
            l.Categoria = cm.Pedir(20, 9, 30, ""); ;
            l.Anyo = Convert.ToInt32(cm.Pedir(20, 10, 4, ""));
            l.Ubicacion = cm.Pedir(20, 11, 40, "");
            l.Observaciones = cm.Pedir(5, 13, 70, "");

            datos.Incluir(l);
        }


        /// <summary>
        /// Va a la ficha con un cierto número
        /// </summary>
        private void IrANumero()
        {
            cm.DibujarVentana(50, 10, 20, 7, "ro");
            cm.Escribir(52, 13, "Ficha?", "bl");
            try
            {
                int numero = Convert.ToInt32(cm.Pedir(60, 13, 4, "1")) - 1;
            
                if ((numero >= 0) && (numero < datos.Cantidad))
                    fichaActual = numero;
            }
            catch(Exception)
            {
                cm.Escribir(20, 14, "Número no válido", "am");
                Console.ReadKey(true);
            }
            cm.CambiarColorFondo("az");
        }


        /// <summary>
        /// Va a la siguiente ficha que contiene un cierto texto
        /// </summary>
        private void Buscar()
        {
            int fichaDePartida = fichaActual;
            cm.DibujarVentana(30, 10, 40, 7, "ro");
            cm.Escribir(32, 12, "¿Texto a buscar?", "bl");
            textoBusqueda = cm.Pedir(50, 12, 17, textoBusqueda);
            bool encontrado = false;

            while ((fichaActual < datos.Cantidad) && (! encontrado) )
            {
                if (datos.Get(fichaActual).Contiene(textoBusqueda))
                    encontrado = true;
                else
                    fichaActual++;
            }
            if (!encontrado)
            {
                fichaActual--;
                cm.Escribir(32, 13, "No encontrado", "am");
                if (fichaDePartida != 0)
                {
                    cm.Escribir(32, 14, "¿Buscar desde el principio (s/n)?", "bl");
                    ConsoleKeyInfo tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.S)
                    {
                        fichaActual = 0;
                        while ((fichaActual < fichaDePartida) && (!encontrado))
                        {
                            if (datos.Get(fichaActual).Contiene(textoBusqueda))
                                encontrado = true;
                            else
                                fichaActual++;
                        }
                        if (!encontrado)
                        {
                            cm.Escribir(32, 15, "No encontrado", "am");
                            Console.ReadKey(true);
                        }
                    }
                }
                else
                    Console.ReadKey(true);
            }

            cm.CambiarColorFondo("az");
        }


        /// <summary>
        /// Pide datos para una modificar una ficha y guarda los cambios
        /// </summary>
        private void Modificar()
        {
            Libro l = datos.Get(fichaActual);
            Console.ForegroundColor = ConsoleColor.Gray;
            l.Titulo = cm.Pedir(20, 5, 40, l.Titulo);
            l.Autor = cm.Pedir(20, 6, 40, l.Autor);
            l.Editorial = cm.Pedir(20, 7, 20, l.Editorial);
            l.Paginas = Convert.ToInt32(cm.Pedir(20, 8, 4, l.Paginas.ToString()));
            l.Categoria = cm.Pedir(20, 9, 30, l.Categoria); ;
            l.Anyo = Convert.ToInt32(cm.Pedir(20, 10, 4, l.Anyo.ToString()));
            l.Ubicacion = cm.Pedir(20, 11, 40, l.Ubicacion);
            l.Observaciones = cm.Pedir(5, 13, 70, l.Observaciones);

            datos.Modificar(l, fichaActual);
        }

        /// <summary>
        /// Muestra una ventana de ayuda simple
        /// </summary>
        private void MostrarAyuda()
        {
            cm.DibujarVentana(10, 3, 60, 18, "ro");
            cm.Escribir(21, 5, "Ayuda básica", "bl");

            cm.Escribir(21, 7, "Pulsa 1 o 2 para moverte entre las fichas", "gr");
            cm.Escribir(21, 8, "Usa 3 para ir a la ficha con un cierto número", "gr");
            cm.Escribir(21, 9, "Usa 4 para buscar un cierto texto", "gr");
            cm.Escribir(21, 10, "Añade una nueva ficha con 5", "gr");
            cm.Escribir(21, 11, "Modifica la ficha actual con 6", "gr");
            cm.Escribir(21, 12, "Usa B para borrar la ficha actual", "gr");
            cm.Escribir(21, 13, "Con 7 podrás acceder a listados avanzados", "gr");

            cm.Escribir(21, 15, "(Los datos seguardan automáticamente)", "gr");

            Console.ReadKey(true);
            cm.CambiarColorFondo("az");
        }

        /// <summary>
        /// Va a la siguiente ficha que contiene un cierto texto
        /// </summary>
        private void Borrar()
        {
            cm.DibujarVentana(50, 10, 20, 7, "ro");
            cm.Escribir(52, 13, "¿Borrar (s/n)?", "bl");
            ConsoleKeyInfo tecla = Console.ReadKey(true);
            if (tecla.Key == ConsoleKey.S)
                datos.Borrar(fichaActual);
            fichaActual--;
            cm.CambiarColorFondo("az");
        }


        /// <summary>
        /// Muestra el menú de listados
        /// </summary>
        private void MostrarMenuListados()
        {
            Console.Clear();
            cm.Escribir(10, 5, "Escoja una opción", "bl");
            cm.Escribir(10, 7, "1. Todos los libros", "gr");
            cm.Escribir(10, 8, "2. Libros de una cierta categoría", "gr");
            cm.Escribir(10, 9, "0. Volver", "gr");

            int opcion = Convert.ToInt32( cm.Pedir(15, 10, 1, "1") );
            if (opcion == 0)
                return;

            List<string> lista;
            if (opcion == 2)
            {
                cm.Escribir(10, 12, "¿Categoría (búsqueda exacta)?", "gr");
                string categ = cm.Pedir(10, 13, 20, "");
                lista = datos.ObtenerComoTextoPorCategoria(categ);
            }
            else
                lista = datos.ObtenerTodosComoTexto();

            VisorDeTexto visor = new VisorDeTexto(lista);
            visor.Mostrar();
        }
    }
}
