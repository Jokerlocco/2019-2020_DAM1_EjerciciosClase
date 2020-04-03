// Gonzalo Arques, improved by Nacho

using System;
using System.Diagnostics;

class Programa
{
    static void Main()
    {
        byte opcionElegida;
        string[] nombres = { "Bloc de Notas", "Visual Studio Code", 
            "Microsoft Edge", "Visual Studio Community", "Chrome", 
            "OneNote", "Word", "Steam", "Paint", "Geany" };
        string[] ejecutables = { "notepad.exe", "Code.exe", 
            "msedge.exe",
            "devenv.exe", "chrome.exe", "ONENOTE.EXE", "WINWORD.EXE",
            "Steam.exe", "mspaint.exe", "GeanyPortable.exe" };
        
        do
        {
            Console.Clear();
            for (int i = 0; i < nombres.Length; i++)
                Console.WriteLine( i + "- " + nombres[i]);

            Console.WriteLine();Console.WriteLine(nombres.Length+"- Salir");
            Console.WriteLine();Console.Write("Elige un programa para abrir: ");
            opcionElegida = Convert.ToByte(Console.ReadLine());

            if (opcionElegida != nombres.Length)
            {
                Console.WriteLine("Lanzando el programa deseado...");
                
                try
                {
                    Process procesoPrograma = Process.Start(ejecutables[opcionElegida]);
                    procesoPrograma.WaitForExit();
                }
                catch(Exception)
                {
                    Console.WriteLine("No se ha podido lanzar ese programa");
                    Console.ReadLine();
                }
            }
        }
        while (opcionElegida != nombres.Length);
    }
}
