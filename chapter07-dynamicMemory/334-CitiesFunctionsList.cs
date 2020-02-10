using System;
using System.Collections.Generic;

class EjercicioCiudades
{
    struct Ciudad
    {
        public string nombre;
        public string pais;
        public ulong poblacion;
    }


    //const int MAX = 20000;
    //static Ciudad[] ciudades = new Ciudad[MAX];
    // static int cantidad = 0;
    static List<Ciudad> ciudades = new List<Ciudad>();

    static void Main()
    {
        string opcion;

        do
        {
            MostrarMenu();
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": Anyadir(); break;
                case "2": Mostrar(); break;
                case "3": Buscar(); break;
                case "4": Editar(); break;
                case "5": Insertar(); break;
                case "6": Eliminar(); break;
                case "7": Ordenar(); break;
                case "8": Revisar(); break;
                case "q":
                case "Q":
                    Console.WriteLine("Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Elige una opción válida");
                    break;
            }

        } while (opcion != "q" && opcion != "Q");
    }


    static void Anyadir()
    {
        Console.WriteLine("Añadiendo ciudad número " + 
            (ciudades.Count + 1) +": ");
        Ciudad c;
        do
        {
            Console.Write("Nombre: ");
            c.nombre = Console.ReadLine();
            if (c.nombre == "")
                Console.WriteLine("El nombre no puede estar vacío");
        } while (c.nombre == "");

        do
        {
            Console.Write("País: ");
            c.pais = Console.ReadLine();
            if (c.pais == "")
                Console.WriteLine("El pais no puede estar vacío");
        } while (c.pais == "");

        string poblacion;
        Console.Write("Población: ");
        poblacion = Console.ReadLine();
        if (poblacion == "")
            c.poblacion = 0;
        else
            c.poblacion = Convert.ToUInt64(poblacion);

        ciudades.Add(c);
    }


    static void Mostrar()
    {
        if (ciudades.Count == 0)
            Console.WriteLine("Lista vacía");
        else
        {
            for (int i = 0; i < ciudades.Count; i++)
            {
                string nombre = ciudades[i].nombre;
                if (nombre.Length > 20)
                    nombre = nombre.Remove(19) + "...";

                string pais = ciudades[i].pais;
                if (pais.Length > 40)
                {
                    pais = (ciudades[i].pais.
                        Remove(40));
                    while (ciudades[i].pais.Contains(" "))
                        pais = ciudades[i].pais.
                            Replace(" ", "");
                }
                Console.Write((i + 1) + "- " + nombre +
                    ", " + pais);
                Console.WriteLine();

                if (i % 24 == 23)
                {
                    string pulsar = Console.ReadLine();
                    if (pulsar == "fin")
                        i = ciudades.Count - 1;
                }
            }
        }
    }


    static void Editar()
    {
        if (ciudades.Count == 0)
            Console.WriteLine("Lista vacía");
        else
        {
            bool salir = false;
            int reg;
            do
            {
                salir = false;
                Console.Write("Introduce el registro que quieres editar.");
                Console.WriteLine(" 0 para salir");
                reg = Convert.ToInt32(Console.ReadLine());

                if (reg != 0)
                {
                    if (reg > ciudades.Count)
                        Console.WriteLine("Registro incorrecto");
                    else
                    {
                        reg--;
                        Console.WriteLine(" Los datos que pertenecen a ese registro son: ");
                        Ciudad c = ciudades[reg];

                        Console.WriteLine("Nombre: " + c.nombre);
                        Console.WriteLine("Pulsa INTRO para cancelar modificación");
                        string nuevoNombre = Console.ReadLine();
                        if (nuevoNombre != "")
                        {
                            while (nuevoNombre.Contains("  "))
                                nuevoNombre = nuevoNombre.Replace("  ", " ");
                            nuevoNombre = nuevoNombre.TrimStart();
                            nuevoNombre = nuevoNombre.TrimEnd();
                            c.nombre = nuevoNombre;
                        }
                        Console.WriteLine();

                        Console.WriteLine("Pais: " + c.pais);
                        Console.WriteLine("Pulsa INTRO para cancelar modificación");
                        string nuevoPais = Console.ReadLine();
                        if (nuevoPais != "")
                        {
                            while (nuevoPais.Contains("  "))
                                nuevoPais = nuevoPais.Replace("  ", " ");
                            nuevoPais = nuevoPais.TrimStart();
                            nuevoPais = nuevoPais.TrimEnd();
                            c.pais = nuevoPais;
                        }
                        Console.WriteLine();

                        Console.WriteLine("Población: " + c.poblacion);
                        Console.WriteLine("Pulsa INTRO para cancelar modificación");
                        string nuevaPob = Console.ReadLine();
                        if (nuevaPob != "")
                        {
                            while (nuevaPob.Contains("  "))
                                nuevaPob = nuevaPob.Replace("  ", " ");
                            nuevaPob = nuevaPob.TrimStart();
                            nuevaPob = nuevaPob.TrimEnd();
                            c.poblacion = Convert.ToUInt64(nuevaPob);
                        }
                        Console.WriteLine();
                        ciudades[reg] = c;
                        salir = true;
                    }
                }
                else
                    Console.WriteLine("Saliendo...");
            } while (reg != 0 && !salir);
        }
    }


    static void Buscar()
    {
        if (ciudades.Count == 0)
            Console.WriteLine("Lista vacía");
        else
        {
            Console.Write("Texto a buscar: ");
            string buscar = Console.ReadLine();

            for (int i = 0; i < ciudades.Count; i++)
            {
                if (ciudades[i].nombre.ToUpper().Contains(buscar.ToUpper()) ||
                    ciudades[i].pais.ToUpper().Contains(buscar.ToUpper()))
                {
                    Console.Write((i + 1) + "- " + ciudades[i].nombre +
                        ", " + ciudades[i].pais);
                    if (ciudades[i].poblacion == 0)
                        Console.WriteLine(" - Población desconocida");
                    else
                        Console.WriteLine(" - " + ciudades[i].poblacion);

                    if (i % 24 == 23)
                        Console.ReadLine();
                }
            }
        }
    }


    static void Eliminar()
    {
        if (ciudades.Count == 0)
            Console.WriteLine("Lista vacía");
        else
        {
            Console.Write("Introduce registro a borrar :");
            int regBorrar = Convert.ToInt32(Console.ReadLine()) - 1;
            if (regBorrar >= ciudades.Count)
                Console.WriteLine("No existen tantos registros");
            else
            {
                Console.WriteLine("Se va a eliminar el registro " +
                (regBorrar + 1) + "- " + ciudades[regBorrar].nombre + ", " +
                ciudades[regBorrar].pais + ", " + ciudades[regBorrar].poblacion);
                Console.Write("¿Estás seguro? (s/n)");
                char decision = Convert.ToChar(Console.ReadLine());
                if (decision == 'n')
                    Console.WriteLine("El registro no se ha borrado");
                else if (decision == 's')
                {
                    ciudades.RemoveAt(regBorrar);
                    Console.WriteLine("La posición " + (regBorrar + 1) + " se ha borrado");
                }
                else
                    Console.WriteLine("Introduce una opción válida");
            }
        }
    }


    static void Insertar()
    {
        if (ciudades.Count == 0)
            Console.WriteLine("Lista vacía");
        else
        {
            Console.Write("Introduce posición donde insertar: ");
            int regNuevo = Convert.ToInt32(Console.ReadLine()) - 1;
            if (regNuevo >= ciudades.Count)
                Console.WriteLine("No existen tantos registros");
            else
            {
                Console.WriteLine("Insertando registro en la posición " + 
                    (regNuevo + 1) + ": ");
                Ciudad c;
                do
                {
                    Console.Write("Nombre: ");
                    c.nombre = Console.ReadLine();
                    if (c.nombre == "")
                        Console.WriteLine("El nombre no puede estar vacío");
                } while (c.nombre == "");

                do
                {
                    Console.Write("País: ");
                    c.pais = Console.ReadLine();
                    if (c.pais == "")
                        Console.WriteLine("El pais no puede estar vacío");
                } while (c.pais == "");

                string poblacion;
                Console.Write("Población: ");
                poblacion = Console.ReadLine();
                if (poblacion == "")
                    c.poblacion = 0;
                else
                    c.poblacion = Convert.ToUInt64(poblacion);

                ciudades.Insert(regNuevo, c);
            }
        }
    }


    static void Ordenar()
    {
        if (ciudades.Count == 0)
            Console.WriteLine("Lista vacía");
        else
        {
            Console.Write("¿Por nombre de ciudad o país? (c/p)");
            char cop = Convert.ToChar(Console.ReadLine());
            if (cop == 'c')
            {
                for (int i = 0; i < ciudades.Count - 1; i++)
                {
                    for (int j = i + 1; j < ciudades.Count; j++)
                    {
                        if (ciudades[i].nombre.ToUpper().CompareTo(
                            ciudades[j].nombre.ToUpper()) > 0)
                        {
                            Ciudad aux = ciudades[i];
                            ciudades[i] = ciudades[j];
                            ciudades[j] = aux;
                        }
                    }
                }
                Console.WriteLine("Ordenado con éxito");
            }
            else if (cop == 'p')
            {
                for (int i = 0; i < ciudades.Count - 1; i++)
                {
                    for (int j = i + 1; j < ciudades.Count; j++)
                    {
                        if (ciudades[i].pais.ToUpper().CompareTo(
                            ciudades[j].pais.ToUpper()) > 0)
                        {
                            Ciudad aux = ciudades[i];
                            ciudades[i] = ciudades[j];
                            ciudades[j] = aux;
                        }
                    }
                }
                Console.WriteLine("Ordenado con éxito");
            }
            else
                Console.WriteLine("Introduce una opción válida");
        }
    }


    static void Revisar()
    {
        if (ciudades.Count == 0)
            Console.WriteLine("Lista vacía");
        else
        {
            Console.WriteLine("Corrigiendo los siguientes registros: ");
            for (int i = 0; i < ciudades.Count; i++)
            {
                if ((ciudades[i].nombre.Contains(",,") || ciudades[i].pais.Contains(",,")) ||
                    (ciudades[i].nombre.Contains("..") || ciudades[i].pais.Contains("..")))
                {
                    Console.WriteLine("Ciudad: " + ciudades[i].nombre +
                    ", Pais: " + ciudades[i].pais + ", Población: " +
                    ciudades[i].poblacion);

                    Ciudad c = ciudades[i];
                    while ((c.nombre.Contains(",,") || c.pais.Contains(",,")) ||
                        (c.nombre.Contains("..") || c.pais.Contains("..")))
                    {
                        c.nombre = c.nombre.Replace(",,", ",");
                        c.nombre = c.nombre.Replace("..", ".");
                        c.pais = c.pais.Replace(",,", ",");
                        c.pais = c.pais.Replace("..", ".");
                    }
                    ciudades[i] = c;
                }
            }
        }
    }


    static void MostrarMenu()
    {
        Console.WriteLine("1- Añadir ciudad");
        Console.WriteLine("2- Mostrar ciudades");
        Console.WriteLine("3- Buscar ciudades");
        Console.WriteLine("4- Editar registro");
        Console.WriteLine("5- Insertar registro");
        Console.WriteLine("6- Eliminar registro");
        Console.WriteLine("7- Ordenar datos");
        Console.WriteLine("8- Revisar errores ortográficos");
        Console.WriteLine("Q- Salir");
        Console.WriteLine();
        Console.Write("Elige una opción: ");
    }

}
