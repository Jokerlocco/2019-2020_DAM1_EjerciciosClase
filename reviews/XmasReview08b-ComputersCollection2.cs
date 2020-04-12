//Francisco Jimenez Velasco
/*Crea un programa en C# que permita almacenar hasta 600 registros de 
 * ordenadores clásicos. Para cada ordenador, debes guardar los siguientes datos:

• Nombre de la marca (por ejemplo, Amstrad)

• Modelo (ej. CPC664)

• Año (eg 1984)

• RAM (conjunto de 2 datos: la unidad de medida, por ejemplo, Kb, y el tamaño,
  por ejemplo, 64)

• Comentarios

El programa debe permitir al usuario las siguientes operaciones:

1 - Añadir un nuevo registro de un ordenador (la marca no debe estar vacía, 
* el modelo debe ocupar más de 50 letras y, si alguna de ellas no es válida,
*  debe introducirse nuevamente. Si el año es anterior a 1900, se almacenará
*  como 0, para indicar que no es válido).

2 - Mostrar todas las marcas y modelos de ordenadores almacenados. Cada 
* ordenador (marca y modelo) debe aparecer en una línea, separada por un 
* guión (por ejemplo, "1 - Amstrad - CPC664"). El programa debe hacer una 
* pausa después de mostrar cada bloque de 24 ordenadores, mostrar el mensaje
*  "Pulse Intro para continuar" y esperar hasta que el usuario pulse Intro.
*  Se debe avisar al usuario si no hay datos.

3 - Buscar ordenadores que contengan un determinado texto (como parte de su 
* marca, modelo o comentarios, sin distinción de mayúsculas y minúsculas). Si 
* el año es 0, debería mostrar: "Año: desconocido". Los datos se deben mostrar
*  en líneas separadas, con una línea en blanco adicional después de cada 
* ordenador. El usuario debe ser avisado si no se encuentra ninguno.

4 - Modificar un registro (el programa solicitará el número, mostrará el 
* valor anterior de cada campo y el usuario puede presionar Intro para no 
* modificar alguno de los datos). Se debe advertir al usuario (pero no volver
*  a preguntarle) si indica un número de registro incorrecto. No es necesario
*  validar ninguno de los campos.

5 - Eliminar un registro, en la posición indicada por el usuario. Se debe 
* advertir al usuario (pero no volver a preguntarle) si introduce un número 
* de registro incorrecto.

6 - Insertar un registro en una posición elegida por el usuario (moviendo el 
* resto de los registros a la derecha). Se debe advertir al usuario (pero no 
* volver a preguntarle) si indica un número de registro incorrecto.

7 - Ordenar los datos alfabéticamente por marca + modelo.

8 - Eliminar espacios adicionales (espacios iniciales y finales en todas las 
* marcas, modelos y comentarios. Por ejemplo, un comentario como "  Datos   
* de prueba  " se convertirá en "Datos de prueba".

Q - Salir (como no almacenamos la información, se perderá).*/

using System;
class MenuOrdenador
{
    struct ordenador
    {
        public string marca;
        public string modelo;
        public int anyo;
        public int ram;
        public string comentarios;
    }
    static void Main()
    {
        const int MAX = 800;
        int cantidad = 0;
        ordenador[] pc = new ordenador[MAX];
        string seleccion;

        do
        {
            Console.WriteLine("Selecciona una opcion: ");
            Console.WriteLine("1-Añadir un nuevo registro.");
            Console.WriteLine("2-Mostrar todos los archivos.");
            Console.WriteLine("3-Buscar por texto.");
            Console.WriteLine("4-Modificar registro.");
            Console.WriteLine("5-Eliminar un registro.");
            Console.WriteLine("6-Insertar un registro.");
            Console.WriteLine("7-Ordenar registro.");
            Console.WriteLine("8-Eliminar espacios redundantes.");


            seleccion = Console.ReadLine().ToUpper();

            switch (seleccion)
            {
                case "1":
                    if (cantidad == MAX)
                    {
                        Console.WriteLine("Base de datos llena");
                    }

                    else
                    {
                        do
                        {
                            Console.WriteLine("Introduce el nombre: ");
                            pc[cantidad].marca = Console.ReadLine();

                            if (pc[cantidad].marca == "")
                            {
                                Console.WriteLine("El campo no puede estar vacio.");
                            }

                        } while (pc[cantidad].marca == "");
                       // do
                        //{
                            Console.WriteLine("Introduce el modelo: ");
                            pc[cantidad].modelo = Console.ReadLine();

                           /* if (pc[cantidad].modelo.Length < 50)
                            {
                                Console.WriteLine("El campo ha de tener más de" +
                                    " 50 caracteres.");
                            }*/

                        //} while (pc[cantidad].modelo.Length  50);
                        
                        Console.WriteLine("Introduce el año: ");
                        string anyoString = Console.ReadLine();
                        
                        if(anyoString =="")
                        {
                            pc[cantidad].anyo = 0;
                        }
                        else
                        {
                            pc[cantidad].anyo = Convert.ToInt32(anyoString);
                        }
                        
                        Console.WriteLine("Introduce la ram: ");
                        
                        pc[cantidad].ram = Convert.ToInt32(Console.ReadLine());

                        if (pc[cantidad].anyo < 1900)
                        {
                            pc[cantidad].anyo = 0;
                        }
                        
                        Console.WriteLine("Introduce algún comentario: ");
                        
                        pc[cantidad].comentarios = Console.ReadLine();
                        
                        cantidad++;
                    }
                    break;

                case "2":

                    if (cantidad == 0)
                    {
                        Console.WriteLine("Base de datos inexistente");
                    }

                    else
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine((i + 1) + "-" + pc[i].marca +
                                "-" + pc[i].modelo);
                                
                            if (i % 24 == 23)
                            {
                                Console.WriteLine("Introduce enter para continuar.");
                                Console.ReadLine();
                            }
                        }
                    }
                    break;


                case "3":
                    Console.WriteLine("Introduce texto a buscar: ");
                    string busqueda = Console.ReadLine().ToUpper();
                    bool encontrado = false;

                    for (int i = 0; i < cantidad; i++)
                    {
                        if (pc[i].marca.ToUpper().Contains(busqueda) ||
                           pc[i].modelo.ToUpper().Contains(busqueda) ||
                           pc[i].comentarios.ToUpper().Contains(busqueda))
                        {
                            Console.WriteLine("La marca es: " + pc[i].marca);
                            Console.WriteLine("El modelo es: " + pc[i].modelo);
                            Console.WriteLine("La ram es es: " + pc[i].ram);
                            if (pc[i].anyo == 0)
                            {
                                Console.Write("Año desconocido");
                            }
                            else
                            {
                                Console.WriteLine("Año: " + pc[i].anyo);
                            }
                            Console.WriteLine("Comentarios: " + pc[i].comentarios);
                            Console.WriteLine();

                            encontrado = true;

                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("No se encontraron coincidencias.");
                    }
                    break;
                case "4":
                    if (cantidad == 0)
                    {
                        Console.WriteLine("Aún no existen datos.");
                    }

                    else
                    {
                        Console.WriteLine("Introduce una posicion a modificar: ");
                        int modificar = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (modificar > cantidad || modificar < 0)
                        {
                            Console.WriteLine("Posición Inexistente.");
                        }

                        else
                        {
                            Console.WriteLine("La marca es: " +
                             pc[modificar].marca);
                            Console.WriteLine("Deseas cambiarla?");
                            string respuesta = Console.ReadLine();

                            if (respuesta == "")
                            {
                                Console.WriteLine("Datos no cambiados");
                            }

                            else
                            {
                                pc[modificar].marca = respuesta;
                            }

                            Console.WriteLine("El modelo es: " +
                                pc[modificar].modelo);
                            Console.WriteLine("Deseas cambiarlo?");
                            respuesta = Console.ReadLine();

                            if (respuesta == "")
                            {
                                Console.WriteLine("Datos no cambiados");
                            }

                            else
                            {
                                pc[modificar].modelo = respuesta;
                            }

                            Console.WriteLine("El año es: " + 
                                pc[modificar].anyo);
                                
                            Console.WriteLine("Deseas cambiarlo?");
                            respuesta = Console.ReadLine();

                            if (respuesta == "")
                            {
                                Console.WriteLine("Datos no cambiados");
                            }

                            else
                            {
                                pc[modificar].anyo = Convert.ToInt32(respuesta);
                            }

                            Console.WriteLine("Los comentarios son: "
                                + pc[modificar].anyo);
                                
                            Console.WriteLine("Deseas cambiarlos?");
                            respuesta = Console.ReadLine();

                            if (respuesta == "")
                            {
                                Console.WriteLine("Datos no cambiados");
                            }

                            else
                            {
                                pc[modificar].comentarios = respuesta;
                            }
                        }
                    }
                    break;
                    
                case "5":
                    if (cantidad == 0)
                    {
                        Console.WriteLine("Datos inexistentes.");
                    }
                    
                    else
                    {
                        Console.WriteLine("Introduce posicion a borrar: ");
                        int borrar = Convert.ToInt32(Console.ReadLine()) - 1;

                        if(borrar >= 0 &&  borrar < cantidad)
                        {
                            for(int i = borrar; i < cantidad; i++)
                            {
                                pc[i] = pc[i + 1];
                            }
                            
                            cantidad--;
                        }
                        
                        else
                        {
                            Console.WriteLine("Posicion Inexistente");
                        }
                    }
                    break;
                    
                case "6":
                    if(cantidad == 0)
                    {
                        Console.WriteLine("No existen datos");
                    }
                    
                    else
                    {
                        Console.WriteLine("Introduce posicion a insertar: ");
                        int insertar = Convert.ToInt32(Console.ReadLine()) - 1;

                        if(insertar >= 0 && insertar <= cantidad)
                        {
                            for(int i = cantidad; i > insertar; i--)
                            {
                                pc[i] = pc[i - 1];
                            }

                            Console.WriteLine("Introduce la marca: ");
                            pc[insertar].marca = Console.ReadLine();

                            Console.WriteLine("Introduce el modelo: ");
                            pc[insertar].modelo = Console.ReadLine();

                            Console.WriteLine("Introduce el año: ");
                            string respuesta = Console.ReadLine();
                            if (respuesta == "")
                            {
                                pc[insertar].anyo = 0;
                            }
                            
                            else
                            {
                                pc[insertar].anyo = 
                                    Convert.ToInt32(respuesta);
                            }
                            Console.WriteLine("Introduce el comentario: ");
                            pc[insertar].comentarios = Console.ReadLine();
                            
                             cantidad++;

                        }
                       
                    }
                    break;
                    
                case "7":
                    if(cantidad == 0)
                    {
                        Console.WriteLine("Datos inexistentes");
                    }

                    else if(cantidad > 1)
                    {
                        for(int i = 0; i < cantidad-1; i++)
                        {
                            for(int j = i +1; j < cantidad; j++)
                            {
                                if (pc[i].marca.CompareTo(pc[j].marca) > 0)
                                {
                                    ordenador aux = pc[i];
                                    pc[i] = pc[j];
                                    pc[j] = aux;
                                }
                                else if(pc[i].marca == pc[j].marca)
                                {
                                    if(pc[i].modelo.CompareTo(pc[j].modelo)>0)
                                    {
                                        ordenador aux = pc[i];
                                        pc[i] = pc[j];
                                        pc[j] = aux;
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "8":

                    if(cantidad==0)
                    {
                        Console.WriteLine("Datos inexistentes");                       
                    }
                    
                    else
                    {
                        for(int i = 0; i < cantidad; i++)
                        {
                            pc[i].marca = pc[i].marca.Trim();
                            pc[i].modelo = pc[i].modelo.Trim();
                            pc[i].comentarios = pc[i].comentarios.Trim();

                            while(pc[i].marca.Contains("  "))
                            {
                                pc[i].marca.Replace("  "," ");
                            }

                            while(pc[i].comentarios.Contains("  "))
                            {
                                pc[i].comentarios.Replace("  "," ");
                            }

                            while (pc[i].modelo.Contains("  "))
                            {
                                pc[i].modelo.Replace("  "," ");
                            }
                        }
                    }
                    break;
            }

        } while (seleccion != "Q");
    }
}
