using System;

class Hexagon
{
    static void Main()
    {
        double radius;
        double perimeter, area;

        do
        {
            Console.Write("Enter the radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            if (radius != 0)
            {
                perimeter = 6*radius;
                area = Math.Pow(radius, 2) *
                    3 * Math.Sqrt(3) / 2.0;
                Console.WriteLine("Perimeter = {0}", perimeter);
                Console.WriteLine("Area = {0}", area);
            }

        }
        while (radius != 0);
    }
}
