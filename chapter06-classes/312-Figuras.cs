// Pablo Vigara Fernandez

using System;

class Dibujo
{
    public void Guardar(string fichero)
    {
        Console.WriteLine("");
    }

    public void Cargar(string fichero)
    {
        Console.WriteLine("");
    }

    public void Incluir(Figura f)
    {
        Console.WriteLine("Figura incluida");
    }
}

// --------------

abstract class Figura
{
    public float X { get; set; }
    public float Y { get; set; }
    public int Color { get; set; }
    public float Angulo { get; set; }

    public Figura (float x, float y, int color, float angulo)
    {
        this.X = x;
        this.Y = y;
        this.Color = color;
        this.Angulo = angulo;
    }

    public void Dibujar() 
    { 
        Console.WriteLine("Me dibujo"); 
    }

    public void Rotar(float angulo) 
    { 
        this.Angulo = angulo; 
    }

    public void Desplazar(float dx, float dy)
    {
        this.X += dx;
        this.Y += dy;
    }

    public void Escalar(float ex, float ey)
    {
        this.X *= ex;
        this.Y *= ey;
    }
}

// --------------

class Linea : Figura
{
    public float XFinal { get; set; }
    public float YFinal { get; set; }

    public Linea(float x, float y, int color, float angulo, float xFinal, float yFinal)
        : base(x, y, color, angulo)
    {
        this.XFinal = xFinal;
        this.YFinal = yFinal;
    }
}

// --------------

class Polilinea : Figura
{
    public Polilinea(float x, float y, int color, float angulo)
        : base(x, y, color, angulo)
    {
    }

    public void IncluirSegmento(Linea linea)
    {

    }
}

// --------------

class Paralelogramo : Figura
{
    public float XFinal { get; set; }
    public float YFinal { get; set; }

    public Paralelogramo(float x, float y, int color, float angulo, float xFinal, float yFinal)
        : base(x, y, color, angulo)
    {
        this.XFinal = xFinal;
        this.YFinal = yFinal;
    }
}

// --------------

class Elipse : Figura
{
    public float Radio { get; set; }
    public float Radio2 { get; set; }

    public Elipse(float x, float y, int color, float angulo, float radio, float radio2)
        : base(x, y, color, angulo)
    {
        this.Radio = radio;
        this.Radio2 = radio2;
    }
}

// --------------

class Cuadrado : Paralelogramo
{
    public Cuadrado (float x, float y, int color, float angulo, float xFinal, float yFinal)
        : base(x, y, color, angulo, xFinal, yFinal)
    {

    }
}

// --------------

class Rectangulo : Paralelogramo
{
    public Rectangulo(float x, float y, int color, float angulo, float xFinal, float yFinal)
        : base(x, y, color, angulo, xFinal, yFinal)
    {

    }
}

// --------------

class Circulo : Elipse
{
    public Circulo(float x, float y, int color, float angulo, float radio, float radio2)
        : base(x, y, color, angulo, radio, radio2)
    {
    }
}

// --------------

class DibujarTest
{
    static void Main()
    {
        int opcion1;
        Figura[] figuras = new Figura[10];
        int contador = 0;
        do
        {
            Console.WriteLine("1 - Guardar");
            Console.WriteLine("2 - Cargar");
            Console.WriteLine("3 - Incluir");
            Console.WriteLine("4 - Crear una figura");
            Console.WriteLine("0 - Salir");
            opcion1 = Convert.ToInt32(Console.ReadLine());

            switch (opcion1)
            {
                case 0: Console.WriteLine("Hasta la proxima!"); break;
                case 1:
                case 2:
                case 3: Console.WriteLine("Opcion no valida"); break;
                case 4:
                    Console.Write("X: ");
                    float x = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Y: ");
                    float y = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Color: ");
                    int color = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Angulo: ");
                    float angulo = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Tipo: (pulsa enter si no tiene) ");
                    string tipo = Console.ReadLine().ToUpper();

                    switch(tipo)
                    {
                        /*
                        case "":
                            figuras[contador] = new Figura(x, y, color, angulo);
                            contador++;
                            break;
                        */
                        case "PARALELOGRAMO":
                            Console.Write("xFinal: ");
                            float xfinal = Convert.ToSingle(Console.ReadLine());
                            Console.Write("yFinal: ");
                            float yfinal = Convert.ToSingle(Console.ReadLine());
                            figuras[contador] = new Paralelogramo(x, y, color, angulo, xfinal, yfinal);
                            contador++;
                            break;
                        case "ELIPSE":
                            Console.Write("Radio: ");
                            float radio = Convert.ToSingle(Console.ReadLine());
                            Console.Write("Radio2: ");
                            float radio2 = Convert.ToSingle(Console.ReadLine());
                            figuras[contador] = new Elipse(x, y, color, angulo, radio, radio2);
                            contador++;
                            break;
                        case "LINEA":
                            Console.Write("xFinal: ");
                            float xfinal1 = Convert.ToSingle(Console.ReadLine());
                            Console.Write("yFinal: ");
                            float yfinal1 = Convert.ToSingle(Console.ReadLine());
                            figuras[contador] = new Linea(x, y, color, angulo, xfinal1, yfinal1);
                            contador++;
                            break;
                        default: Console.WriteLine("Opcion no valida"); break;
                    }
                    break;
            }
        }
        while (opcion1 != 0);


    }
}
