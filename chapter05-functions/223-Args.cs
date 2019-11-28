using System;

class Args
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
            Console.WriteLine("Usage: multiply 2 3");
        else
        {
            int n1 = Convert.ToInt32( args[0] );
            int n2 = Convert.ToInt32( args[1] );
            Console.WriteLine( n1 * n2 );
        }
    }
}
