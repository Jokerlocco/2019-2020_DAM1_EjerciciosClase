// Joel Martinez

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Programa : IComparable<Programa>
{
    public string Nombre { get; set; }
    public string SistOperativo { get; set; }
    public double TamanyoCopia { get; set; }
    public string Ubicacion { get; set; }

    public Programa(string nombre, string sistOperativo,
        double tamanyoCopia, string ubicacion)
    {
        this.Nombre = nombre;
        this.SistOperativo = sistOperativo;
        this.TamanyoCopia = tamanyoCopia;
        this.Ubicacion = ubicacion;
    }

    public int CompareTo(Programa p)
    {
        return this.Nombre.CompareTo(p.Nombre);
    }

    public override string ToString()
    {
        return "Nombre: " + Nombre + " - Sistema Operativo: " + SistOperativo
            + " - Tamaño de la copia de seguridad: " + TamanyoCopia
            + " - Ubicacion de la copia: " + Ubicacion;
    }
}

class ListaDeProgramasSerializada
{
    static void Main()
    {
        List<Programa> lista = new List<Programa>();
        byte opcion;

        if (File.Exists("programa.dat"))
        {
            IFormatter formatterI = new BinaryFormatter();
            FileStream streamI = new FileStream("programa.dat",
            FileMode.Open, FileAccess.Read, FileShare.Read);
            lista = (List<Programa>)formatterI.Deserialize(streamI);
            streamI.Close();
        }
        
        do
        {
            Console.WriteLine("1 - Añadir un nuevo programa");
            Console.WriteLine("2 - Mostrar los datos de un programa");
            Console.WriteLine("3 - Modificar los datos de un programa por posicion");
            Console.WriteLine("4 - Eliminar un programa por posicion");
            Console.WriteLine("5 - Insertar en una cierta posicion");
            Console.WriteLine("6 - Ordenar alfabeticamente por nombre");
            Console.WriteLine("7 - Salir");
            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Sistema operativo: ");
                    string sistOperativo = Console.ReadLine();
                    Console.Write("Tamaño de la copia de seguridad (en MB): ");
                    double tamanyoCopia = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ubicacion de la copia de seguridad: ");
                    string ubicacion = Console.ReadLine();

                    lista.Add(new Programa(
                        nombre, sistOperativo, tamanyoCopia, ubicacion));
                    break;

                case 2:
                    if (lista.Count > 0)
                    {
                        Console.Write("Fragmento del nombre: ");
                        string fragmento = Console.ReadLine();
                        bool unoAlMenos = false;

                        for (int i = 0; i < lista.Count; i++)
                        {
                            if (lista[i].Nombre.Contains(fragmento))
                            {
                                Console.WriteLine(lista[i]);
                                unoAlMenos = true;
                            }
                        }
                        if (!unoAlMenos)
                            Console.WriteLine("No se ha encontrado ningun " +
                                "programa que contenga ese framento de nombre");
                    }
                    else
                        Console.WriteLine("No hay ningun programa almacenado");
                    break;

                case 3:
                    Console.Write("Numero de programa: ");
                    int posicion = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (posicion > lista.Count)
                        Console.WriteLine("No hay tantos programas almacenados");
                    else
                    {
                        // TO DO...
                    }
                    break;

                case 4:
                    Console.Write("Numero de programa: ");
                    int posicionBorrar = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (posicionBorrar > lista.Count)
                        Console.WriteLine("No hay tantos programas almacenados");
                    else
                    {
                        Console.WriteLine("Vas a borrar este programa: ");
                        Console.WriteLine(lista[posicionBorrar]);
                        lista.RemoveAt(posicionBorrar);
                        Console.WriteLine("Programa borrado correctamente");
                    }
                    break;

                case 5:
                    Console.Write("Posicion a insertar: ");
                    int posicionInsert = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.Write("Nombre: ");
                    string nombrePos = Console.ReadLine();
                    Console.Write("Sistema operativo: ");
                    string sistOperativoPos = Console.ReadLine();
                    Console.Write("Tamaño de la copia de seguridad (en MB): ");
                    double tamanyoCopiaPos = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ubicacion de la copia de seguridad: ");
                    string ubicacionPos = Console.ReadLine();
                    lista.Insert(posicionInsert, new Programa(
                        nombrePos, sistOperativoPos, tamanyoCopiaPos, ubicacionPos));
                    break;

                case 6:
                    if (lista.Count == 0)
                        Console.WriteLine("La lista esta vacia");
                    else
                    {
                        lista.Sort();
                        Console.WriteLine("Lista ordenada correctamente");
                    }
                    break;

                case 7:
                    Console.WriteLine("Hasta la proxima!");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
        while (opcion != 7);

        IFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream("programa.dat", FileMode.Create,
                FileAccess.Write, FileShare.None);
        formatter.Serialize(stream, lista);
        stream.Close();
    }
}
