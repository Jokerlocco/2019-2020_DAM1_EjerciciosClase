/*

insert into personas (nombre, direccion, edad) values ('smith, pedro', 'su calle', 23);
insert into personas (nombre, direccion, edad) values ('juan', 'calle cinco, 6', 24);
insert into ciudades (codigo, nombre) values ('a', 'alicante');
insert  into  dificil  ( campo1 ,  campo2, campo3, campo4 )  values  ( 1, 'dos', 3 , 'cua,tro' );

personas
nombre: smith, pedro
direccion: su calle
edad: 23

personas
nombre: juan
direccion: calle cinco, 6
edad: 24

ciudades
codigo: a
nombre: alicante
*/

using System;
using System.IO;
class SqlExtractor
{
    static void Main(string[] args)
    {
        StreamReader entrada;
        StreamWriter salida;
        string nombre, linea;

        if (args.Length != 0)
            nombre = args[0];
        else
        {
            Console.Write("Introduzca el nombre del fichero: ");
            nombre = Console.ReadLine();
        }

        if (!File.Exists(nombre))
        {
            Console.WriteLine("¡ No encontrado !");
            return;
        }

        try
        {
            entrada = File.OpenText(nombre);
            salida = File.CreateText(nombre + ".salida.txt");
            do
            {
                linea = entrada.ReadLine();
                if (linea != null)
                    ExtraerYVolcar(linea, salida);
            } while (linea != null);
            entrada.Close();
            salida.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Ruta demasiado larga");
            return;
        }
        catch (IOException e)
        {
            Console.WriteLine("Error de entrada/salida: " + e.Message);
            return;
        }
        catch (Exception e)
        {
            Console.WriteLine("Error inesperado: " + e.Message);
            return;
        }
        Console.WriteLine("Volcado terminado");
    }

    private static void ExtraerYVolcar(string linea, StreamWriter fichero)
    {
        linea = linea.Trim();
        if (!linea.StartsWith("insert"))
            return;

        // Nombre de tabla
        int posicionNombreTabla = linea.IndexOf("into ") + 4;
        int finNombreTabla = linea.IndexOf("(") - 1;

        string nombreTabla = linea.Substring(posicionNombreTabla + 1,
            finNombreTabla - posicionNombreTabla).Trim();

        // Nombres de los campos
        linea = linea.Substring(finNombreTabla + 2); // Primer paréntesis
        int finNombresCampos = linea.IndexOf(")");

        string nombresCampos = linea.Substring(0, finNombresCampos);
        nombresCampos = nombresCampos.Replace(" ", "");
        string[] campos = nombresCampos.Split(',');

        // Detalles de los valores de cada campo
        linea = linea.Substring(finNombresCampos + 1);
        int comienzoValores = linea.IndexOf("(") + 1;
        int finValores = linea.LastIndexOf(")") - 1;
        linea = linea.Substring(comienzoValores,
            finValores - comienzoValores + 1).Trim();

        string[] valores = new string[campos.Length];
        for (int i = 0; i < valores.Length; i++)
        {
            linea = linea.Trim();
            int pos = 0;
            string valorActual = "";
            if (linea[pos] == '\'') // texto
            {
                pos++;
                while (linea[pos] != '\'') // hasta comilla de cierre
                {
                    valorActual += linea[pos];
                    pos++;
                }
                valores[i] = valorActual.Trim();
            }
            else // numero
            {
                while ((pos < linea.Length) &&
                    (linea[pos] != ',')) // hasta la coma o el final
                {
                    valorActual += linea[pos];
                    pos++;
                }
                valores[i] = valorActual;
            }

            // Borramos lo que hemos leido
            linea = linea.Substring(pos);
            // Y la coma
            if (i < valores.Length - 1)
            {
                int posicionComa = linea.IndexOf(",");
                linea = linea.Substring(posicionComa + 1);
            }
        }

        // Y finalmente volcamos todo
        fichero.WriteLine(nombreTabla);
        for (int i = 0; i < campos.Length; i++)
            fichero.WriteLine(campos[i] + ": " + valores[i]);
        fichero.WriteLine();
    }
}

