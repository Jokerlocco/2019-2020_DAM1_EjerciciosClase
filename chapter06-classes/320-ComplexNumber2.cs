// Pablo Vigara Fernandez

using System;

class ComplexNumber
{
    protected double Real { get; set; }
    protected double Imag { get; set; }

    public ComplexNumber(double real, double imag)
    {
        this.Real = real;
        this.Imag = imag;
    }

    public override string ToString()
    {
        return "(" + Real + ", " + Imag + ")";
    }

    public double GetMagnitude()
    {
        return Math.Sqrt(Real * Real + Imag * Imag);
    }

    public static ComplexNumber operator + (ComplexNumber n1, ComplexNumber n2)
    {
        return new ComplexNumber(n1.Real + n2.Real, n1.Imag + n2.Imag);
    }

    public static ComplexNumber operator - (ComplexNumber n1, ComplexNumber n2)
    {
        return new ComplexNumber(n1.Real - n2.Real, n1.Imag - n2.Imag);
    }

    public static ComplexNumber Sumar(ComplexNumber n1, ComplexNumber n2)
    {
        return new ComplexNumber(n1.Real + n2.Real, n1.Imag - n2.Imag);
    }
} 
 
class Program
{
    static void Main()
    {
        ComplexNumber n1 = new ComplexNumber(2, -3);
        ComplexNumber n2 = new ComplexNumber(4, -6);

        Console.WriteLine("Primer numero complejo: " + n1 
            + " , Magnitud: " + n1.GetMagnitude());
        Console.WriteLine("Segundo numero complejo: " 
            + n2 + " , Magnitud: " + n2.GetMagnitude());

        ComplexNumber n3 = n1 + n2;
        Console.WriteLine("Suma sobrecargando el operador: " + n3);

        Console.WriteLine("Resta sobrecargando el operador: " + (n3 - n2));

        ComplexNumber.Sumar(n1, n2);
        Console.WriteLine("La suma del primero y del segundo = " 
            + ComplexNumber.Sumar(n1, n2));
    }
}
