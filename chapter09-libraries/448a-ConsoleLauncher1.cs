// Gonzalo Arques

using System;
using System.Diagnostics;

class Programa
{
    static void Main()
    {
        byte opcionElegida;
        string[] listaPrograma = { "notepad.exe", "Code.exe", "msedge.exe",
            "devenv.exe", "chrome.exe", "ONENOTE.EXE", "WINWORD.EXE",
            "Steam.exe", "mspaint.exe", "GeanyPortable.exe" };
        
        do
        {
            Console.Clear();
            Console.WriteLine("0- Notepad");
            Console.WriteLine("1- Visual Studio Code");
            Console.WriteLine("2- Microsoft Edge");
            Console.WriteLine("3- Visual Studio Community");
            Console.WriteLine("4- Chrome");
            Console.WriteLine("5- OneNote");
            Console.WriteLine("6- Word");
            Console.WriteLine("7- Steam");
            Console.WriteLine("8- Paint");
            Console.WriteLine("9- Geany");
            Console.WriteLine();Console.WriteLine("10- Salir");
            Console.WriteLine();Console.Write("Elige un programa para abrir: ");
            opcionElegida = Convert.ToByte(Console.ReadLine());

            if (opcionElegida != 10)
            {
                Console.WriteLine("Lanzando el programa deseado...");
                
                try
                {
                    Process procesoPrograma = Process.Start(listaPrograma[opcionElegida]);
                    procesoPrograma.WaitForExit();
                }
                catch(Exception)
                {
                    Console.WriteLine("No se ha podido lanzar ese programa");
                    Console.ReadLine();
                }
            }
        }
        while (opcionElegida != 10);
    }
}
