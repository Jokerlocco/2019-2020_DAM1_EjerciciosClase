//Pablo Conde

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

class CochesSQLite
{
    static SQLiteConnection conexion;

    public CochesSQLite()
    {
        AbrirBD();
    }

    private void AbrirBD()
    {
        if(!File.Exists("coches.sqlite"))
        {
            conexion = new SQLiteConnection(
                "Data Source=coches.sqlite;Version=3;" +
                "New=True;Compress=True;");
            conexion.Open();
            string creacion = "create table coches (" +
            " marca varchar(20) primary key, modelo varchar(30)," +
            " potencia numeric(3));";
            SQLiteCommand cmd = new SQLiteCommand(creacion, conexion);
            cmd.ExecuteNonQuery();
        }
        else
        {
            conexion = new SQLiteConnection(
                "Data Source=coches.sqlite;Version=3;" +
                "New=False;Compress=True;");
            conexion.Open();
        }
    }

    public static void CerrarBD()
    {
        conexion.Close();
    }

    public bool InsertarDatos(string marca, string modelo, int potencia)
    {
        string insercion;
        SQLiteCommand cmd;
        int cantidad;

        try
        {
            insercion = "insert into coches " +
                "VALUES ('" + marca + "','" + modelo + "','" + potencia + "')";
            cmd = new SQLiteCommand(insercion, conexion);
            cantidad = cmd.ExecuteNonQuery();
            if (cantidad < 1)
                return false;
        }
        catch(Exception e)
        {
            return false;
        }
        return true;
    }

    public List<string> LeerDatos()
    {
        List<string> resultado = new List<string>();
        string consulta = "select * from coches order by marca";
        SQLiteCommand cmd = new SQLiteCommand(consulta, conexion);
        SQLiteDataReader datos = cmd.ExecuteReader();
        int contador = 0;
        while (datos.Read())
        {
            contador++;
            string marca = Convert.ToString(datos[0]);
            string modelo = Convert.ToString(datos[1]);
            int potencia = Convert.ToInt32(datos[2]);
          
            Console.WriteLine("Marca: " + marca + " - Modelo: "
                + modelo + "- Potencia: " + potencia + " CV");
            if (contador % 20 == 19)
            {
                Console.WriteLine();
                Console.WriteLine("Pulse una tecla para ver más datos...");
                Console.ReadLine();  
            }
                
        }
        return resultado;
    }

    public List<string> LeerBusqueda(string texto)
    {
        List<string> resultado = new List<string>();
        string consulta = "select * from coches where marca like '%" 
            + texto + "%' or modelo like '%" + texto + "%';";
        SQLiteCommand cmd = new SQLiteCommand(consulta, conexion);
        SQLiteDataReader datos = cmd.ExecuteReader();
        while (datos.Read())
        {
           
            string marca = Convert.ToString(datos[0]);
            string modelo = Convert.ToString(datos[1]);
            int potencia = Convert.ToInt32(datos[2]);

            Console.WriteLine("Marca: " + marca + " - Modelo: "
                + modelo + " - Potencia: " + potencia + " CV");
         
        }
        return resultado;
    }

    public int ModificarDatos(string marca, string nuevoModelo, 
        int nuevaPotencia)
    {
        string orden;
        SQLiteCommand cmd;
        int cantidad;

        orden = "UPDATE coches " +
            "SET modelo = '" + nuevoModelo +
            "', potencia = '" + nuevaPotencia +
            "' WHERE marca ='" + marca + "';";
        cmd = new SQLiteCommand(orden, conexion);
        cantidad = cmd.ExecuteNonQuery();
        return cantidad;
    }

    public int BorrarDatos(string marca)
    {
        string orden;
        SQLiteCommand cmd;
        int cantidad;

        orden = "DELETE from coches WHERE marca='" +
            marca + "';";
        cmd = new SQLiteCommand(orden, conexion);
        cantidad = cmd.ExecuteNonQuery();
        return cantidad;
    }

    public void ExportarCSV()
    {
        
        string consulta = "select * from coches";
        SQLiteCommand cmd = new SQLiteCommand(consulta, conexion);
        SQLiteDataReader datos = cmd.ExecuteReader();
        try
        {
            StreamWriter fichero = new StreamWriter("coches.csv");
            while (datos.Read())
            {
                string marca = Convert.ToString(datos[0]);
                string modelo = Convert.ToString(datos[1]);
                int potencia = Convert.ToInt32(datos[2]);

                fichero.WriteLine("\"" + marca + "\","
                    + "\"" + modelo + "\"," + "\"" + potencia + "\"");
            }
            fichero.Close();
            Console.WriteLine("Fichero coches.csv creado correctamente.");
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

class ColeccionCoches
{
    static void Main(string[] args)
    {
        CochesSQLite coleccion = new CochesSQLite();
        string opcion;

        do
        {
            Console.WriteLine("Elige una opción...");
            Console.WriteLine("1.- Añadir nuevo dato");
            Console.WriteLine("2.- Ver datos");
            Console.WriteLine("3.- Buscar en los datos");
            Console.WriteLine("4.- Borrar un dato");
            Console.WriteLine("5.- Modificar un dato");
            Console.WriteLine("6.- Exportar a formato CSV");
            Console.WriteLine("0.- Salir");

            opcion = Console.ReadLine();

            switch(opcion)
            {
                case "1": //Añadir
                    Console.Write("¿Marca a añadir?: ");
                    string marca = Console.ReadLine();
                    Console.Write("¿Modelo?: ");
                    string modelo = Console.ReadLine();
                    Console.Write("¿Potencia?: ");
                    int potencia = Convert.ToInt32(Console.ReadLine());
                    coleccion.InsertarDatos(marca, modelo, potencia);
                    break;
                case "2": //Ver
                    foreach (string dato in coleccion.LeerDatos())
                        Console.WriteLine(dato);
                    break;
                case "3": //Buscar
                    Console.Write("¿Texto a buscar? ");
                    string texto = Console.ReadLine();
                    foreach (string dato in coleccion.LeerBusqueda(texto)) 
                        Console.WriteLine(dato);
                    break;
                case "4": //Borrar
                    Console.Write("¿Marca a borrar? ");
                    string marcaBorrar = Console.ReadLine();
                    int borrados = coleccion.BorrarDatos(marcaBorrar);
                    Console.WriteLine("Datos borrados: " + borrados);
                    break;
                case "5": //Modificar
                    Console.Write("¿Marca a modificar? ");
                    string marcaModif = Console.ReadLine();
                    Console.Write("¿Nuevo modelo? ");
                    string modeloModif = Console.ReadLine();
                    Console.Write("¿Nueva potencia? ");
                    int potenciaModif = Convert.ToInt32(Console.ReadLine());
                    int modificados = coleccion.
                        ModificarDatos(marcaModif, modeloModif, potenciaModif);
                    Console.WriteLine("Datos actualizados: " + modificados);
                    break;
                case "6": //Exportar formato CSV
                    coleccion.ExportarCSV();
                    break;
                case "0": //Salir
                    Console.WriteLine("Fin del programa.");
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }
        }
        while (opcion != "0");
        CochesSQLite.CerrarBD();
    }
}

