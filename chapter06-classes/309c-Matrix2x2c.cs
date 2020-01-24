//Pablo José Ferrándiz Navarro
using System;

class Matrix2x2
{
    double[] data = new double[4];

    public Matrix2x2(double p1, double p2, double p3, double p4)
    {
        data[0] = p1;
        data[1] = p2;
        data[2] = p3;
        data[3] = p4;
    }

    public Matrix2x2() : this(0, 0, 0, 0)
    {
    }

    public void Multiply(int n)
    {
        for (int i = 0; i < 4; i++)
        {
            data[i] *= n;
        }
    }

    public void Add(Matrix2x2 m2)
    {
        for (int i = 0; i < 4; i++)
        {
            data[i] += m2.data[i];
        }
    }

    public static Matrix2x2 operator +(Matrix2x2 m1, Matrix2x2 m2)
    {
        return new Matrix2x2(m1.data[0] + m2.data[0],
                             m1.data[1] + m2.data[1],
                             m1.data[2] + m2.data[2],
                             m1.data[3] + m2.data[3]);
    }

    public override string ToString()
    {
        return data[0] + " " + data[1] + "\n" + data[2] + " " + data[3];
    }

    public void Display()
    {
        Console.WriteLine(this);
    }

    public double Get(int row, int column)
    {
        int position = row * 2 + column;
        return data[position];
    }

    public void Set(int row, int column, double value)
    {
        int position = row * 2 + column;
        data[position] = value;
    }
}

class TestForMatrix2x2
{
    static void Main()
    {
        Console.Write("Enter data 1,1: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter data 1,2: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter data 2,1: ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter data 2,2: ");
        double d = Convert.ToDouble(Console.ReadLine());
        Matrix2x2 A = new Matrix2x2(a, b, c, d);

        Matrix2x2 B = new Matrix2x2();
        for (int row = 1; row < 3; row++)
        {
            for (int col = 1; col < 3; col++)
            {
                Console.Write("Enter data {0},{1}: ", row, col);
                double n = Convert.ToDouble(Console.ReadLine());
                B.Set(row - 1, col - 1, n);
            }
        }

        A.Multiply(2);

        A.Display();
        Console.WriteLine();
        B.Display();
        Console.WriteLine();

        Console.WriteLine(A + B);
    }
}
