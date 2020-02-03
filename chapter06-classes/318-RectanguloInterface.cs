//Francisco  Jimenez Velasco
using System;

interface IDibujable
{
    void Dibujar();
}

interface IMedible
{
    double GetArea();
}

class RectanguloEnPantalla : IDibujable, IMedible
{
    protected double x1, x2;
    protected double y1, y2;

    public double GetArea()
    {
        return (x1 * x2) + (y1 * y2);
    }

    public void Dibujar()
    {

    }
}
