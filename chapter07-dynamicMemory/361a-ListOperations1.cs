//Kiko
using System;
using System.Collections.Generic;
using System.IO;

class ListaString
{
    static void Main()
    {
        List<string> lista;
        if (File.Exists("361.txt"))
            lista = new List<string>(File.ReadAllLines("360.txt"));
        else
            lista = new List<string>();

        string respuesta;
        do
        {
            Console.WriteLine("A- añadir una nueva cadena al final de la lista");
            Console.WriteLine("B- Buscar una cadena.");
            Console.WriteLine("V- visualizar todos los datos");
            Console.WriteLine("I- insertar una nueva cadena en una posicion");
            Console.WriteLine("E- eliminar una cierta cadena");
            Console.WriteLine("M- modificar una cadena en una posición.");
            Console.WriteLine("O- Ordenar los datos");
            Console.WriteLine("S- salir");
            respuesta = Console.ReadLine().ToLower();

            switch(respuesta)
            {
                case "a":
                    Console.WriteLine("Introduce la nueva cadena");
                    lista.Add(Console.ReadLine());
                    break;

                case "b":
                    Console.WriteLine("Introduce el texto a buscar");
                    string texto = Console.ReadLine().ToLower();
                    bool encontrado = false;
                    for(int i = 0; i < lista.Count;i++)
                    {
                        if(lista[i].ToLower()==texto)
                        {
                            Console.WriteLine(lista[i]);
                            encontrado = true;
                        }
                    }
                    if(encontrado)
                    {
                        Console.WriteLine("No está");
                    }
                    break;

                case "v":
                    foreach (string d in lista)
                    {
                        Console.WriteLine(d);
                    }
                    break;

                case "i":
                    Console.WriteLine("Posicion en la que deseas insertar"  );
                    int posicion = Convert.ToInt32(Console.ReadLine()) - 1;
                    if(posicion <0 || posicion > lista.Count)
                    {
                        Console.WriteLine("Posición invalida.");
                    }
                    else
                    {
                        Console.WriteLine("Texto que deseas insertar");
                        lista.Insert(posicion, Console.ReadLine());
                    }
                    break;

                case "e":
                    Console.WriteLine("Posicion  que deseas borrar");
                    posicion = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (posicion < 0 || posicion > lista.Count)
                    {
                        Console.WriteLine("Posición invalida.");
                    }
                    else
                    {                        
                        lista.RemoveAt(posicion);
                    }
                    break;

                case "m":
                    Console.WriteLine("Posicion  que deseas modificar");
                    posicion = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (posicion < 0 || posicion > lista.Count)
                    {
                        Console.WriteLine("Posición invalida.");
                    }
                    else
                    {
                        Console.WriteLine("El texto es: "+ lista[posicion]);
                        lista.RemoveAt(posicion);
                        Console.WriteLine("Cual quieres que sea:");
                        lista.Insert(posicion, Console.ReadLine());

                    }
                    break;

                case "o":
                    lista.Sort();
                    break;
                
                case "s": Console.WriteLine("Adios"); break;

                default: Console.WriteLine("Error");break;

            }

        } while (respuesta != "s");
        File.WriteAllLines("361.txt", lista.ToArray());
    }
       
}
