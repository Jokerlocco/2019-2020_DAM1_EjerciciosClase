using System;

class Main2014
{
    static bool IsHarshadNumber(int num)
    {
        string digits = num.ToString();
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += Convert.ToInt32(
                digits.Substring(i, 1));
        }
        return num % sum == 0;
    }

    static void SolveQuadratic(double a, double b, double c,
                                            ref double x1, ref double x2)
    {
        double discriminant = (b * b) - 4.0 * a * c;

        if (discriminant < 0 || a == 0)
        {
            x1 = -9999;
            x2 = -9999;
        }
        else if (discriminant == 0)
        {
            x1 = -b / (2.0 * a);
            x2 = -9999;
        }
        else if (discriminant >= 0 && a != 0)
        {
            x1 = ((-b - Math.Sqrt(discriminant)) / (2.0 * a));
            x2 = ((-b + Math.Sqrt(discriminant)) / (2.0 * a));
        }
    }

    static string Reverse(string text)
    {
        // Base case
        if (text.Length == 0)
            return "";

        // General case
        return Reverse(text.Substring(1)) + text[0];

        /*
        Alternative way:
        return 
            text[ text.Length - 1] +
            Reverse(text.Substring(0, text.Length - 1));
        */
    }

    static void DrawParallelogram(int width, int height, char ch)
    {
        int spaces = 0;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < spaces; j++)
                Console.Write(" ");
            for (int x = 0; x < width; x++)
                Console.Write(ch);
            Console.WriteLine("");
            spaces++;
        }
    }

    static void Main(string[] args)
    {
        /*
        Console.WriteLine(  IsHarshadNumber(152) );
        Console.WriteLine(  IsHarshadNumber(153) );
        */
        
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: harshad / quadratic / para /  reverse");
        }
        else
        { 
            switch (args[0].ToLower())
            {
                case "harshad":
                    if (args.Length == 2)
                    {
                        int num = Convert.ToInt32(args[1]);
                        bool harshad = IsHarshadNumber(num);
                        if (harshad)
                            Console.WriteLine("It is a Harshad number");
                        else
                            Console.WriteLine("It is not a Harshad number");
                    }
                    else
                        Console.WriteLine("Missing parameters");
                    break;

                case "para":
                    if (args.Length == 3)
                        DrawParallelogram(
                            Convert.ToInt32(args[1]),
                            Convert.ToInt32(args[2]),
                            'X'
                        );
                    else
                        Console.WriteLine("Missing parameters");
                    break;

                case "reverse":
                    if (args.Length == 2)
                        Console.WriteLine(
                            Reverse(args[1]));
                    else
                        Console.WriteLine("Missing parameters");
                    break;

                case "quadratic":
                    if (args.Length == 3)
                    {
                        // ...
                    }
                    else
                        Console.WriteLine("Missing parameters");
                    break;

                default:
                    Console.WriteLine("Usage: " +
                        "harshad / quadratic / para /  reverse");
                    break;
            }
        }
    }
}
