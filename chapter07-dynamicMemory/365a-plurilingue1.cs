// Abraham García Ortuño

using System;
using System.Collections.Generic;
using System.IO;


class Plurilingue
{
    static void Main()
    {
        String[] ingles = File.ReadAllLines("es-en");
        String[] frances = File.ReadAllLines("es-fr");


        Dictionary<string, string> espIng = new Dictionary<string, string>();
        Dictionary<string, string> espFran = new Dictionary<string, string>();

        for (int i = 0; i < ingles.Length; i++)
           espIng[ingles[i].Split('=')[0]] = ingles[i].Split('=')[1];

        for (int i = 0; i < frances.Length; i++)
            espFran[frances[i].Split('=')[0]] = frances[i].Split('=')[1];

        int op;

        do
        {
            Console.WriteLine("1- Español a inglés");
            Console.WriteLine("2- Inglés a español");
            Console.WriteLine("3- Francés a inglés");
            Console.WriteLine("4- Inglés a francés");
            Console.WriteLine("5- Español a francés");
            Console.WriteLine("6- Francés a español");
            Console.WriteLine("Introduce una opción: ");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Elige palabra a traducir: ");
                    string palabra = Console.ReadLine();
                    if (espIng.ContainsKey(palabra))
                        Console.WriteLine("Su traducción es: " + espIng[palabra]);
                    else
                        Console.WriteLine("Palabra no encontrada");
                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:
                    Console.WriteLine("Elige palabra a traducir: ");
                    string palabraF = Console.ReadLine();
                    if (espIng.ContainsValue(palabraF))
                    {
                        palabraF = espIng[palabraF];
                        if (espFran.ContainsKey(palabraF))
                            Console.WriteLine("Su traducción es: " + espFran[palabraF]);
                        else
                            Console.WriteLine("Palabra no encontrada");


                    }

                    break;

                case 5:

                    break;

                case 6:

                    break;

                case
            }
        } while (op != 0);
    }
}

