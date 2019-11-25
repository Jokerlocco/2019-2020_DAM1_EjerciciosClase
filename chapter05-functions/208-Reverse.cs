using System;

class FunctionReverse
{
    static string Reverse(string text)
    {
        string reversed = "";
        for (int i = text.Length-1; i >= 0; i--)
        {
            reversed += text[i];
        }
        return reversed;
    }

    public static void Main()
    {
        Console.WriteLine(  Reverse("Hola")  );
        
        string a = Reverse("abcd");
    }
}
