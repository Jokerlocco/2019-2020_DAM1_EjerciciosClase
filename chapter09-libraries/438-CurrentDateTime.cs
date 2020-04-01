// Araceli Yáñez Muñoz
using System;
using System.IO;

class FechaHoraActual
{
    static void Main(string[] args)
    {
        string[] mes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo",
            "Junio", "Julio", "Agosto", "Septiembre", "Octubre",
            "Noviembre", "Diciembre" };
        DateTime ahora = DateTime.Now;
        Console.WriteLine("Son las " 
            + ahora.Hour.ToString("00") + ":" + ahora.Minute.ToString("00") + 
            " del " + ahora.Day + " de " + mes[ahora.Month-1]);
        
    }
}
