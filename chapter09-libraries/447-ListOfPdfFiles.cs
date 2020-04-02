//Sergio Gumpert

using System;
using System.IO;

class Ejercicio
{
    static void Main()
    {
        Console.WriteLine("Nombre del nuevo archivo?");
        string nuevoArchivo = Console.ReadLine();
        try
        {
            DirectoryInfo dir = new DirectoryInfo(".");
            FileInfo[] archivos = dir.GetFiles("*.pdf");

            StreamWriter html = new StreamWriter(nuevoArchivo + ".html");

            html.WriteLine("<html>");
            html.WriteLine("<body>");
            html.WriteLine("<ul>");

            foreach (FileInfo fichero in archivos)
            {
                html.WriteLine("<li><a href=\"" + 
                    fichero.Name+"\">"+fichero.Name+"</a> ("+
                    fichero.Length/1024 + " KB) </li>");
            }
            html.WriteLine("</ul>");
            html.WriteLine("</body>");
            html.WriteLine("</html>");
            html.Close();
        }
        catch (Exception e) { Console.WriteLine(e.Message); }
    }
}
