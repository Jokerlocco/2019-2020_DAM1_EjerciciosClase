// Versión  Fecha     Por + cambios
// -------  --------  ------------------------------------
// 0.02     22-11-19  Pablo && Joel: Añadir
// 0.01     17-10-19  Cristina Francés: Menú principal

using System;

class Contabilidad
{
    struct gasto
    {
        public string descripcion;
        public string categoria;
        public double importe;
        public fecha fechas;
    }
    struct fecha
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
        gasto[] gastos = new gasto[CAPACIDAD];


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
                        gastos[cantidad].fechas.dia =
                            Convert.ToInt32(Console.ReadLine());
                        Console.Write("Mes: ");
                        gastos[cantidad].fechas.mes =
                            Convert.ToInt32(Console.ReadLine());
                        Console.Write("Año: ");
                        gastos[cantidad].fechas.anyo =
                            Convert.ToInt32(Console.ReadLine());
                        cantidad++;
                    }
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Opción todavía no disponible");
                    break;
                case 0:
                    Console.WriteLine("Hasta otra!");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

        } while (opcion != 0);
    }
}
