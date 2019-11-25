using System;

class FunctionWriteInverted1
{
    static void WriteInverted (string text)
    {
        for ( int i = text.Length-1 ; i >= 0 ; i-- )
        {
            Console.Write( text[i] );
        }
    }
    
    static void Main()
    {
        string text = "hola";
        WriteInverted(text);
    }
}
