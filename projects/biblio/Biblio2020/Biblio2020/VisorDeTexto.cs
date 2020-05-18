using System;
using System.Collections.Generic;
using System.IO;

namespace Biblio2020
{
    class VisorDeTexto
    {
        List<string> datos;
        ConsolaMejorada cm;
        bool volver = false;

        public VisorDeTexto(List<string> lista)
        {
            datos = lista;
            cm = new ConsolaMejorada();
        }

        public void Mostrar()
        {
            int lineaInicial = 0;
            int lineaFinal = 20;
            if (datos.Count <= lineaFinal)
                lineaFinal = datos.Count - 1;

            do
            {
                cm.CambiarColorFondo("az");
                Console.Clear();
                for (int i = lineaInicial; i <= lineaFinal; i++)
                    cm.Escribir(0,i-lineaInicial, datos[i], "gr");

                cm.Escribir(1, 24, "Flechas - Subir y bajar   E- Exportar PDF  ESC-Volver", "bl");

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (lineaFinal < datos.Count - 1)
                    {
                        lineaInicial++;
                        lineaFinal++;
                    }
                }

                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (lineaInicial > 0)
                    {
                        lineaInicial--;
                        lineaFinal--;
                    }
                }

                if (key.Key == ConsoleKey.Escape)
                    volver = true;

                if (key.Key == ConsoleKey.E)
                    ExportarTXT();

            }
            while (!volver);
        }

        public void ExportarTXT()
        {
            File.WriteAllLines("exportLibros.txt", datos);
            cm.DibujarVentana("Exportado", "am", "ve");
            Console.ReadKey(true);
        }

        public void ExportarCSV()
        {
            // TO DO
        }

        public void ExportarPDF()
        {
            // TO DO
        }

        public void ExportarXLS()
        {
            // TO DO
        }
    }
}
