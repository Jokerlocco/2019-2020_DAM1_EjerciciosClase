/*
Create a class called "Ball", which will contain part of what is expected in 
the Pong ball.

Its (public) attributes will be the x and y coordinates, and the speeds in X 
and Y axis.

It will have a method called "Draw", which will show the ball on the screen, at 
the coordinates indicated by the attributes, and a method called "Move", which 
will move it to the next position.

Create a clas "BallTest" with a "Main" to test it.
*/

//Hugo Gonzalez

using System;

class Ball
{
    public int x;
    public int y;
    public int speedX;
    public int speedY;

    public void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("O");
    }

    public void Move()
    {
        x += speedX;
        y += speedY;
    }

}
class PongTest
{
    static void Main()
    {
        Ball b = new Ball();
        b.x = 20;
        b.y = 5;
        b.speedX = 1;
        b.speedY = 1;
        b.Draw();

        Console.ReadLine();
        b.Move();
        b.Draw();
    }
}
