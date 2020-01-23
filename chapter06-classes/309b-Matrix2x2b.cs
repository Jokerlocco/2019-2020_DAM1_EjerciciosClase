using System;
class Matrix2x2
{
    public double[,] matrix;

    public Matrix2x2(double d00, double d01, double d10, double d11)
    {
        matrix = new double[2, 2];
        matrix[0, 0] = d00;
        matrix[0, 1] = d01;
        matrix[1, 0] = d10;
        matrix[1, 1] = d11;
    }

    public Matrix2x2() : this (0, 0, 0, 0)
    {
    }

    public void Multiply(double n)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matrix[i, j] *= n;
            }
        }
    }

    public void Add(Matrix2x2 m2)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matrix[i, j] += m2.matrix[i, j];
            }
        }
    }

    public static Matrix2x2 operator + (
        Matrix2x2 m1, Matrix2x2 m2 )
    {
        Matrix2x2 m3 = new Matrix2x2();
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                m3.matrix[i, j] = m1.matrix[i, j] + m2.matrix[i, j];
            }
        }
        return m3;
    }

    public override string ToString()
    {
        string texto = "";

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                texto += matrix[i, j];
                if (j != 2 - 1)
                    texto += "     ";
            }
            if (i != 2 - 1)
            texto += "\n";
        }

        return texto;
    }

    public void Display()
    {
        Console.WriteLine( this );
    }

    public double GetData(int row, int column)
    {
        return matrix[row, column];
    }

    public void SetX(int row, int column, double val)
    {
        matrix[row, column] = val;
    }
}

// -----------------------

class Program
{
    static void Main()
    {
        const int MAX = 2;
        Matrix2x2[] matrix = new Matrix2x2[MAX];

        for (int i = 0; i < MAX; i++)
        {
            Console.WriteLine("Matrix2x2 nº" + (i + 1) + ":");
            Console.Write("Data row 1, 1: ");
            double d00 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Data row 1, 2: ");
            double d01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Data row 2, 1: ");
            double d10 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Data row 2, 2: ");
            double d11 = Convert.ToDouble(Console.ReadLine());

            matrix[i] = new Matrix2x2(d00, d01, d10, d11);
        }

        matrix[1].Multiply(2);
        Matrix2x2 sum = matrix[0] + matrix[1];

        for (int i = 0; i < MAX; i++)
        {
            matrix[i].Display();
            Console.WriteLine("----------------------------");
        }
        Console.WriteLine(sum.ToString());
    }
}
