// Pablo Vigara Fernández && Sergio Gumpert

using System;
using System.Threading;

class Pong
{
    static void Main()
    {
        Console.SetWindowSize(80, 26);
        Console.SetBufferSize(80, 26);
        int y1 = 12;
        int x1 = 4;
        int y2 = 12;
        int x2 = 75;
        int xBall = 40, yBall = 5;
        int xSpeed = 1, ySpeed = 1;
        int leftCount = 0 ,rightCount = 0;
        bool finished = false;
        ConsoleKeyInfo userkey;
        do
        {
            Console.Clear();
            
            // Borde arriba
            Console.SetCursorPosition(2, 1);
            Console.Write("______________________________________________");
            Console.Write("________________________________");
            
            // Borde abajo
            Console.SetCursorPosition(2, 25);
            Console.Write("______________________________________________");
            Console.Write("________________________________");
            
            // Borde izquierdo
            for (int i = 1; i < 25; i++)
            {
                Console.SetCursorPosition(1, i );
                Console.Write("|");
            }
            
            // Border derecho
            for (int i = 1; i < 25; i++)
            {
                Console.SetCursorPosition(79, i );
                Console.Write("|");
            }
            
            // Medio campo
            for (int i = 1; i < 25; i++)
            {
                Console.SetCursorPosition(40, i );
                Console.Write("|");
            }
            
            // Pala izquierda
            Console.SetCursorPosition(x1, y1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("||");
            Console.SetCursorPosition(x1, y1 + 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("||");
            Console.SetCursorPosition(x1, y1 - 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("||");
            
            // Pala derecha
            Console.SetCursorPosition(x2, y2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("||");
            Console.SetCursorPosition(x2, y2 + 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("||");
            Console.SetCursorPosition(x2, y2 - 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("||");

            // Pelota
            Console.SetCursorPosition(xBall, yBall);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("O");

            // Contador
            Console.SetCursorPosition(39, 2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(leftCount + "-" + rightCount);

            Console.SetCursorPosition(1, 1);

            // Controlador posicion palas
            if (Console.KeyAvailable)
            {
                userkey = Console.ReadKey(true);

                if ((userkey.Key == ConsoleKey.W) && (y1 > 2))
                    y1--;
                if ((userkey.Key == ConsoleKey.S) && (y1 < 23))
                    y1++;
                if ((userkey.Key == ConsoleKey.UpArrow) && (y2 > 2))
                    y2--;
                if ((userkey.Key == ConsoleKey.DownArrow) && (y2 < 23))
                    y2++;

                if (userkey.Key == ConsoleKey.Escape)
                    finished = true;
            }

            // Gol
            if (xBall == 1)
            {
                rightCount++;
                xBall = 40 ; yBall = 12;
            }
            
            if (xBall == 79)
            {
                leftCount++;
                xBall = 40 ; yBall = 12;
            }
            
            // Rebote con pala
            if (xBall == 5 && (yBall == y1 
                || yBall == y1 + 1 || yBall == y1 - 1))
            {
                xSpeed = -xSpeed;
                ySpeed = -ySpeed;
            }
            if (xBall == 75 && (yBall == y2 
                || yBall == y2 + 1 || yBall == y2 - 1))
            {
                xSpeed = -xSpeed;
                ySpeed = -ySpeed;
            }
            
            // Movimiento normal
            xBall += xSpeed;
            yBall += ySpeed;
            
            // Rebote con borde
            if ((xBall <= 1) || (xBall >= 79))
                xSpeed = -xSpeed;
            if ((yBall <= 1) || (yBall >= 24))
                ySpeed = -ySpeed;
            
            
            Thread.Sleep(100);
        }
        while ( ! finished );

        Console.ForegroundColor = ConsoleColor.White;
    }
}
