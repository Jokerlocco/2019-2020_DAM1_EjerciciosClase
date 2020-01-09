// Spaceship
// Part of ConsolePhoenix

// Version    Date     By + Changes
// -------  --------  ------------------------------------
//  0.04     09-01-20  Nacho: Empty ActivateShield + DeactivateShield
//  0.03     09-01-20  ???: Checking limits
//  0.02     08-01-20  Nacho: Constructor, MoveLeft & MoveRight
//  0.01     08-01-20  Nacho: Empty skeleton

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

    public void ActivateShield()
    {
        // TO DO
    }

    public void DeactivateShield()
    {
        // TO DO
    }
}
