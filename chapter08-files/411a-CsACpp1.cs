using System;
using System.IO;

class CsACpp
{
    static void Main()
    {
        StreamReader entrada = new StreamReader("1.cs");
        StreamWriter salida = new StreamWriter("1.cpp");

        string linea = entrada.ReadLine();
        while(linea != null)
        {
            if (linea.Trim().StartsWith("Console.Write("))
            {
                linea = linea.Replace("Console.Write(", "cout << ");
                //linea = linea.Replace(");", ";");
                int posicUltParentesis = linea.LastIndexOf(")");
                linea = linea.Remove(posicUltParentesis, 1);
            }
            else if (linea.Trim().StartsWith("Console.WriteLine("))
            {
                linea = linea.Replace("Console.WriteLine(", "cout << ");
                int posicUltParentesis = linea.LastIndexOf(")");
                linea = linea.Remove(posicUltParentesis, 1);
                linea = linea.Insert(posicUltParentesis, " << endl");
            }
            else if (linea.Contains("Console.ReadLine("))
            {
                int espacios = 0;
                int i = 0;
                while (linea[i] == ' ')
                {
                    espacios++;
                    i++;
                }
                string[] fragmentos = linea.Trim().Split();
                linea = new string(' ', espacios) 
                    + "cin >> " + fragmentos[0] +";";
            }
            else if (linea.Trim().StartsWith("using "))
            {
                linea = @"#include <iostream>
using namespace std;";
            }
            else if ((linea.Trim().StartsWith("class"))
                || (linea.Trim().StartsWith("public class"))
                || (linea.StartsWith("{"))
                || (linea.StartsWith("}"))
                )
            {
                linea = "";
            }
            else if (linea.Contains("static void Main"))
            {
                linea = "int main()";
            }

            if (linea.StartsWith("    "))
                linea = linea.Substring(4);
            if (linea.StartsWith("}"))
                linea = @"    return 0;
}";
            salida.WriteLine(linea);
            linea = entrada.ReadLine();
        }
        
        salida.Close();
        entrada.Close();
    }
}
