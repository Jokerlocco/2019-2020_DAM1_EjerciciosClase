//Abraham García + Nacho - Treasurekeeper Robot

/*
Reto 8.01 - Robot busca-tesoros

Mediante un sistema de fotografía espía hemos podido observar en una cuadrícula 
una isla desierta. Toda isla desierta contiene un tesoro y también hemos podido 
localizarlo. Para recuperar el tesoro, hemos enviado a nuestro robot 
'Robotinho' a buscarlo. Este robot solo puede moverse en vertical y en 
horizontal (en futuras versiones se implementará el movimiento en diagonal ;) 
). 

Usando la imagen obtenida, hemos podido establecer una cuadrícula indicando la 
posición donde comienza nuestro robot, la posición del tesoro y si una casilla 
de la cuadrícula es atravesable por el robot o no.

Nuestra misión es desarrollar un programa que diga si el robot puede llegar 
hasta el tesoro o no.

Entrada

En la primera línea tendremos dos enteros N (ancho) y M (largo) indicando el 
tamaño de la isla. En la segunda línea tendremos las coordenadas de inicio del 
robot RX y RY . En la tercera línea tendremos las coordenadas del tesoro TX y 
TY . En la cuarta línea tendremos el número de celdas no atravesables O. Las 
casillas del robot y del tesoro siempre serán distintas y ninguna estará 
marcada como no atravesable.

2 <= N <= 20
2 <= M <= 20
1 <= RX <= N
1 <= RY <= M
1 <= TX <= N
1 <= TY <= M
0 <= O <= 300

Las siguientes O líneas indicarán las coordenadas de cada zona no atravesable.

Salida

Si el tesoro es alcanzable, se mostrará la palabra TESORO. En caso contrario, 
se mostrará la palabra IMPOSIBLE.

Ejemplo de entrada
10 10
1 1
3 3
2
1 2
4 3

Ejemplo de salida
TESORO

Ejemplo de entrada
4 4
1 1
4 4
2
1 2
2 1

Ejemplo de salida
IMPOSIBLE

10 5
6 1
7 3
2
1 2
4 3

Ejemplo de salida
TESORO
*/

using System;

class robot
{

    static bool debugging = true;

    static void Main()
    {
        // Read map size
        if (debugging)
            Console.Write("Map Size ('X' 'Y'): ");
        string[] size = Console.ReadLine().Split();
        int width = Convert.ToInt32(size[0]);
        int height = Convert.ToInt32(size[1]);
    
        // Create map and fill it
        char[,] map = new char[width, height];
        for (int col = 0; col < map.GetLength(0); col++)
        {
            for (int row = 0; row < map.GetLength(1); row++)
            {
                map[col, row] = '.';
            }
        }

        if (debugging)
            ShowMap(map);

        // Robot start
        if (debugging)
            Console.Write("Robot Start ('X' 'Y'): ");
        string[] rs = Console.ReadLine().Split();
        int rx = Convert.ToInt32(rs[0]) - 1;
        int ry = Convert.ToInt32(rs[1]) - 1;
        map[rx, ry] = 'R';

        if (debugging)
            ShowMap(map);

        // Treasure position
        if (debugging)
            Console.Write("Treasure ('X' 'Y'): ");
        string[] ts = Console.ReadLine().Split();
        int tx = Convert.ToInt32(ts[0]) - 1;
        int ty = Convert.ToInt32(ts[1]) - 1;
        map[tx, ty] = 'T';

        if (debugging)
            ShowMap(map);

        // Blocked cells
        if (debugging)
            Console.Write("Blocked cells: ");
        int bCells = Convert.ToInt32(Console.ReadLine());

        for (int b = 0; b < bCells; b++)
        {
            if (debugging)
                Console.Write("Cell " + (b + 1) + "('X' 'Y'): ");
            string[] cell = Console.ReadLine().Split();
            int cx = Convert.ToInt32(cell[0]) - 1;
            int cy = Convert.ToInt32(cell[1]) - 1;
            map[cx, cy] = 'X';
        }

        if (debugging)
            ShowMap(map);

        // And finally... let's start searching...
        if (TreasureCanBeFound(map, rx, ry))
            Console.WriteLine("TESORO");
        else
            Console.WriteLine("IMPOSIBLE");
    }


    static void ShowMap(char[,] map)
    {
        for (int row = 0; row < map.GetLength(1); row++)
        {
            for (int col = 0; col < map.GetLength(0); col++)
            {
                Console.Write(map[col, row]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }


    static bool TreasureCanBeFound(char[,] map, int startX, int startY)
    {
        // If we have arrived out of the map, this way is not good
        if (startY < 0) return false;
        if (startY > map.GetLength(1) - 1) return false;
        if (startX < 0) return false;
        if (startX > map.GetLength(0) - 1) return false;

        // If the cell is blocked, this way is not good, too
        if (map[startX, startY] == 'X') return false;

        // If we have reached the treasure, we finished happily ;-)
        if (map[startX, startY] == 'T') return true;

        // If we have already visited this cell, we should stop, too
        if (map[startX, startY] == 'V') return false;

        // Otherwise, let's tag the cell as visited and recurse
        map[startX, startY] = 'V';

        if (debugging)
            ShowMap(map);

        return TreasureCanBeFound(map, startX + 1, startY)
            || TreasureCanBeFound(map, startX, startY + 1)
            || TreasureCanBeFound(map, startX - 1, startY)
            || TreasureCanBeFound(map, startX, startY - 1);
    }
}
