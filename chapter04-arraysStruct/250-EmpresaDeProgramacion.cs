//Abraham García - StructProgramación

using System;

class structProgram
{
    struct Programadores
    {
        public string nombre;
        public string hab;
        public ushort anyo;
        public bool plant;
        public string com;
    }
    
    static void Main()
    {
        const int MAX = 1000;
        Programadores[] prog = new Programadores[MAX];
        int cantidad = 0;
        char op = '0';
        
        do
        {
            Console.WriteLine("1- Nuevo programador");
            Console.WriteLine("2- Buscar programadores");
            Console.WriteLine("3- Ver detalles de programador");
            Console.WriteLine("4- Modificar datos de progamador");
            Console.WriteLine("5- Borrar un registro");
            Console.WriteLine("6- Estadísticas generales");
            Console.WriteLine("7- Estadísticas de habilidades");
            Console.WriteLine("T- Salir");
            Console.WriteLine();
            Console.WriteLine("Elige una opción: ");
            op = Convert.ToChar(Console.ReadLine());
            
            switch (op)
            {
                case '1':
                    if (cantidad >= MAX)
                        Console.WriteLine("Lista llena");
                    else
                    {
                        Console.WriteLine("Añadiendo en la posición: " + (
                            cantidad+1));
                        
                        string nombre;
                        do
                        {    
                            Console.Write("Nombre: ");
                            nombre = Console.ReadLine();
                            if (nombre != "")
                                prog[cantidad].nombre = nombre;
                            else
                                Console.WriteLine("El campo no puede estar vacío");
                        } while (nombre == "");
                        
                        string hab;
                        do
                        {    
                            Console.Write("Habilidades: ");
                            hab = Console.ReadLine();
                            if (hab != "")
                                prog[cantidad].hab = hab;
                            else
                                Console.WriteLine("El campo no puede estar vacío");
                        } while (hab == "");
                        
                        Console.Write("Año de nacimiento (0 si no se sabe): ");
                        prog[cantidad].anyo = Convert.ToUInt16(Console.ReadLine());
                        
                        
                        char plantilla = 'x';
                        do
                        {
                            Console.Write("Está en plantilla? (s/n): ");
                            plantilla = Convert.ToChar(Console.ReadLine().ToUpper());

                                
                            if (plantilla == 'S')
                                prog[cantidad].plant = true;
                            else if (plantilla == 'N')
                                prog[cantidad].plant = false;
                            else
                                Console.WriteLine("Opción no válida");
                            
                        } while (plantilla != 'S' && plantilla != 'N');
                        
                        Console.Write("Comentarios(Puede estar vacío): ");
                        prog[cantidad].com = Console.ReadLine();
                        
                        for (int i = 0; i < cantidad - 1; i++)
                        {
                            for (int j = i+1; j < cantidad; j++)
                            {
                                if (prog[i].nombre.ToUpper().CompareTo(
                                    prog[j].nombre.ToUpper()) > 0)
                                    {
                                        Programadores aux = prog[i];
                                        prog[i] = prog[j];
                                        prog[j] = aux;
                                    }
                                else if (prog[i].nombre.ToUpper().CompareTo(
                                    prog[j].nombre.ToUpper()) == 0)
                                    {
                                        if (prog[i].anyo > prog[j].anyo)
                                        {
                                            Programadores aux = prog[i];
                                            prog[i] = prog[j];
                                            prog[j] = aux;
                                        }
                                    }
                            }
                        }
                        
                        Console.WriteLine("Dato añadido y ordenado");
                        cantidad++;
                    }
                    break;
                    
                case '2':
                    char nh;
                    bool encontrado = false;
                    do
                    {
                        Console.Write("Por nombre o por habilidad? (n/h): ");
                        nh = Convert.ToChar(Console.ReadLine().ToUpper());
                        
                            
                        if (nh == 'N')
                        {
                            Console.Write("Introduce nombre: ");
                            string bNom = Console.ReadLine();
                            int reg = 1;
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (prog[i].nombre.ToUpper().Contains(bNom.ToUpper()))
                                {
                                    Console.Write(reg + " - " +
                                        prog[i].nombre + " - " +
                                        prog[i].hab + " - ");
                                    if (prog[i].plant == true)
                                        Console.Write("Plantilla: SI");
                                    else
                                        Console.Write("Plantilla: NO");
                                    Console.WriteLine();
                                    reg++;
                                    encontrado = true;
                                    if (reg % 22 == 21)
                                        Console.ReadLine();
                                }
                            }
                            if (!encontrado)
                                Console.WriteLine("No se han encontrado resultados");
                        }
                        else if (nh == 'H')
                        {
                            Console.Write("Introduce habilidad: ");
                            string bHab = Console.ReadLine();
                            int reg = 1;
                            for (int i = 0; i < cantidad; i++)
                            {
                                if (prog[i].hab.ToUpper().Contains(bHab.ToUpper()))
                                {
                                    Console.Write(reg + " - " +
                                        prog[i].nombre + " - " +
                                        prog[i].hab + " - ");
                                    if (prog[i].plant == true)
                                        Console.Write("Plantilla: SI");
                                    else
                                        Console.Write("Plantilla: NO");
                                    Console.WriteLine();
                                    reg++;
                                    encontrado = true;
                                    if (reg % 22 == 21)
                                        Console.ReadLine();
                                }
                            }
                            if (!encontrado)
                                Console.WriteLine("No se han encontrado resultados");
                        }
                        else
                            Console.WriteLine("Opción no válida");
                    } while (nh != 'N' && nh != 'H');
                    break;
                    
                case '3':
                    Console.Write("Introduce número de registro: ");
                    int nReg = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (nReg >= cantidad)
                        Console.WriteLine("Introduce un número válido");
                    else
                    {
                        Console.WriteLine("Registro: " + nReg+1);
                        Console.WriteLine("Nombre: " + prog[nReg].nombre);
                        Console.WriteLine("Habilidades: " + prog[nReg].hab);
                        Console.WriteLine("Año de nacimiento: " + prog[nReg].anyo);
                        Console.Write("Plantilla: " );
                        if (prog[nReg].plant == true)
                            Console.WriteLine("SI");
                        else
                            Console.WriteLine("NO");
                        Console.WriteLine("Comentarios: " + prog[nReg].com);
                        Console.ReadLine();
                    }
                    break;
                    
                case '4':
                    Console.Write("Introduce número de registro: ");
                    int numReg = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (numReg >= cantidad)
                        Console.WriteLine("Introduce un número válido");
                    else
                    {
                        Console.WriteLine("Editando el registro " + (numReg+1));
                        
                        Console.WriteLine("No introduzcas nada para no cambiar nada");
                        Console.Write("Nombre (antes: " + prog[numReg].nombre + "): ");
                        string nuevoNombre = Console.ReadLine();
                        if (nuevoNombre != "")
                            prog[numReg].nombre = nuevoNombre;
                            
                        Console.Write("Habilidad(antes: " + prog[numReg].hab + "): ");
                        string nuevaHab = Console.ReadLine();
                        if (nuevaHab != "")
                        {
                            if (nuevaHab.Contains(" "))
                            {
                                Console.Write("Lo que has introducido tiene "
                                    +"espacios. Deseas borrarlos? (s/n): ");
                                char borrEsp = 'X';
                                do
                                {
                                    borrEsp = Convert.ToChar(
                                        Console.ReadLine().ToUpper());
                                    if (borrEsp == 'N')
                                        Console.WriteLine("Espacios no borrados");
                                    else  if (borrEsp == 'S')
                                    {
                                        while (nuevaHab.Contains(" "));
                                            nuevaHab = nuevaHab.Replace(" ","");
                                        Console.WriteLine("Espacios borrados");
                                    }
                                } while (borrEsp != 'S' && borrEsp != 'N');
                            }
                            prog[numReg].hab = nuevaHab;
                        }
                        
                        Console.Write("Año de nacimiento (antes: " + 
                            prog[numReg].anyo + "): ");
                        string nuevoAnyo = Console.ReadLine();
                        if (nuevoAnyo != "")
                            prog[numReg].anyo = Convert.ToUInt16(nuevoAnyo);
                        
                        string nuevaPlant;
                        do
                        {
                            Console.Write("Plantilla (s/n): ");
                            if (prog[numReg].plant == true)
                                Console.Write("Antes SI): ");
                            else
                                Console.Write("Antes NO): ");
                                
                            nuevaPlant = Console.ReadLine().ToUpper();
                            if (nuevaPlant == "S")
                                prog[numReg].plant = true;
                            else if (nuevaPlant == "N")
                                prog[numReg].plant = false;
                            else if (nuevaPlant == "")
                                Console.WriteLine("Plantilla no cambiada");
                            else
                                Console.WriteLine("Opción no válida");
                        } while (nuevaPlant != "S" && nuevaPlant != "N" && nuevaPlant != "");
                        
                        Console.Write("Comentarios (antes: " + prog[numReg].com + "): ");
                        string nuevoCom = Console.ReadLine();
                        if (nuevoCom != "")
                            prog[numReg].com = nuevoCom;
                    }
                    break;
                    
                case '5':
                    Console.Write("Elige registro a borrar: ");
                    int borrar = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (borrar >= cantidad)
                        Console.WriteLine("Número de registro no válido");
                    else
                    {
                        Console.WriteLine("Se va a borrar: ");
                        Console.WriteLine("Registro: " + (borrar+1));
                        Console.WriteLine("Nombre: " + prog[borrar].nombre);
                        Console.WriteLine("Habilidades: " + prog[borrar].hab);
                        Console.WriteLine("Estás seguro? (s/n): ");
                        char seguro;
                        do
                        {
                            seguro = Convert.ToChar(Console.ReadLine().ToUpper());
                            if (seguro == 'N')
                                Console.WriteLine("Registro no borrado");
                            else if (seguro == 'S')
                            {
                                for (int i = borrar; i < cantidad; i++)
                                {
                                    prog[i] = prog[i+1];
                                }
                                Console.WriteLine("Registro borrado");
                                cantidad--;
                            }
                            else
                                Console.WriteLine("Introduce una opción válida");
                        } while (seguro != 'S' && seguro != 'N');
                    }
                    break;
                    
                case '6':
                    Console.WriteLine("Cantidad total de trabajadores: " + cantidad);
                    int contadorPlantilla = 0;
                    int joven = prog[0].anyo;
                    int viejo = prog[0].anyo;
                    float contadorComas = 0f;
                    float mediaHab = 0f;
                    
                    for (int i = 0; i < cantidad; i++)
                    {
                        if (prog[i].plant == true)
                            contadorPlantilla++;
                        
                        if (prog[i].anyo > joven)
                            joven = prog[i].anyo;
                        if (prog[i].anyo < viejo)
                            viejo = prog[i].anyo;
                        
                        foreach (char c in prog[i].hab)
                        {
                            if (c == ',')
                                contadorComas++;
                        }
                        contadorComas++;
                    }
                    
                    float porcentaje = (contadorPlantilla * 100.0f ) / cantidad;
                    mediaHab = contadorComas / cantidad;
                    
                    Console.WriteLine("Porcentaje plantilla: " + porcentaje.ToString("N1") + "%");
                    Console.WriteLine("Año en el que nació el más joven: " + joven);
                    Console.WriteLine("Año en el que nació el más veterano: " + viejo);
                    Console.WriteLine("Cantidad media de habilidades: " + mediaHab);
                    break;
                    
                case '7':
                    // Nota: corrección pediente, no se debe pedir al usuario
                    // sino analizar las habilidades existentes en la base de datos
                    Console.Write("Introduce habilidades (separadas por espacios): ");
                    string habs = Console.ReadLine();
                    string[] arrayHabs = habs.Split();
                    
                    for (int i = 0; i < arrayHabs.Length; i++)
                    {
                        int contHabs = 0;
                        for (int j = 0; j < cantidad; j++)
                        {
                            if (prog[j].hab.ToUpper().Contains(arrayHabs[i].ToUpper()))
                                contHabs++;
                        }
                        
                        Console.WriteLine(arrayHabs[i] + ": " + contHabs);
                    }
                    break;
                    
                case 't':
                case 'T':
                    Console.WriteLine("Hasta luego");
                    break;
                    
                default:
                    Console.WriteLine("Introduzca una opción válida");
                    break;
            }

        } while (op != 'T' && op != 't');
    }

}

