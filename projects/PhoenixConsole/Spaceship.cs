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
        x--;
    }

    public void MoveRight()
    {
        x++;
    }
}

