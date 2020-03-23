//Pablo Conde - Ej 424

using System;
using System.IO;

public class BatCsharp
{
    public static void Main()
    {
        Console.Write("Nombre del fichero: ");
        string nombre = Console.ReadLine();

        if (!File.Exists(nombre))
        {
            Console.WriteLine("Fichero no encontrado");
        }
        else
        {
            try
            {
                StreamReader input = File.OpenText(nombre);
                StreamWriter output = File.CreateText(nombre + ".cs");

                output.WriteLine("using System;");
                output.WriteLine("using System.IO;");
                output.WriteLine("using System.Diagnostics;");
                output.WriteLine("class FicheroBat {");
                output.WriteLine("  public static void Main(string[] args) {");
                output.WriteLine("    Process proc;");

                string linea;
                
                do
                {
                    linea = input.ReadLine();
                  
                    if (linea != null)
                    {
                        linea = linea.Trim();
                        int posPrimerEspacio = linea.IndexOf(" ");
                        
                        if (linea.ToUpper() == "CLS")
                        {
                            linea = "    Console.Clear();";
                        }
                        
                        else if (linea.ToUpper().StartsWith("ECHO "))
                        {
                            
                            string textToDisplay = 
                                linea.Substring(posPrimerEspacio + 1);
                            linea = "    Console.WriteLine(\""
                                + textToDisplay + "\");";
                        }
                        
                        else if (linea.ToUpper().StartsWith("CD "))
                        {
                            string variable = linea.Substring(
                                posPrimerEspacio + 1);
                            linea = "    Directory.SetCurrentDirectory(\"" 
                                + variable + "\");";
                        }
                        else
                        {
                            string otrasOrdenes = linea;
                            linea = "    proc = Process.Start(\"" 
                                + otrasOrdenes +"\"); proc.WaitForExit();";
                        }
                        output.WriteLine(linea);
                    }
                }
                while (linea != null);

                output.WriteLine("  }");
                output.WriteLine("}");

                output.Close();
                input.Close();
                Console.WriteLine("Fichero convertido a c#");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Ruta demasiado larga");
            }
            catch (IOException)
            {
                Console.WriteLine("Error I/O");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
