//Lautaro Álvaro Fernández

using System;

class QuadraticEquation
{
    static void SolveQuadratic( double a, double b, double c,
                                            ref double x1, ref double x2 )
    {
        double discriminant = (b*b)-4.0*a*c;
        
        if ( discriminant < 0 || a == 0 )
        {
            x1 = -9999;
            x2 = -9999;
        }
        else if ( discriminant == 0 )
        {
            x1 = - b / (2.0*a);
            x2 = -9999;
        }
        else if ( discriminant >= 0 && a != 0 )
        {
            x1 = ( ( -b-Math.Sqrt( discriminant ) ) / (2.0*a) );
            x2 = ( ( -b+Math.Sqrt( discriminant ) ) / (2.0*a) );
        }
    }
    
    static void Main()
    {
        double a = 1, b = 0, c = -9;
        double x1 = 1234, x2 = -5678;
        SolveQuadratic(a,b,c, ref x1, ref x2);
        Console.WriteLine("Solutions are " + x1 + " y " + x2);
    }
}

