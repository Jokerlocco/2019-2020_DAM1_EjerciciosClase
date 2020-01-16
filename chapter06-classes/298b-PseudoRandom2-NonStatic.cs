/*
Create a class named "PseudoRandom".

In it, create a static method "Get0To999" which will return 
the milliseconds of the current system clock.

Create a "Main" to test it.
*/

using System;

class PseudoRandom
{
    public int Get()
    {
        return DateTime.Now.Millisecond;
    }
}

// --------------------------------

class PseudoRandomTest
{
    static void Main()
    {
        Console.WriteLine( new PseudoRandom().Get() );
    }
}
