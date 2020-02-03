using System;

class Ordenador
{
    protected string nombre;
    protected Procesador procesador;
    protected Memoria memoria;

    public Ordenador(Procesador procesador, Memoria memoria, string nombre)
    {
        this.nombre = nombre;
        this.procesador = procesador;
        this.memoria = memoria;
    }
    public string GetNombre() { return nombre; }

    public override string ToString()
    {
        return nombre + ", " + procesador + ", " + 
            memoria.GetTamanyo();
    }
}

// ---------------

abstract class Procesador
{
    protected byte bits;
    protected double velocidad;
    protected string registros;

    public Procesador(byte bits, double velocidad, string registros)
    {
        this.bits = bits;
        this.velocidad = velocidad;
        this.registros = registros;
    }

    public byte GetBits() { return bits; }
    public double GetVelocidad() { return velocidad; }

    public void AnadirOrden(string codigo, string ensamblador)
    {
        throw new NotImplementedException();
    }

    public virtual void MostrarOrdenes()
    {
        Console.WriteLine("Lista de ordenes aun no disponible");
    }

    public override string ToString()
    {
        return bits + " bits, " + velocidad + " Mhz";
    }
}

// ---------------

class Memoria
{
    protected int tamanyo;
    protected byte[] informacion;

    public Memoria(int tamanyo)
    {
        this.tamanyo = tamanyo;
        informacion = new byte[tamanyo];
    }

    public Memoria(byte tamanyo, byte tamanyoBus)
        : this(tamanyo)
    {
        //TO DO implemente tamanyoBus
    }

    public int GetTamanyo() { return tamanyo; }
    public byte Get(byte posicion)
    {
        return informacion[posicion];
    }
    public void Set(byte posicion, byte valor)
    {
        informacion[posicion] = valor;
    }
}

// ---------------

class ProcesadorZ80 : Procesador
{
    public ProcesadorZ80(double velocidad)
        : base(8, velocidad, "A B C D E F H L")
    {
    }

    public override void MostrarOrdenes()
    {
        Console.Write("Z80: ");
        base.MostrarOrdenes();
    }

    public override string ToString()
    {
        return "Z80, " + base.ToString();
    }
}

// ---------------

class Procesador6502 : Procesador
{
    public Procesador6502(double velocidad)
        : base(8, velocidad, "A X Y")
    {
    }

    public override void MostrarOrdenes()
    {
        Console.Write("6502: ");
        base.MostrarOrdenes();
    }

    public override string ToString()
    {
        return "6502, " + base.ToString();
    }
}

// ---------------

class Emuladores
{
    static void Main()
    {
        int contadorOrdenador = 2;
        int contadorProcesador = 2;
        int contadorMemoria = 2;
        const int MAX = 100;

        Ordenador[] ordenadores = new Ordenador[MAX];
        Procesador[] procesadores = new Procesador[MAX];
        Memoria[] memorias = new Memoria[MAX];

        procesadores[0] = new ProcesadorZ80(3.5);
        memorias[0] = new Memoria(16384);
        ordenadores[0] =
            new Ordenador(procesadores[0], memorias[0],
                "ZxSpectrum");

        ordenadores[1] =
            new Ordenador(
                new Procesador6502(1.1),
                new Memoria(5120),
                "Commodore VIC-20");

        byte opcion;
        do
        {
            Console.WriteLine("1 - Añadir equipo basado en el Z80");
            Console.WriteLine("2 - Añadir equipo basado en el 6502");
            Console.WriteLine("3 - Ver todos los datos");
            Console.WriteLine("0 - Salir");
            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                default: Console.WriteLine("Opcion no valida"); break;
                case 0: Console.WriteLine("Nos vemos pronto!"); break;
                case 1:
                case 2:
                    if (contadorOrdenador >= MAX)
                        Console.WriteLine("Base de datos completa");
                    else
                    {
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Velocidad en MHz: ");
                        double velocidad = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Tamaño de memoria: ");
                        int tamanyo = Convert.ToInt32(Console.ReadLine());

                        if (opcion == 1)
                            ordenadores[contadorOrdenador] =
                                new Ordenador(
                                    new ProcesadorZ80(velocidad),
                                    new Memoria(tamanyo),
                                    nombre);
                        else
                            ordenadores[contadorOrdenador] =
                                new Ordenador(
                                    new Procesador6502(velocidad),
                                    new Memoria(tamanyo),
                                    nombre);
                        contadorOrdenador++;
                    }
                    break;

                case 3:
                    for (int i = 0; i < contadorOrdenador; i++)
                        Console.WriteLine(ordenadores[i]);
                    break;
            }
        }
        while (opcion != 0);
    }
}
