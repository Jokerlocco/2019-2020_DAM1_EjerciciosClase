
//Kiko
using System;
using System.Diagnostics;

class DesComprimirArchivo
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            int pass = 1200;
            bool correcta = false;
            Console.Write("Probando contraseñas del documento "+args[0]+"... ");
            while (pass < 9999 && !correcta)
            {
                string passActual = pass.ToString("0000");
                Console.Write( passActual + " ");
                string aDesComprimir
                = "x " + args[0] + " -y -p" + passActual;
                
                ProcessStartInfo procInfo =
                    new ProcessStartInfo("7za.exe", aDesComprimir);
                procInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Process p = Process.Start(procInfo);
                p.WaitForExit();

                if (p.ExitCode == 0)
                {
                    Console.WriteLine("La contraseña es:" + passActual);
                    correcta = true;
                }
                pass++;
            }
            
            if(!correcta)
            {
                Console.WriteLine("Contraseña no obtenida.");
            }
        }
        else
        {
            Console.WriteLine("Introduce la ruta del archivo a comprimir.");
        }
    }
}
