using System;

class Spaceship : Sprite
{
    public Spaceship()
    {
        x = 20;
        y = 15;
        symbol = 'X';
    }

    public void MoveLeft()
    {
        if (x >= 1)
            x--;
    }

    public void MoveRight()
    {
        if (x <= 78)
            x++;
    }
}
