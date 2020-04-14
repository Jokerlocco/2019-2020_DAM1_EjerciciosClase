/* ISBN

Ejemplos de entrada:

0201103311
156881111x
0201103411
15688?111X

Salida correspondiente

El ISBN es válido
El ISBN es válido
El ISBN no es válido
El dígito que falta es 1
*/

//kiko 
using System;

class Isbn
{
    static void Main()
    {
        bool salir = false;
        do
        {
            Console.WriteLine("Introduce el código :");
            string numero = Console.ReadLine().ToLower();          
            int total = 0;
            int posicion = 10;
            bool caracterPerdido = false;
            int posicionPerdida = 1;

            for (int i = 0; i < numero.Length - 1; i++)
            {
                if (numero[i] != '?')
                {
                    total += (Convert.ToInt32(
                              Convert.ToString(numero[i])) * posicion);
                }
                else
                {
                    caracterPerdido = true;
                    posicionPerdida = posicion;
                }
                posicion--;
            }

            if (numero[numero.Length - 1] == 'x')
            {
                total += 10;
            }
            else
            {
                total += Convert.ToInt32(
                         Convert.ToString(numero[numero.Length - 1]));
            }

            if (caracterPerdido)
            {
                int combinacionGanadora = total;

                while (combinacionGanadora % 11 != 0)
                {
                    combinacionGanadora = total;
                    combinacionGanadora += posicionPerdida * posicion;

                    if (combinacionGanadora % 11 != 0)
                    {
                        posicion++;
                    }
                    else
                        Console.WriteLine("El dígito que falta es " + posicion);
                }
            }

            else
            {
                if (total % 11 == 0)
                    Console.WriteLine("El ISBN es válido ");
                else
                    Console.WriteLine("El ISBN no es válido");
            }
        } while (!salir);

    }
}
