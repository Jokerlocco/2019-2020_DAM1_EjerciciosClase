// Versión  Fecha     Por + cambios
// -------  --------  ------------------------------------
// 0.05     22-11-19  Nacho: Guardar y cargar en fichero
// 0.04     22-11-19  Abraham garcía - Ruth Martinez - Pablo Conde: Informes
// 0.03     22-11-19  Pablo Vigara && Joel Martínez: Buscar
// 0.02     22-11-19  Pablo Vigara && Joel Martínez: Añadir
// 0.01     17-10-19  Cristina Francés: Menú principal

using System;
using System.IO;

class Contabilidad
{
    struct tipoGasto
    {
        public string descripcion;
        public string categoria;
        public double importe;
        public tipoFecha fecha;
    }

    struct tipoFecha
    {
        public int dia;
        public int mes;
        public int anyo;
    }


    static void Main()
    {
        byte opcion;
        const int CAPACIDAD = 1000;
        int cantidad = 0;
        tipoGasto[] gastos = new tipoGasto[CAPACIDAD];

        // Carga de datos
        if (File.Exists("gastos.txt"))
        {
            string[] datosDelFichero = File.ReadAllLines("gastos.txt");
            int pos = 1;
            cantidad = Convert.ToInt32(datosDelFichero[0]);
            for (int i = 0; i < cantidad; i++)
            {
                gastos[i].descripcion = datosDelFichero[pos++];
                gastos[i].categoria = datosDelFichero[pos++];
                gastos[i].importe = Convert.ToDouble(datosDelFichero[pos++]);
                string[] fechaEnFichero = datosDelFichero[i].Split();
                gastos[i].fecha.dia = Convert.ToInt32(fechaEnFichero[0]);
                gastos[i].fecha.mes = Convert.ToInt32(fechaEnFichero[0]);
                gastos[i].fecha.anyo = Convert.ToInt32(fechaEnFichero[0]);
            }
        }


        do
        {
            Console.WriteLine("1. Añadir un gasto ");
            Console.WriteLine("2. Ver informes ");
            Console.WriteLine("3. Buscar ");
            Console.WriteLine("0. Salir ");
            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (cantidad >= CAPACIDAD)
                    {
                        Console.WriteLine("Base de datos llena");
                    }
                    else
                    {
                        Console.Write("Descripcion: ");
                        gastos[cantidad].descripcion = Console.ReadLine();
                        Console.Write("Categoria: ");
                        gastos[cantidad].categoria = Console.ReadLine();
                        Console.Write("Importe: ");
                        gastos[cantidad].importe =
                            Convert.ToDouble(Console.ReadLine());
                        Console.Write("Dia: ");
                        gastos[cantidad].fecha.dia =
                            Convert.ToInt32(Console.ReadLine());
                        Console.Write("Mes: ");
                        gastos[cantidad].fecha.mes =
                            Convert.ToInt32(Console.ReadLine());
                        Console.Write("Año: ");
                        gastos[cantidad].fecha.anyo =
                            Convert.ToInt32(Console.ReadLine());
                        cantidad++;
                    }
                    break;

                case 2:
                    Console.WriteLine("Elige opción ");
                    Console.WriteLine("1. Buscar por categoría");
                    Console.WriteLine("2. Buscar por mes");
                    Console.WriteLine("3. Buscar entre dos fechas");

                    string opcion2 = Console.ReadLine();

                    if (opcion2 == "1")
                    {
                        Console.Write("Categoría a buscar");
                        string buscarCategoria = Console.ReadLine();

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (gastos[i].categoria.ToUpper()
                                == buscarCategoria.ToUpper())
                            {
                                Console.WriteLine("descripción: " + gastos[i].descripcion);
                                Console.WriteLine("Categoria: " + gastos[i].categoria);
                                Console.WriteLine("Importe: " + gastos[i].importe);
                                Console.WriteLine("Fecha: " + gastos[i].fecha.dia + "/"
                                 + gastos[i].fecha.mes + "/" + gastos[i].fecha.anyo);
                            }

                        }
                    }

                    else if (opcion2 == "2")
                    {
                        Console.Write("Mes a buscar: ");
                        int buscarMes = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (buscarMes == gastos[i].fecha.mes)
                            {
                                Console.WriteLine("descripción: " + gastos[i].descripcion);
                                Console.WriteLine("Categoria: " + gastos[i].categoria);
                                Console.WriteLine("Importe: " + gastos[i].importe);
                                Console.WriteLine("Fecha: " + gastos[i].fecha.dia + "/"
                                     + gastos[i].fecha.mes + "/" + gastos[i].fecha.anyo);
                            }
                        }
                    }
                    else if (opcion2 == "3")
                    {
                        Console.WriteLine("Opción no disponible");
                    }
                    else
                        Console.WriteLine("Opción incorrecta");
                    break;

                case 3:
                    if (cantidad == 0)
                    {
                        Console.WriteLine("No hay suficientes datos donde buscar");
                    }
                    else
                    {
                        bool found = false;
                        Console.Write("Introduce el texto que buscar: ");
                        string busqueda = Console.ReadLine();

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (gastos[i].descripcion.ToLower().Contains(
                                busqueda.ToLower()))
                            {
                                Console.WriteLine((i + 1) + ": "
                                    + gastos[i].descripcion + " - "
                                    + gastos[i].categoria + " - "
                                    + gastos[i].importe + " - "
                                    + gastos[i].fecha.dia + "/"
                                    + gastos[i].fecha.mes + "/"
                                    + gastos[i].fecha.anyo);
                                found = true;
                            }
                        }
                        if (!found)
                            Console.WriteLine("No encontrado");
                    }

                    break;
                case 0:
                    Console.WriteLine("Hasta otra!");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

        } while (opcion != 0);

        // Rellenar array temporal y guardar
        string[] datosComoArray = new string[cantidad * 4 + 1];
        datosComoArray[0] = cantidad.ToString();
        int posicion = 1;
        for (int i = 0; i < cantidad; i++)
        {
            datosComoArray[posicion++] = gastos[i].descripcion;
            datosComoArray[posicion++] = gastos[i].categoria;
            datosComoArray[posicion++] = gastos[i].importe.ToString();
            datosComoArray[posicion++] = gastos[i].fecha.dia + "-" +
                gastos[i].fecha.mes + "-" + gastos[i].fecha.anyo;
        }
        File.WriteAllLines("gastos.txt", datosComoArray);
    }
}
