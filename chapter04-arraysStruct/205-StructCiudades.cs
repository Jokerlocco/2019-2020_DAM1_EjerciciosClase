//Abraham García - Ciudades

using System;

class ejercicioCiudades
{
    struct ciudades
    {
        public string nombre;
        public string pais;
        public ulong poblacion;
    }
    static void Main()
    {
        const int MAX = 20000;
        
        ciudades[] ciudad = new ciudades[MAX];
        
        int cantidad = 0;
        string opcion;
        
        do
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
        opcion = Console.ReadLine();
        
        switch (opcion)
        {
            case "1":
                if (cantidad >= MAX)
                    Console.WriteLine("La lista está llena");
                else
                {
                    Console.WriteLine("Añadiendo ciudad número " + (cantidad+1) +
                        ": ");
                    do
                    {    
                    Console.Write("Nombre: ");
                    ciudad[cantidad].nombre = Console.ReadLine();
                    if (ciudad[cantidad].nombre == "")
                        Console.WriteLine("El nombre no puede estar vacío");
                    } while (ciudad[cantidad].nombre == "");
                    
                    do
                    {    
                    Console.Write("País: ");
                    ciudad[cantidad].pais = Console.ReadLine();
                    if (ciudad[cantidad].pais == "")
                        Console.WriteLine("El pais no puede estar vacío");
                    } while (ciudad[cantidad].pais == "");
                    
                    string poblacion;
                    Console.Write("Población: ");
                    poblacion = Console.ReadLine();
                    if (poblacion == "")
                        ciudad[cantidad].poblacion = 0;
                    else
                        ciudad[cantidad].poblacion = Convert.ToUInt64(poblacion);
                        
                    cantidad++;
                }
                break;
                
            case "2":
                if (cantidad == 0)
                    Console.WriteLine("Lista vacía");
                else
                {
                    for (int i = 0; i < cantidad; i++)
                    {
                        if (ciudad[i].nombre.Length > 20)
                            ciudad[i].nombre = (ciudad[i].nombre.
                                Remove(19) + "...");
                                
                        if (ciudad[i].pais.Length > 40)
                        {
                            ciudad[i].pais = (ciudad[i].pais.
                                Remove(40));
                            while (ciudad[i].pais.Contains(" "))
                                ciudad[i].pais = ciudad[i].pais.
                                    Replace(" ","");
                        }
                        Console.Write((i+1) + "- " + ciudad[i].nombre +
                            ", " + ciudad[i].pais);
                        Console.WriteLine();
                        
                        if (i%24 == 23)
                        {
                            string pulsar = Console.ReadLine();
                            if (pulsar == "fin")
                                i = cantidad-1;
                        }
                    }
                }
                break;
                
            case "3":
                if (cantidad == 0)
                    Console.WriteLine("Lista vacía");
                else
                {
                    Console.Write("Texto a buscar: ");
                    string buscar = Console.ReadLine();
                    
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (ciudad[i].nombre.ToUpper().Contains(buscar.ToUpper()) ||
                                ciudad[i].pais.ToUpper().Contains(buscar.ToUpper()))
                            {
                                Console.Write((i+1) + "- " + ciudad[i].nombre +
                                    ", " + ciudad[i].pais);
                                if (ciudad[i].poblacion == 0)
                                    Console.WriteLine(" - Población desconocida");
                                else
                                    Console.WriteLine(" - " + ciudad[i].poblacion);
                                    
                                if (i%24 == 23)
                                    Console.ReadLine();
                            }
                        }
                }
                break;
                
            case "4":
                if (cantidad == 0)
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
                            if (reg > cantidad)
                                Console.WriteLine("Registro incorrecto");
                            else
                            {
                                reg--;
                                Console.WriteLine(" Los datos que pertenecen a ese registro son: ");
                                
                                Console.WriteLine("Nombre: " + ciudad[reg].nombre);
                                Console.WriteLine("Pulsa INTRO para cancelar modificación");
                                string nuevoNombre = Console.ReadLine();
                                if (nuevoNombre != "")
                                {
                                    while (nuevoNombre.Contains("  "))
                                        nuevoNombre = nuevoNombre.Replace("  "," ");
                                    nuevoNombre = nuevoNombre.TrimStart();
                                    nuevoNombre = nuevoNombre.TrimEnd();
                                    ciudad[reg].nombre = nuevoNombre;
                                }
                                Console.WriteLine();
                                
                                Console.WriteLine("Pais: " + ciudad[reg].pais);
                                Console.WriteLine("Pulsa INTRO para cancelar modificación");
                                string nuevoPais = Console.ReadLine();
                                if (nuevoPais != "")
                                {
                                    while (nuevoPais.Contains("  "))
                                        nuevoPais = nuevoPais.Replace("  "," ");
                                    nuevoPais = nuevoPais.TrimStart();
                                    nuevoPais = nuevoPais.TrimEnd();
                                    ciudad[reg].pais = nuevoPais;
                                }
                                Console.WriteLine();
                                
                                Console.WriteLine("Población: " + ciudad[reg].poblacion);
                                Console.WriteLine("Pulsa INTRO para cancelar modificación");
                                string nuevaPob = Console.ReadLine();
                                if (nuevaPob != "")
                                {
                                    while (nuevaPob.Contains("  "))
                                        nuevaPob = nuevaPob.Replace("  "," ");
                                    nuevaPob = nuevaPob.TrimStart();
                                    nuevaPob = nuevaPob.TrimEnd();
                                    ciudad[reg].poblacion = Convert.ToUInt64(nuevaPob);
                                }
                                Console.WriteLine();
                                salir = true;
                            }
                        }
                        else
                            Console.WriteLine("Saliendo...");
                    } while (reg != 0 && !salir);
                }
                break;
                
            case "5":
                if (cantidad == 0)
                    Console.WriteLine("Lista vacía");
                else if (cantidad >= MAX)
                    Console.WriteLine("Lista llena");
                else
                {
                    Console.Write("Introduce posición donde insertar: ");
                    int regNuevo = Convert.ToInt32(Console.ReadLine()) -1;
                    if (regNuevo >= cantidad)
                        Console.WriteLine("No existen tantos registros");
                    else
                    {
                        for (int i = cantidad; i >= regNuevo; i--)
                            ciudad[i+1] = ciudad[i];
                            
                        Console.WriteLine("Insertando registro en la posición " + (regNuevo+1) + ": ");
                        
                    do
                    {    
                    Console.Write("Nombre: ");
                    ciudad[regNuevo].nombre = Console.ReadLine();
                    if (ciudad[regNuevo].nombre == "")
                        Console.WriteLine("El nombre no puede estar vacío");
                    } while (ciudad[regNuevo].nombre == "");
                    
                    do
                    {    
                    Console.Write("País: ");
                    ciudad[regNuevo].pais = Console.ReadLine();
                    if (ciudad[regNuevo].pais == "")
                        Console.WriteLine("El pais no puede estar vacío");
                    } while (ciudad[regNuevo].pais == "");
                    
                    string poblacion;
                    Console.Write("Población: ");
                    poblacion = Console.ReadLine();
                    if (poblacion == "")
                        ciudad[regNuevo].poblacion = 0;
                    else
                        ciudad[regNuevo].poblacion = Convert.ToUInt64(poblacion);
                        
                    cantidad++;
                    }
                }
                break;
                
            case "6":
                if (cantidad == 0)
                    Console.WriteLine("Lista vacía");
                else
                {
                    Console.Write("Introduce registro a borrar :");
                    int regBorrar = Convert.ToInt32(Console.ReadLine()) -1;
                    if (regBorrar >= cantidad)
                        Console.WriteLine("No existen tantos registros");
                    else
                    {
                        Console.WriteLine("Se va a eliminar el registro " +
                        (regBorrar+1) + "- " + ciudad[regBorrar].nombre + ", " +
                        ciudad[regBorrar].pais + ", " + ciudad[regBorrar].poblacion);
                        Console.Write("¿Estás seguro? (s/n)");
                        char decision = Convert.ToChar(Console.ReadLine());
                        if (decision == 'n')
                            Console.WriteLine("El registro no se ha borrado");
                        else if (decision == 's')
                        {
                            for (int i = regBorrar; i < cantidad; i++)
                                ciudad[i] = ciudad[i+1];
                                
                            Console.WriteLine("La posición " + (regBorrar+1) + " se ha borrado");
                            cantidad--;
                        }
                        else
                            Console.WriteLine("Introduce una opción válida");
                    }
                }
                break;
                
            case "7":
                if (cantidad == 0)
                    Console.WriteLine("Lista vacía");
                else
                {
                    Console.Write("¿Por nombre de ciudad o país? (c/p)");
                    char cop = Convert.ToChar(Console.ReadLine());
                    if (cop == 'c')
                    {
                        for (int i = 0; i < cantidad-1; i++)
                        {
                            for (int j = i+1; j < cantidad; j++)
                            {
                                if (ciudad[i].nombre.ToUpper().CompareTo(
                                    ciudad[j].nombre.ToUpper()) > 0)
                                {
                                    ciudades aux = ciudad[i];
                                    ciudad[i] = ciudad[j];
                                    ciudad[j] = aux;
                                }
                            }
                        }
                        Console.WriteLine("Ordenado con éxito");
                    }
                    else if (cop == 'p')
                    {
                        for (int i = 0; i < cantidad-1; i++)
                        {
                            for (int j = i+1; j < cantidad; j++)
                            {
                                if (ciudad[i].pais.ToUpper().CompareTo(
                                    ciudad[j].pais.ToUpper()) > 0)
                                {
                                    ciudades aux = ciudad[i];
                                    ciudad[i] = ciudad[j];
                                    ciudad[j] = aux;
                                }
                            }
                        }
                        Console.WriteLine("Ordenado con éxito");
                    }
                    else
                        Console.WriteLine("Introduce una opción válida");
                }
                break;
                
            case "8":
                if (cantidad == 0)
                    Console.WriteLine("Lista vacía");
                else
                {
                    Console.WriteLine("Corrigiendo los siguientes registros: ");
                    for (int i = 0; i < cantidad; i++)
                    {
                        if ((ciudad[i].nombre.Contains(",,") || ciudad[i].pais.Contains(",,")) ||
                            (ciudad[i].nombre.Contains("..") || ciudad[i].pais.Contains("..")))
                        {
                            Console.WriteLine("Ciudad: " + ciudad[i].nombre +
                            ", Pais: " + ciudad[i].pais + ", Población: " +
                            ciudad[i].poblacion);
                            
                            while ((ciudad[i].nombre.Contains(",,") || ciudad[i].pais.Contains(",,")) ||
                                (ciudad[i].nombre.Contains("..") || ciudad[i].pais.Contains("..")))
                            {
                                ciudad[i].nombre = ciudad[i].nombre.Replace(",,",",");
                                ciudad[i].nombre = ciudad[i].nombre.Replace("..",".");
                                ciudad[i].pais = ciudad[i].pais.Replace(",,",",");
                                ciudad[i].pais = ciudad[i].pais.Replace("..",".");
                            }
                        }
                        
                        //TO DO
                        /*for (int j = 0; j < ciudad[i].nombre.Length-2; j++)
                        {
                            if (ciudad[i].nombre[j] == ciudad[i].nombre[j+1] &&
                                ciudad[i].nombre[j] == ciudad[i].nombre[j+2])
                            {
                                ciudad[i].nombre[j] = ciudad[i].nombre[j];
                            }
                        }*/
                    }
                }
                break;
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
}
