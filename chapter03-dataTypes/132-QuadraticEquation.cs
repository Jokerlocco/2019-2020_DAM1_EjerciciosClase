// Jose Valera

using System;

class EcuacionSegundoGrado
{
    static void Main()
    {
        double a, b, c, resultado1, resultado2;
        double discriminante;
        
        Console.Write("A (Número multiplicado por X^2): ");
        a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("B (Número multiplicado por X): ");
        b = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("C (Término independiente): ");
        c = Convert.ToDouble(Console.ReadLine());
        
        discriminante = (Math.Pow(b, 2) - 4 * a * c);
        
        if (a == 0 || discriminante < 0)
            Console.WriteLine
                ("Ecuacion sin soluciones reales");
        
        else
        {
            resultado1 = ((-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) 
                / (2.0 * a));
                
            resultado2 = ((-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) 
                / (2.0 * a));
                
            if (resultado1 == resultado2)
                Console.WriteLine
                    ("Valor de \"X\": {0}",
                    resultado1);
            
            else
                Console.WriteLine
                    ("Valor de \"X\": X1= {0} X2= {1}",
                    resultado1, resultado2);
        }
    }
}
