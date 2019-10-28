//Ruth Martínez Iborra

/*

Nos han dicho que la siguiente serie infinita “converge”, es decir, se acerca 
cada vez más a un cierto número: 

1 + 1/2 + 1/4 + 1/8 + 1/16 + …

Crea un programa que pregunte al usuario cuántos sumandos desea y le muestre el 
valor de la suma hasta ese punto, así como la media de los últimos 3 sumandos 
(ese último detalle se mostrará sólo si el usuario introduce el número 3 u otro 
mayor). El programa se repetirá hasta que el usuario introduzca “fin” en vez de 
un número.
*/


using System;

class SerieConvergente
{
    static void Main()
    {
        string sumandosCadena;
        double suma, suma3ult, divisor;
        long sumandos;

        do
        {
            suma = 1;
            suma3ult = 0;
            divisor = 2;

            Console.Write("Sumandos (1 a 50, \"fin\" para terminar)? ");
            sumandosCadena = Console.ReadLine();
            if (sumandosCadena != "fin")
            {
                sumandos = Convert.ToInt64(sumandosCadena);
                if (sumandos < 1)
                {
                    Console.WriteLine("No se puede sumar menos de 1 término");
                }
                else if (sumandos == 1)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    for (long termino = 2; termino <= sumandos; termino++)
                    {
                        suma += 1.0 / divisor;
                        if (sumandos - termino <= 3)
                        {
                            suma3ult += 1.0/divisor;
                        }
                        divisor *= 2;
                    }
                    Console.Write("La suma vale " + suma);
                    
                    if (sumandos > 2)
                    {
                        Console.Write(". La media de los 3 últimos es " + 
                            suma3ult / 3.0);
                    }
                    Console.WriteLine();
                }
            }
        }
        while (sumandosCadena != "fin");
        Console.WriteLine("Sesión terminada");
    }
}
