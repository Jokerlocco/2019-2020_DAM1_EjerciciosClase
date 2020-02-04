//Abraham García

using System;

class ComplexNumber
{
    private int real;
    private int imag;

    public int GetReal() { return real; }
    public void SetReal(int real) { this.real = real; }

    public int GetImag() { return imag; }
    public void SetImag(int imag) { this.imag = imag; }

    public ComplexNumber(int real, int imag)
    {
        this.real = real;
        this.imag = imag;
    }

    public override string ToString()
    {
        return "(" + real + ", " + imag + ")";
    }

    public int GetMagnitude()
    {
        return (real * real) + (imag * imag);
    }

    public void Add(ComplexNumber n)
    {
        real += n.real;
        imag += n.imag;
    }
}

class Prueba
{
    static void Main()
    {
        ComplexNumber n1 = new ComplexNumber(4, 6);
        ComplexNumber n2 = new ComplexNumber(1, 9);

        Console.WriteLine(n1);
        Console.WriteLine(n1.GetMagnitude());
        n1.Add(n2);
        Console.WriteLine(n1);
    }
}
