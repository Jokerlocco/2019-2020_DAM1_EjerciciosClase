//Abraham García - Reto 5.04 - Andando en diagonal

/*
input
5
RUURU
output
3

input
17
UUURRRRRUUURURUUU
output
13

input
4
RURU
output
2

input
4
URUR
output
2
 
input
4
UURUR
output
3
*/


using System;

class Diagonal
{
    static void Main()
    {
        int cantidadLetras = Convert.ToInt32(Console.ReadLine());
        string direcciones = Console.ReadLine();
        int resultado = 0;

        do
        {
            if (direcciones.Length > 1)
            {
                if ((direcciones[0] == 'R' && direcciones[1] == 'U') ||
                (direcciones[0] == 'U' && direcciones[1] == 'R'))
                    direcciones = direcciones.Remove(0, 2);
                else
                    direcciones = direcciones.Remove(0, 1);
            }
            else if (direcciones.Length == 1)
                direcciones = direcciones.Remove(0, 1);

            resultado++;
            
        } while (direcciones.Length != 0);

        Console.WriteLine(resultado);
    }
}
