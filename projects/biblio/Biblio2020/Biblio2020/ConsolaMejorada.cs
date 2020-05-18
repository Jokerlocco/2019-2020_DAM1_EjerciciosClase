using System;

namespace Biblio2020
{
    class ConsolaMejorada
    {
        public void Escribir(int x, int y, 
            string texto, string color)
        {
            CambiarColor(color);
            Console.SetCursorPosition(x, y);
            Console.Write(texto);
        }

        public string Pedir(int x, int y, 
            int longitudMax, string textoInicial)
        {
            bool terminado = false;
            string textoTemporal = textoInicial;
            do
            {
                Console.SetCursorPosition(x-1, y);
                Console.Write("[" + textoTemporal.PadRight(
                    longitudMax, '·') + "]");
                Console.SetCursorPosition(x+textoTemporal.Length, y);
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.Enter)
                {
                    terminado = true;
                }
                else if (tecla.Key == ConsoleKey.Backspace)
                {
                    if (textoTemporal.Length > 0)
                        textoTemporal = textoTemporal.Substring(0,
                            textoTemporal.Length - 1);
                }
                else
                {
                    if (textoTemporal.Length < longitudMax)
                        textoTemporal += tecla.KeyChar;
                }

            }
            while (!terminado);
            return textoTemporal;
        }

        public void DibujarVentana(int x, int y, 
            int ancho, int alto, string color)
        {
            CambiarColorFondo(color);
            for (int fila = 0; fila < alto; fila++)
            {
                for (int columna = 0; columna < ancho; columna++)
                {
                    Console.SetCursorPosition(x + columna, y + fila);
                    Console.Write(" ");
                }
            }
        }

        public void CambiarColor(string color)
        {
            switch(color)
            {
                case "blanco":
                case "bl":
                    Console.ForegroundColor = ConsoleColor.White; break;
                case "gris":
                case "gr":
                    Console.ForegroundColor = ConsoleColor.Gray; break;
                case "amarillo":
                case "am":
                    Console.ForegroundColor = ConsoleColor.Yellow; break;
            }
        }

        public void CambiarColorFondo(string color)
        {
            switch (color)
            {
                case "azul":
                case "az":
                    Console.BackgroundColor = ConsoleColor.DarkBlue; break;
                case "rojo":
                case "ro":
                    Console.BackgroundColor = ConsoleColor.DarkRed; break;
                case "verde":
                case "ve":
                    Console.BackgroundColor = ConsoleColor.DarkGreen; break;
                case "negro":
                case "ne":
                    Console.BackgroundColor = ConsoleColor.Black; break;
            }
        }
    }
}
