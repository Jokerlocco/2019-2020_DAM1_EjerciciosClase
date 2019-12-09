using System;

class FuncionIniciales
{
    static string Iniciales(string s)
    {
        s = s.ToUpper().Trim();
        string ini = ""+s[0];
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i-1] == ' ' && s[i] != ' ')
                ini += s[i];
        }
        
        return ini;
    }
    
    
    static void Main()
    {
        Console.WriteLine(Iniciales("Primero de Dam"));
        
        Console.Write("Frase: ");
        string frase = Console.ReadLine();
        Console.WriteLine(Iniciales(frase));
    }
}
