using System;
using System.Collections.Generic;
using System.IO;

// Para PDF
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

// Para Excel
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

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
                    cm.Escribir(0, i - lineaInicial, datos[i], "gr");

                cm.Escribir(1, 24, "Flechas-Subir/bajar   E-Exportar TXT" +
                    "   C-CSV  P-PDF   X-XLS   ESC-Volver", "bl");

                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (lineaFinal < datos.Count - 1)
                        {
                            lineaInicial++;
                            lineaFinal++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (lineaInicial > 0)
                        {
                            lineaInicial--;
                            lineaFinal--;
                        }
                        break;
                    case ConsoleKey.Escape:
                        volver = true;
                        break;
                    case ConsoleKey.E:
                        ExportarTXT();
                        break;
                    case ConsoleKey.C:
                        ExportarCSV();
                        break;
                    case ConsoleKey.P:
                        ExportarPDF();
                        break;
                    case ConsoleKey.X:
                        ExportarXLS();
                        break;
                }

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
            List<string> datosCSV = new List<string>( datos );
            for (int i = 0; i < datosCSV.Count; i++)
            {
                datosCSV[i] = "\"" + datosCSV[i].Replace(" - ", "\",\"") + "\"";
            }
            File.WriteAllLines("exportLibros.csv", datosCSV);
            cm.DibujarVentana("Exportado", "am", "ve");
            Console.ReadKey(true);
            // TO DO
        }

        public void ExportarPDF()
        {
            // Basado en el ejemplo de:
            // https://www.c-sharpcorner.com/UploadFile/f2e803/basic-pdf-creation-using-itextsharp-part-i/

            FileStream fs = new FileStream("exportLibros.pdf", FileMode.Create);
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.AddAuthor("Nacho");
            document.AddTitle("Ejemplo de PDF");
            document.Open();
            foreach(string libro in datos)
                document.Add(new Paragraph(libro));
            document.Close();
            writer.Close();
            fs.Close();

            cm.DibujarVentana("Exportado", "am", "ve");
            Console.ReadKey(true);
        }

        public void ExportarXLS()
        {
            // Basado en el ejemplo de
            // http://www.independent-software.com/introduction-to-npoi.html

            IWorkbook workbook = new HSSFWorkbook();

            ISheet hoja = workbook.CreateSheet("Libros");
            IRow fila = hoja.CreateRow(0);
            ICell celda = fila.CreateCell(0);
            celda.SetCellValue("Título");
            celda = fila.CreateCell(1);
            celda.SetCellValue("Autor");

            for (int i = 0; i < datos.Count; i++)
            {
                int finalDeTitulo = datos[i].IndexOf(" - ");
                int finalDeAutor = datos[i].IndexOf(" - ", finalDeTitulo+1);
                string titulo = datos[i].Substring(0, finalDeTitulo);
                string autor = datos[i].Substring(finalDeTitulo+3, 
                    finalDeAutor-finalDeTitulo-3);
                fila = hoja.CreateRow( i+1 );
                celda = fila.CreateCell(0);
                celda.SetCellValue(titulo);
                celda = fila.CreateCell(1);
                celda.SetCellValue(autor);
            }
            for (int i = 0; i < 2; i++) hoja.AutoSizeColumn(i);

            using (FileStream stream = new FileStream("exportLibros.xls", 
                FileMode.Create, FileAccess.Write))
            {
                workbook.Write(stream);
            }

        }
    }
}
