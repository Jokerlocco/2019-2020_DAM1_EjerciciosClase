// Sergio Gumpert
using System;


class Dispositivo
{
    public int Velocidad { get; set; }
    public double Pulgadas { get; set; }

    public Dispositivo (int Velocidad, double Pulgadas)
    {
        this.Velocidad = Velocidad;
        this.Pulgadas = Pulgadas;
    }

    public override string ToString()
    {
        return Velocidad + " MHz, " + Pulgadas + " pulgadas.";
    }
}


class Tactil : Dispositivo
{

    public Tactil(int Velocidad, double Pulgadas) : base(Velocidad, Pulgadas)
    {

    }
    public override string ToString()
    {
        return base.ToString();
    }

}
class Smartphone : Tactil
{

    public Smartphone(int Velocidad, double Pulgadas) 
                                        : base(Velocidad, Pulgadas)
    { 
    }

    public override string ToString()
    {
        return "Smartphone " + base.ToString() ;
    }
}

class Tablet : Tactil
{ 

    public Tablet(int Velocidad, double Pulgadas) 
                                        : base(Velocidad, Pulgadas)
    { 
    }

    public override string ToString()
    {
        return "Tablet " + base.ToString() ;
    }
}

class ConTeclado : Dispositivo
{

    public ConTeclado(int Velocidad, double Pulgadas) : base(Velocidad, Pulgadas)
    {

    }
    public override string ToString()
    {
        return base.ToString();
    }

}

class Ordenador : ConTeclado
{

    public Ordenador(int Velocidad, double Pulgadas)
                                        : base(Velocidad, Pulgadas)
    {
    }

    public override string ToString()
    {
        return "Ordenador " + base.ToString();
    }
}


class Prueba
{
    static void PedirDatos(ref int velocidad, ref double pulgadas)
    {
        velocidad = 0;
        pulgadas = 0;

        Console.WriteLine("Introduce la velocidad");
        velocidad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce las pulgadas");
        pulgadas = Convert.ToDouble(Console.ReadLine());
    }
    static void Main()
    {
        const int MAX = 100;
        int opcion = 1;
        int cantidad = 0;
        int opcion2 = 0;
        int velocidad = 0;
        double pulgadas = 0;
        Dispositivo[] Dispositivos = new Dispositivo[MAX];
        do
        {
            Console.WriteLine("1- Crear nuevo dispositivo");
            Console.WriteLine("2- Consultar dispositivos");
            Console.WriteLine("0- Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    {
                        if (cantidad >= MAX)
                            Console.WriteLine("Base de datos llena.");
                        else
                        {
                            Console.WriteLine("Que deseas crear");
                            Console.WriteLine("1- Smartphone");
                            Console.WriteLine("2- Tablet");
                            Console.WriteLine("3- Ordenador");
                            Console.WriteLine("0- Salir");
                            opcion2 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion2)
                            {
                                case 1:
                                    {
                                        PedirDatos(ref velocidad, ref pulgadas);
                                        Dispositivos[cantidad] = new
                                            Smartphone(velocidad, pulgadas);
                                        cantidad++;
                                        break;
                                    }
                                case 2:
                                    {
                                        PedirDatos(ref velocidad, ref pulgadas);
                                        Dispositivos[cantidad] = new 
                                            Tablet(velocidad, pulgadas);
                                        cantidad++;
                                        break;
                                    }
                                case 3:
                                    {
                                        PedirDatos(ref velocidad, ref pulgadas);
                                        Dispositivos[cantidad] = new 
                                                Ordenador(velocidad, pulgadas);
                                        cantidad++;
                                        break;
                                    }
                                case 0:
                                    Console.WriteLine("Operacion cancelada");
                                    break;
                                default:
                                    Console.WriteLine("Opcion no valida.");
                                    break;
                            }

                        }
                            break;
                    }
                case 2:
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine(i + 1 + ". " + Dispositivos[i]);
                        }
                        break;
                    }
                case 0:
                    Console.WriteLine("Adios");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

        } while (opcion != 0);
    }
}
