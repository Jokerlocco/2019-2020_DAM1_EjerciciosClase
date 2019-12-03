// Pablo Vigara Fernandez
// "{}"

/* Crea un programa en C# que pueda almacenar hasta 10000 gastos e 
ingresos, para crear un pequeño sistema de contabilidad doméstica. Para 
cada gasto (o ingreso), debe permitir guardar los siguientes datos:

- Fecha (8 caracteres: formato AAAAMMDD)
- Descripción del gasto o ingreso
- Categoría
- Importe (positivo si es un ingreso, negativo si es un gasto)

El programa debe permitir al usuario realizar las siguientes operaciones:

1- Añadir un nuevo gasto (la fecha debe "parecer correcta": día de 01 a 
31, mes de 01 a 12, año entre 1000 y 3000). La descripción no debe 
estar vacía. No hace falta validar los demás datos.

2- Mostrar todos los gastos de una cierta categoría (por ejemplo, 
"estudios") entre dos ciertas fechas (por ejemplo entre "20110101" y 
"20111231"). Se mostrará número, fecha (en formato DD/MM/AAAA), 
descripción, categoría entre paréntesis, e importe con dos decimales, 
todo ello en la misma línea, separado por guiones. Al final de todos 
los datos se mostrará el importe total de los datos mostrados.

3- Buscar gastos que contengan un cierto texto (en la descripción o en 
la categoría, sin distinguir mayúsculas ni minúsculas). Se mostrará 
número, fecha y descripción (la descripción se mostrará truncada en el 
sexto espacio en blanco, en caso de existir seis espacios o más).

4- Modificar una ficha (pedirá el número de ficha al usuario; se 
mostrará el valor anterior de cada campo y se podrá pulsar Intro para 
no modificar alguno de los datos). Se debe avisar (pero no volver a 
pedir) si el usuario introduce un número de ficha incorrecto. No hace 
falta validar ningún dato.

5- Borrar un cierto dato, a partir del número que indique el usuario. 
Se debe avisar (pero no volver a pedir) si introduce un número 
incorrecto. Se debe mostrar la ficha que se va a borrar y pedir 
confirmación antes de proceder al borrado.

6- Ordenar los datos alfabéticamente, según fecha y (en caso de 
coincidir) descripción.

7- Normalizar descripciones: eliminar espacios finales, espacios 
iniciales y espacios duplicados. Si alguna descripción está totalmente 
en mayúsculas, se convertirá a minúsculas (excepto la primera letra, 
que se conservará en mayúsculas).

T- Terminar el uso de la aplicación (como no sabemos almacenar la 
información, los datos se perderán). */

using System;

class ContabilidadDomestica
{
    struct contabilidad
    {
        public string fecha;
        public string descripcion;
        public string categoria;
        public double importe;
    }

    static void Main()
    {
        const int MAX = 10000;
        contabilidad[] c = new contabilidad[MAX];
        char opcion;
        int cantidad = 0;

        do
        {
            Console.WriteLine("1- Añadir un nuevo gasto");
            Console.WriteLine("2- Mostrar todos los gastos de una"
                + " categoria entre dos fechas");
            Console.WriteLine("3- Buscar datos que contengan un texto");
            Console.WriteLine("4- Modificar una ficha");
            Console.WriteLine("5- Borrar un dato");
            Console.WriteLine("6- Ordenar los datos alfabéticamente");
            Console.WriteLine("7- Normalizar descripciones");
            Console.WriteLine("T- Terminar");
            opcion = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine();

            switch (opcion)
            {
                case '1':
                    if (cantidad >= MAX)
                    {
                        Console.WriteLine("Base de datos llena");
                    }
                    else
                    {
                        Console.WriteLine("Posicion nº{0}", (cantidad + 1));

                        do
                        {
                            Console.Write("Fecha (AAAAMMDD): ");
                            c[cantidad].fecha = Console.ReadLine();

                            if ((Convert.ToInt32
                                (c[cantidad].fecha.Substring(0, 4)) < 1000
                                || Convert.ToInt32
                                    (c[cantidad].fecha.Substring(0, 4)) > 3000)
                                || (Convert.ToInt32
                                    (c[cantidad].fecha.Substring(4, 2)) < 01
                                || Convert.ToInt32
                                    (c[cantidad].fecha.Substring(4, 2)) > 12)
                                || (Convert.ToInt32
                                    (c[cantidad].fecha.Substring(6, 2)) < 01
                                || Convert.ToInt32
                                    (c[cantidad].fecha.Substring(6, 2)) > 31))
                            {
                                Console.WriteLine("Fecha incorrecta");
                            }
                        }
                        while ((Convert.ToInt32
                                (c[cantidad].fecha.Substring(0, 4)) < 1000
                                || Convert.ToInt32
                                    (c[cantidad].fecha.Substring(0, 4)) > 3000)
                                || (Convert.ToInt32
                                    (c[cantidad].fecha.Substring(4, 2)) < 01
                                || Convert.ToInt32
                                    (c[cantidad].fecha.Substring(4, 2)) > 12)
                                || (Convert.ToInt32
                                    (c[cantidad].fecha.Substring(6, 2)) < 01
                                || Convert.ToInt32
                                    (c[cantidad].fecha.Substring(6, 2)) > 31));

                        do
                        {
                            Console.Write("Descripcion: ");
                            c[cantidad].descripcion = Console.ReadLine();
                            if (c[cantidad].descripcion == "")
                                Console.WriteLine
                                    ("Por favor introduce una descripcion");
                        }
                        while (c[cantidad].descripcion == "");

                        Console.Write("Categoria: ");
                        c[cantidad].categoria = Console.ReadLine();
                        Console.Write("Importe: ");
                        c[cantidad].importe =
                            Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Agregado correctamente.");
                        cantidad++;
                    }
                    break;
                case '2':
                    string busqCategoria;
                    string fechaInicial;
                    string fechaFinal;
                    double importeTotal = 0;

                    if (cantidad <= 0)
                    {
                        Console.WriteLine("No hay datos para mostrar");
                    }
                    else
                    {
                        Console.Write("Categoria: ");
                        busqCategoria = Console.ReadLine();
                        Console.Write("Fecha inicio (AAAAMMDD): ");
                        fechaInicial = Console.ReadLine();
                        Console.Write("Fecha final: (AAAAMMDD): ");
                        fechaFinal = Console.ReadLine();

                        for (int i = 0; i < cantidad; i++)
                        {
                            if ((c[i].categoria == busqCategoria)
                                && (Convert.ToInt32(c[i].fecha)
                                    >= Convert.ToInt32(fechaInicial))
                                && (Convert.ToInt32(c[i].fecha)
                                    <= Convert.ToInt32(fechaFinal)))
                            {
                                Console.Write((i + 1) + " - " +
                                    (c[i].fecha.Substring(6, 2)) + "/" +
                                    (c[i].fecha.Substring(4, 2)) + "/" +
                                    (c[i].fecha.Substring(0, 4)) + " - " +
                                    c[i].descripcion + " - (" +
                                    c[i].categoria + ") - ");
                                Console.WriteLine(c[i].importe.ToString("N2"));
                                importeTotal += c[i].importe;
                            }
                        }

                        Console.WriteLine
                            ("Importe total de esta categoria: {0}",
                                importeTotal);
                    }
                    break;
                case '3':
                    string busqTexto;
                    int posicion = 0;
                    int espacios = 0;
                    if (cantidad <= 0)
                    {
                        Console.WriteLine("No hay datos para buscar");
                    }
                    else
                    {
                        Console.Write("Texto para buscar: ");
                        busqTexto = Console.ReadLine().ToUpper();

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (c[i].categoria.ToUpper().IndexOf(busqTexto) >= 0 || 
                                c[i].descripcion.ToUpper().IndexOf(busqTexto) >= 0)
                            {
                                foreach (char x in c[i].descripcion)
                                {
                                    if (x == ' ')
                                    {
                                        espacios++;
                                        if (espacios != 6)
                                            posicion++;
                                        else
                                            break;
                                    }
                                }

                                Console.Write(((i + 1) + " - " +
                                    (c[i].fecha.Substring(6, 2)) + "/" +
                                    (c[i].fecha.Substring(4, 2)) + "/" +
                                    (c[i].fecha.Substring(0, 4)) + " - "));
                                Console.WriteLine
                                    (c[i].descripcion.Substring(0, posicion - 1));
                            }
                        }
                    }
                    break;
                case '4':
                    Console.Write("Numero de ficha: ");
                    int posicionFicha = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (posicionFicha >= cantidad || posicionFicha < 0)
                        Console.WriteLine("No existen datos en esa ficha");
                    else
                    {
                        Console.WriteLine
                            ("Fecha (antes {0}): ", c[posicionFicha].fecha);
                        string fechaNueva = Console.ReadLine();
                        if (fechaNueva != "")
                            c[posicionFicha].fecha = fechaNueva;

                        Console.WriteLine
                            ("Descripcion (antes {0}): ", c[posicionFicha].descripcion);
                        string descripNueva = Console.ReadLine();
                        if (descripNueva != "")
                            c[posicionFicha].descripcion = descripNueva;

                        Console.WriteLine
                            ("Categoria (antes {0}): ", c[posicionFicha].categoria);
                        string categNueva = Console.ReadLine();
                        if (categNueva != "")
                            c[posicionFicha].categoria = categNueva;

                        Console.WriteLine("Importe (antes {0}: ",
                            c[posicionFicha].importe);
                        string importNuevo = Console.ReadLine();
                        if (importNuevo != "")
                        {
                            c[posicionFicha].importe = 
                                Convert.ToDouble(importNuevo);
                        }
                    }
                    break;
                case '5':
                    Console.Write("Ficha para borrar: ");
                    int fichaBorrar = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (fichaBorrar >= cantidad || fichaBorrar < 0)
                        Console.WriteLine("Posicion no valida");
                    else
                    {
                        Console.WriteLine((fichaBorrar + 1) + " - " +
                                    (c[fichaBorrar].fecha.Substring(6, 2)) + "/" +
                                    (c[fichaBorrar].fecha.Substring(4, 2)) + "/" +
                                    (c[fichaBorrar].fecha.Substring(0, 4)) + " - " +
                                    c[fichaBorrar].descripcion + " - (" +
                                    c[fichaBorrar].categoria + ") - " +
                                    c[fichaBorrar].importe);
                        Console.WriteLine("¿Seguro que quieres borrar esta ficha?");
                        Console.Write("S / N");
                        char borrar = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (borrar == 'S')
                        {
                            for (int i = fichaBorrar; i < cantidad; i++)
                                c[i] = c[i + 1];

                            cantidad--;
                        }
                        else if (borrar == 'n')
                            Console.WriteLine("Operacion cancelada");
                        else
                            Console.WriteLine("Opcion no valida");

                    }
                    break;
                case '6':
                    for (int i = 0; i < cantidad - 1; i++)
                    {
                        for (int j = i + 1; j < cantidad; j++)
                        {
                            if ((c[i].fecha.CompareTo(
                                    c[j].fecha) > 0)
                                ||
                                (
                                (c[i].fecha ==
                                c[j].fecha)
                                &&
                                (c[i].descripcion.CompareTo(
                                c[j].descripcion) > 0))
                                )

                            {
                                contabilidad aux = c[i];
                                c[i] = c[j];
                                c[j] = aux;
                            }
                        }
                    }
                    break;
                case '7':
                    for (int i = 0; i < cantidad; i++)
                    {
                        c[i].descripcion.Trim();

                        while (c[i].descripcion.Contains("  "))
                             c[i].descripcion.Replace("  "," ");

                        if (c[i].descripcion == c[i].descripcion.ToUpper())
                        {
                            c[i].descripcion.ToLower(); 
                            c[i].descripcion = 
                                c[i].descripcion.ToUpper().Substring(0, 1) 
                                + c[i].descripcion.Substring(1);
                        }
                    }
                    Console.WriteLine("Ortografia corregida");

                    break;
                case 'T':
                    Console.WriteLine("Hasta la proxima!");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

        }
        while (opcion != 'T');
    }
}
