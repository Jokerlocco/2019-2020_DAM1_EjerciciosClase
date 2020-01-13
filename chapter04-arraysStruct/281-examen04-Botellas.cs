using System;

class ColeccionBotellas
{
    struct Botella
    {
        public string nombre;
        public int mililitros;
        public float grados;
        public string comentario;
    }

    static void Main()
    {
        const int MAX = 10000;
        Botella[] cervezas = new Botella[MAX];
        int cantidad = 0;
        bool terminado = false;
        char opcion;

        do
        {
            Console.WriteLine("1- Anotar nueva cerveza");
            Console.WriteLine("2- Buscar cervezas");
            Console.WriteLine("3- Editar una cerveza");
            Console.WriteLine("4- Borrar una cerveza");
            Console.WriteLine("5- Estadísticas generales");
            Console.WriteLine("T- Salir de la aplicación");
            Console.WriteLine();
            Console.Write("Elige una opción: ");
            opcion = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (opcion)
            {
                case '1':
                    if (cantidad >= MAX)
                        Console.WriteLine("Lista llena");
                    else
                    {
                        Console.WriteLine("Añadiendo en entrada: " + (cantidad + 1));
                        Console.WriteLine();

                        do
                        {
                            Console.Write("Nombre: ");
                            cervezas[cantidad].nombre = Console.ReadLine();
                            if (cervezas[cantidad].nombre == "")
                                Console.WriteLine("El campo no puede estar vacío");
                        } while (cervezas[cantidad].nombre == "");

                        string tamanyo;
                        Console.Write("Tamaño: ");
                        tamanyo = Console.ReadLine();
                        if (tamanyo == "" || Convert.ToInt32(tamanyo) < 0)
                        {
                            cervezas[cantidad].mililitros = 0;
                            Console.WriteLine("Guardado como '0'");
                        }
                        else
                            cervezas[cantidad].mililitros = Convert.ToInt32(tamanyo);

                        string grados;

                        Console.Write("Grados: ");
                        grados = Console.ReadLine();
                        if (grados == "" || Convert.ToSingle(grados) < 0f)
                        {
                            cervezas[cantidad].grados = 0;
                            Console.WriteLine("Guardado como '0'");
                        }
                        else
                            cervezas[cantidad].grados = Convert.ToSingle(grados);

                        Console.Write("Comentarios: ");
                        cervezas[cantidad].comentario = Console.ReadLine();
                        
                        cantidad++;
                        for (int i = 0; i < cantidad - 1; i++)
                        {
                            for (int j = i + 1; j < cantidad; j++)
                            {
                                if (cervezas[i].nombre.ToUpper().CompareTo(
                                    cervezas[j].nombre.ToUpper()) > 0 
                                    ||
                                    (cervezas[i].nombre.ToUpper() ==
                                    cervezas[j].nombre.ToUpper() 
                                    && (cervezas[i].mililitros <
                                    cervezas[j].mililitros)))
                                {
                                    Botella aux = cervezas[i];
                                    cervezas[i] = cervezas[j];
                                    cervezas[j] = aux;
                                }
                            }
                        }
                        Console.WriteLine("Dato añadido y ordenado");
                    }
                    break;

                case '2':
                    Console.Write("Fragmento de nombre a buscar: ");
                    string fragmento = Console.ReadLine().ToUpper();
                    Console.Write("Graduación mínima: ");
                    float gMin = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Graduación máxima: ");
                    float gMax = Convert.ToSingle(Console.ReadLine());
                    if (gMax == 0) gMax = 100;
                    int contador = 0;

                    for (int i = 0; i < cantidad; i++)
                    {
                        if (cervezas[i].nombre.ToUpper().Contains(fragmento) &&
                                cervezas[i].grados >= gMin &&
                                cervezas[i].grados <= gMax)
                        {
                            contador++;
                            Console.Write(contador + ": ");
                            Console.Write(cervezas[i].nombre + " / ");
                            Console.Write(cervezas[i].mililitros + "ml / ");
                            Console.Write(cervezas[i].grados + "º / ");
                            if (cervezas[i].comentario.Length == 0)
                                Console.Write("(Sin comentarios)");
                            else
                                Console.Write(cervezas[i].comentario);
                            Console.WriteLine();
                        }
                    }
                    if (contador == 0)
                        Console.WriteLine("No encontrado");
                    break;

                case '3':
                    Console.Write("Introduce registro a editar: ");
                    int editar = Convert.ToInt32(Console.ReadLine()) - 1;
                    if ((editar < 0) || (editar >= cantidad))
                        Console.WriteLine("Número de registro incorrecto");
                    else
                    {
                        Console.WriteLine("Editando registro " + (editar + 1));
                        Console.WriteLine("'Enter' para no guardar cambios");
                        Console.WriteLine();
                        Console.Write("Nombre (Antes: " + cervezas[editar].nombre + "): ");
                        string nuevoNombre = Console.ReadLine();
                        if (nuevoNombre != "")
                            cervezas[editar].nombre = nuevoNombre;

                        Console.Write("Tamaño (Antes: " + cervezas[editar].mililitros + "): ");
                        string nuevoTam = Console.ReadLine();
                        if (nuevoTam != "")
                        {
                            if (Convert.ToInt32(nuevoTam) < 0)
                                cervezas[editar].mililitros = 0;
                            else
                                cervezas[editar].mililitros = Convert.ToInt32(nuevoTam);
                        }

                        Console.Write("Grados (Antes: " + cervezas[editar].grados + "): ");
                        string nuevoGrad = Console.ReadLine();
                        if (nuevoGrad != "")
                        {
                            if (Convert.ToInt32(nuevoGrad) < 0)
                                cervezas[editar].grados = 0;
                            else
                                cervezas[editar].grados = Convert.ToSingle(nuevoGrad);
                        }

                        Console.Write("Comentarios (Antes: " +
                            cervezas[editar].comentario + "): ");
                        string nuevoCom = Console.ReadLine();
                        if (nuevoCom != "")
                            cervezas[editar].comentario = nuevoCom;
                    }
                    break;

                case '4':
                    Console.Write("Ficha a borrar: ");
                    int posBorrar = Convert.ToInt32(Console.ReadLine()) - 1;
                    if ((posBorrar < 0) || (posBorrar >= cantidad))
                        Console.WriteLine("Número de registro incorrecto");
                    else
                    {
                        Console.WriteLine("Estás a punto de borrar...");
                        Console.WriteLine();
                        Console.Write((posBorrar + 1) + ": ");
                        Console.Write(cervezas[posBorrar].nombre + " / ");
                        Console.Write(cervezas[posBorrar].mililitros + "ml / ");
                        Console.Write(cervezas[posBorrar].grados + "º / ");
                        if (cervezas[posBorrar].comentario.Length == 0)
                            Console.Write("(Sin comentarios)");
                        else
                            Console.Write(cervezas[posBorrar].comentario);
                        Console.WriteLine();

                        Console.WriteLine("¿Estás seguro? (S/N): ");
                        char eleccion = Convert.ToChar(
                            Console.ReadLine().ToUpper());
                        if (eleccion == 'S')
                        {
                            for (int i = posBorrar; i < cantidad; i++)
                                cervezas[i] = cervezas[i + 1];

                            cantidad--;
                            Console.WriteLine("Borrado con éxito");
                        }
                        else if (eleccion == 'N')
                            Console.WriteLine("Operación cancelada");
                        else
                            Console.WriteLine("Opción no válida");
                    }
                    break;

                case '5':
                    if (cantidad == 0)
                        Console.WriteLine("Opción no válida. Lista vacía");
                    else
                    {
                        Console.WriteLine("Mostrando estadísticas generales...");
                        Console.WriteLine();

                        Console.WriteLine("Cantidad de cervezas: " + cantidad);
                        float maxAlcohol = cervezas[0].grados;
                        float totalAlcohol = 0;
                        int tamanyoTotal = 0;
                        int totalComentarios = 0;

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (cervezas[i].grados > maxAlcohol)
                                maxAlcohol = cervezas[i].grados;

                            totalAlcohol += cervezas[i].grados;
                            tamanyoTotal += cervezas[i].mililitros;

                            if (cervezas[i].comentario.Length != 0)
                                totalComentarios++;
                        }
                        float mediaAlcohol = totalAlcohol / cantidad;
                        int tamanyoMedia = tamanyoTotal / cantidad;

                        Console.WriteLine("Cerveza con más alcohol: " +
                            maxAlcohol + "º");
                        Console.WriteLine("Graduación media: " +
                            mediaAlcohol + "º");
                        Console.WriteLine("Tamaño medio: " + tamanyoMedia + "ml");
                        Console.Write("Cantidad de cervezas con comentarios: ");
                        Console.WriteLine(totalComentarios);
                    }
                    break;

                case 'T':
                    terminado = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        } while (! terminado);

        Console.WriteLine("¡Hasta pronto!");
    }
}
