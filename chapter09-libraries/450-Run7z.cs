//Kiko
using System;
using System.Diagnostics;

class ComprimirArchivo
{
    static void Main(string [] args)
    {
        Process proceso;        
        if(args.Length > 0)
        {
            string aComprimir 
                ="a Comprimido " + args[0] + " -p1234";
                
            proceso = Process.Start("7za.exe", aComprimir);
            proceso.WaitForExit();
            
            if(proceso.ExitCode== 0)
            {
                Console.WriteLine("Compresión realizada con éxito.");
            }
            
            else
            {
                Console.WriteLine("Ups... parece que algo ha ido mal..");
            }
        }
        
        else
        {
            Console.WriteLine("Introduce la ruta del archivo a comprimir.");
        }
    }
}
