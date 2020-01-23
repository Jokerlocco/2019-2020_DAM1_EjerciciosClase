/*
Crea una clase "Punto3D", que representará un punto en el espacio 3D, 
con coordenadas X, Y y Z. Debe contener los siguientes métodos:

- Un único constructor, que establezca los valores de X, Y y Z

- MoverA (x, y, z), que cambiará las coordenadas en las que se encuentra 
  el punto.

- DistanciaA (Punto3D p2), para calcular la distancia a otro punto 
  (pista: ¿recuerdas el teorema de Pitágoras...?).

- ToString, que devolverá una cadena similar a "(2, -7,0)".

Y, por supuesto, getters y setters (o propiedades).

El programa de prueba debe crear una matriz de 5 puntos, pedir datos 
para ellos y finalmente calcular (y mostrar) la distancia que hay del 
primer punto a los cuatro restantes.
*/

//Francisco Jimenez Velasco

using System;
class Punto3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Punto3D(double x,double y,double z)
    {
        MoverA(x,y,z);
    }
    
    public void MoverA(double x,double y,double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    
    
    public double DistanciaA(Punto3D p)
    {
        double distancia = 
            Math.Sqrt(((p.X - X) * (p.X - X)) 
                + ((p.Y - Y) * (p.Y - Y)) 
                + ((p.Z - Z) * (p.Z - Z)));
        return distancia;
    }  
        
    public override string ToString()
    {
        return "(" + X + "," + Y + "," + Z + ")";
    }
}
class Programa
{
    static void Main()
    {
        const double MAX = 5;
        Punto3D[] p = new Punto3D[MAX];
        for(int i = 0; i < MAX;i++)
        {
            Console.WriteLine("Punto: "+(i+1));
            Console.WriteLine("X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Z: ");
            double z = Convert.ToDouble(Console.ReadLine());
            p[i] = new Punto3D(x, y, z);
        }
        
        for(int i = 1; i < MAX;i++)
        {
            double distancia = p[0].DistanciaA(p[i]);
            Console.WriteLine("Del punto 1 al "+ (i+1)+
                ": "+distancia);
        }
    }
}
        
