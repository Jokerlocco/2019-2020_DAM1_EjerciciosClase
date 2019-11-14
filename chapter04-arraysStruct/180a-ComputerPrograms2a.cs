/*
 Crea un programa en C# que pueda almacenar fichas de hasta 1000 programas de 
 ordenador. Para cada programa, debe guardar los siguientes datos:

    Nombre
    Descripción
    Versión (es un conjunto de 2 datos: el mes de lanzamiento –byte- y 
    el año de lanzamiento –entero corto sin signo-)

 El programa debe permitir al usuario las siguientes operaciones:

 1- Añadir datos de un nuevo programa. 

 2- Mostrar los nombres de todos los programas almacenados. Cada nombre 
  debe aparecer en una línea distinta. Si hay más de 20 programas, se 
  deberá hacer una pausa tras mostrar cada bloque de 20 programas, y 
  a que el usuario pulse Intro antes de seguir. Se deberá avisar si 
  no hay datos.

 3- Ver todos los datos de un cierto programa (a partir de su nombre). 
  Si hay varios programas que contengan ese texto, se mostrarán todos 
  ellos, separados por una línea en blanco. Se deberá avisar si no se 
  encuentra ningún programa.

 4- Modificar una ficha (se pedirá el número y se volverá a introducir 
  el valor de todos los campos. Se debe avisar (pero no volver a pedir) 
  si introduce un número de ficha incorrecto.

 5- Borrar un cierto dato, a partir del número que indique el usuario. 
  Se debe avisar (pero no volver a pedir) si introduce un número incorrecto.

 T- Terminar el uso de la aplicación (como no sabemos almacenar la información,
  los datos se perderán).
 */

using System;

class ComputerPrograms
{
    struct versionData
    {
        public string releaseNumber;
        public byte month;
        public ushort year;
    }

    struct program
    {
        public string name;
        public string category;
        public string description;
        public versionData version;
    }

    static void Main()
    {
        const int MAX_CAPACITY = 1000;
        int amountOfData = 0;
        program[] programs = new program[MAX_CAPACITY];
        char option;

        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1- Enter data");
            Console.WriteLine("2- Show all programs");
            Console.WriteLine("3- Show program");
            Console.WriteLine("4- Modify data");
            Console.WriteLine("5- Delete program");
            Console.WriteLine("T- Exit");
            option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case '1':
                    if (amountOfData < MAX_CAPACITY)
                    {
                        Console.WriteLine("Data " + (amountOfData + 1) + ":");

                        do
                        {
                            Console.Write("Enter name: ");
                            programs[amountOfData].name = Console.ReadLine();
                            if (programs[amountOfData].name.Length == 0)
                                Console.WriteLine("The name cannot be empty");
                        }
                        while (programs[amountOfData].name.Length == 0);

                        do
                        {
                            Console.Write("Enter category: ");
                            programs[amountOfData].category = Console.ReadLine();
                            if (programs[amountOfData].category.Length > 30)
                                Console.WriteLine("No more than 30 letters, please");
                        }
                        while (programs[amountOfData].category.Length > 30);

                        Console.Write("Enter description: ");
                        programs[amountOfData].description = Console.ReadLine();
                        if (programs[amountOfData].description.Length > 100)
                        {
                            programs[amountOfData].description =
                                programs[amountOfData].description.Substring(0, 100);
                            Console.WriteLine("Truncated to 100 letters");
                        }

                        Console.WriteLine("Enter version: ");
                        Console.Write("Release number: ");
                        programs[amountOfData].version.releaseNumber =
                            Console.ReadLine();
                        Console.Write("Month: ");
                        programs[amountOfData].version.month =
                            Convert.ToByte(Console.ReadLine());
                        Console.Write("Year: ");
                        programs[amountOfData].version.year =
                            Convert.ToUInt16(Console.ReadLine());
                        amountOfData++;
                    }
                    else
                    {
                        Console.WriteLine("Database if full");
                    }
                    break;

                case '2':
                    if (amountOfData != 0)
                    {
                        for (int i = 0; i < amountOfData; i++)
                        {
                            if (i % 20 == 19)
                            {
                                Console.WriteLine
                                    ("Please, press enter to continue");
                                Console.ReadLine();
                            }

                            else
                            {
                                Console.WriteLine("Data " + (i + 1) + ":");
                                Console.WriteLine("Name: " + programs[i].name);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Database is empty");
                    }
                    break;

                case '3':
                    string search;
                    bool found = false;

                    Console.Write("Enter name to search: ");
                    search = Console.ReadLine();

                    for (int i = 0; i < amountOfData; i++)
                    {
                        if (search == programs[i].name)
                        {
                            Console.WriteLine("Name: " + programs[i].name);
                            Console.WriteLine("Description: "
                                + programs[i].description);
                            Console.WriteLine
                                ("Version: "
                                + programs[i].version.month + "/"
                                + programs[i].version.year);
                            Console.WriteLine();
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine
                            ("Name doesn't match with availiable data");
                    }
                    break;

                case '4':
                    int modifyPosition;

                    Console.Write("Enter file to modify: ");
                    modifyPosition = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (modifyPosition >= amountOfData)
                    {
                        Console.WriteLine("There are not that many files");
                    }
                    else
                    {
                        Console.Write("Enter name: ");
                        programs[modifyPosition].name = Console.ReadLine();
                        Console.Write("Enter description: ");
                        programs[modifyPosition].description = Console.ReadLine();
                        Console.WriteLine("Enter version: ");
                        Console.Write("Month: ");
                        programs[modifyPosition].version.month =
                            Convert.ToByte(Console.ReadLine());
                        Console.Write("Year: ");
                        programs[modifyPosition].version.year =
                            Convert.ToUInt16(Console.ReadLine());
                    }
                    break;

                case '5':
                    int positionToDelete;

                    Console.Write("Which position to delete: ");
                    positionToDelete = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (positionToDelete >= amountOfData)
                    {
                        Console.WriteLine("There are not that many files");
                    }
                    else
                    {
                        for (int i = positionToDelete; i < amountOfData; i++)
                        {
                            programs[i] = programs[i + 1];
                        }
                        amountOfData--;
                    }
                    break;

                case 't':
                case 'T':
                    Console.WriteLine("Bye!!");
                    break;

                default:
                    Console.WriteLine("That's not a valid option");
                    break;
            }
        }
        while (option != 'T' && option != 't');
    }
}
