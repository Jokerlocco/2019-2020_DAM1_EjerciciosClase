//Daniel Contreras
/*
 * Muestra información sobre el sistema: versión de Windows,
 * versión de Punto Net, nombre de usuario actual, carpeta de documentos
 * y espacio libre y espacio total en todas las particiones de disco, medido en GB.
 */

using System;
using System.Diagnostics;
using System.IO;

class Ejercicio
{ 
    static void Main()    {
        Console.WriteLine("Nombre de usuario: {0}", Environment.UserName);
     
        Console.WriteLine("Versión del S.O.: {0}",
        System.Convert.ToString(Environment.OSVersion));

        Console.WriteLine("Versión de .Net: {0}",
        Environment.Version.ToString());

        String[] discos = Environment.GetLogicalDrives();
        Console.WriteLine("Unidades lógicas: {0}",
        String.Join(" - ", discos));
        
        Console.WriteLine("Carpeta de documentos: {0}",
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

        Console.WriteLine("Espacio libre: {0}", 
        Environment.GetFolderPath(Environment.SpecialFolder.System));

        DriveInfo[] allDiscos = DriveInfo.GetDrives();

        foreach (DriveInfo d in allDiscos)
        {
            Console.WriteLine("Disco {0}", d.Name);
            Console.WriteLine("  Tipo de disco: {0}", d.DriveType);
            if (d.IsReady)
            {
                Console.WriteLine("  Etiqueta volumen: {0}", d.VolumeLabel);
                Console.WriteLine("  Sistema archivos: {0}", d.DriveFormat);

                /*
                Console.WriteLine(
                    "  Espacio disponible del usuario:{0, 19} Mb",
                    d.AvailableFreeSpace / 1000000);

                Console.WriteLine(
                    "  Espacio disponible total:          {0, 15} Mb",
                    d.TotalFreeSpace / 1000000);

                Console.WriteLine(
                    "  Tamaño total del disco:            {0, 15} Mb ",
                    d.TotalSize / 1000000);            
                */

                Console.WriteLine(
                    "  Libre: {0} GB de {1} GB ({2} %)",
                    d.AvailableFreeSpace / 1024 / 1024 / 1024, 
                    d.TotalSize  / 1024 / 1024 / 1024,
                    (int) (d.AvailableFreeSpace * 100 / d.TotalSize));
            }
        }
    }}
