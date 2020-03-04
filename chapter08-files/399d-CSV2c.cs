// Sergio Gumpert

using System;
using System.IO;
class Ejercicio
{
    static void Main()
    {
        Console.WriteLine("Ruta?");
        string path = Console.ReadLine();
        if (!File.Exists(path))
        {
            Console.WriteLine("Archivo no encontrado.");
        }
        else
        {
            try
            {
                StreamReader fich = File.OpenText(path);


                string fraseayuda;

                StreamWriter fich2 = File.CreateText("SVC.txt");
                string frase;
                    do
                    {
                        frase = fich.ReadLine();
                        if (frase != null)
                        {
                            int pos1 = 0;
                            int pos2 = 0;
                            frase = frase.Replace(";", "");
                            for (int i = 0; i < 3; i++)
                            {
                                pos1 = frase.IndexOf('"');
                                pos2 = frase.IndexOf('"', pos1 + 1);
                                fraseayuda = frase.Substring(pos1 + 1, pos2 - 1);
                                frase = frase.Remove(pos1, pos2 + 1);
                                fich2.WriteLine(fraseayuda);
                            }
                            fich2.WriteLine(frase);
                    }
                    } while (frase != null);
                fich.Close();
                fich2.Close();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}
