/*

Create a "Matrix2x2" class, which will represent an array of real 
numbers, with 2 rows and 2 columns. It must contain the following 
methods:

- A constructor that receives the two values ​​of the first row and the 
  two of the second: Matrix2x2 (f1a, f1b, f2a, f2b)

- A second constructor without arguments, which sets all values ​​to 0

- Multiply (n), which will multiply all the elements by a certain value.

- Add (m2) that adds a second matrix element by element.

- You must overload the sum operator, so that they can also be added 
  in a more "natural" way.

- ToString, which will return a string similar to "2 -7 \ n -3 4".

- Display, which will write the matrix on the screen.

There should be a getter with the format Get (row, column) and a setter 
with the format Set (row, column, value)

The test program should create asking the user of two matrices A and B, 
multiplying the second one by two, adding A and B in a new matrix C and 
displaying the three matrices on the screen, separated by blank lines.

*/

using System;

class Matrix2x2
{
    public double r1c1, r1c2, r2c1, r2c2;
    //double[] data;

    public Matrix2x2(double r1c1, double r1c2,
        double r2c1, double r2c2)
    {
        this.r1c1 = r1c1;
        this.r1c2 = r1c2;
        this.r2c1 = r2c1;
        this.r2c2 = r2c2;

        //data = new double[2, 2];
        //data[0,0] = r1c1;
    }

    public Matrix2x2() : this(0,0,0,0)
    {
    }

    public void Multiply(double n)
    {
        r1c1 *= n;
        r1c2 *= n;
        r2c1 *= n;
        r2c2 *= n;
    }

    public void Add(Matrix2x2 m2)
    {
        r1c1 += m2.r1c1;
        r1c2 += m2.r1c2;
        r2c1 += m2.r2c1;
        r2c2 += m2.r2c2;
    }

    public static Matrix2x2 operator + (
        Matrix2x2 m1, Matrix2x2 m2)
    {
        return new Matrix2x2(
            m1.r1c1 + m2.r1c1,
            m1.r1c2 + m2.r1c2,
            m1.r2c1 + m2.r2c1,
            m1.r2c2 + m2.r2c2);
        // newMatrix.data[i,j] = m1.data[i,j] + m2.data[i,j]
    }

    public override string ToString()
    {
        return r1c1 + "  " + r1c2 + "\n"
            + r2c1 + "  "+ r2c2;
    }

    public void Display()
    {
        Console.WriteLine( this );
    }

    public double Get(int row, int col)
    {
        // return data[row, col];
        if ((row == 0) && (col == 0))
            return r1c1;
        else if ((row == 0) && (col == 1))
            return r1c2;
        else if ((row == 1) && (col == 0))
            return r2c1;
        else if ((row == 1) && (col == 1))
            return r2c2;
        else throw new IndexOutOfRangeException();
    }

    public void Set(int row, int col, double val)
    {
        // data[row, col] = val;
        if ((row == 0) && (col == 0))
            r1c1 = val;
        else if ((row == 0) && (col == 1))
            r1c2 = val;
        else if ((row == 1) && (col == 0))
            r2c1 = val;
        else if ((row == 1) && (col == 1))
            r2c2 = val;
        else throw new IndexOutOfRangeException();
    }
}


class Matriz2x2Test
{
    static void Main()
    {
        Console.Write("Enter data 1,1: ");
        double a = Convert.ToDouble( Console.ReadLine() );
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

        Console.WriteLine( A+B );
    }
}

