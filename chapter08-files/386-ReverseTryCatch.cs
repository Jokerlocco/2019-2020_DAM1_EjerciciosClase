//Pablo Conde

using System;
using System.IO;

class InvertirFichero
{
    static void Main()
    {
      Console.Write("Nombre fichero: ");
      string nombre = Console.ReadLine();
      
      try
      {
            string[] ficheroEn = File.ReadAllLines(nombre);

            StreamWriter ficheroSal = File.CreateText(nombre + ".reversed.txt");
            for (int i = ficheroEn.Length - 1; i >= 0; i--)
            {
                ficheroSal.WriteLine(ficheroEn[i]);
            }     
            ficheroSal.Close();
       }
       
       catch (FileNotFoundException)
       {
           Console.WriteLine("Archivo no encontrado");
       }
       
       catch (PathTooLongException)
       {
           Console.WriteLine("Ruta demasiado larga");
       }
       
       catch (IOException)
       {
           Console.WriteLine("No se ha podido escribir");
       }
       
       catch (Exception exp)
       {
           Console.WriteLine(exp);
       }          
    }
}
