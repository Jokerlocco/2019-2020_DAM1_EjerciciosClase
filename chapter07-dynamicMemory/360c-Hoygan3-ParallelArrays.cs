// Pablo Vigara Fernandez

using System;
using System.Collections.Generic;

class Ejercicio
{
    static void Main()
    {
        string[] hoygan = new string[100];
        //hoygan porfabor nesecito alluda grasias
        //hoygan me pueden alludar en este ejersisio
        string[] esp = new string[100];
        hoygan[0] = "hoygan";
        hoygan[1] = "porfabor";
        hoygan[2] = "nesecito";
        hoygan[3] = "alluda";
        hoygan[4] = "grasias";
        hoygan[5] = "alludar";
        hoygan[6] = "ejersisio";

        esp[0] = "escuchad";
        esp[1] = "por favor";
        esp[2] = "necesito";
        esp[3] = "ayuda";
        esp[4] = "gracias";
        esp[5] = "ayudar";
        esp[6] = "ejercicio";

        Console.Write("Frase en Hoygan: ");
        string texto = Console.ReadLine();

        string[] partes = texto.Split(" ");

        for (int i = 0; i < partes.Length; i++)
        {
            bool encontrado = false;
            for (int j = 0; j < hoygan.Length; j++)
            {
                if (hoygan[j] == partes[i])
                {
                    encontrado = true;
                    Console.Write(esp[j]);
                    break;
                }
            }
            if (!encontrado)
                Console.Write(partes[i] + " ");
            else
                Console.Write(" ");
        }
    }
}
