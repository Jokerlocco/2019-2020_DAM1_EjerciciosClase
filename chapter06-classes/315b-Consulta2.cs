// Pablo Vigara Fernandez
// '{}'

using System;

abstract class PersonalHospital
{
    public string Nombre { get; set; }
    public int Codigo { get; set; }

    public PersonalHospital(string nombre, int codigo)
    {
        this.Nombre = nombre;
        this.Codigo = codigo;
    }

    public override string ToString()
    {
        return Nombre + ", " + Codigo;
    }
}

// ---------------

class Medicos : PersonalHospital
{
    public string Especialidad { get; set; }
    public Medicos(string nombre, int codigo) 
        : this(nombre, codigo, "Medicina general")
    {
    }

    public Medicos(string nombre, int codigo, string especialidad)
        : base(nombre, codigo)
    {
        this.Especialidad = especialidad;
    }
    public override string ToString()
    {
        return base.ToString() + ", " + Especialidad;
    }

}

// ---------------

class Enfermeros : PersonalHospital
{

    public Enfermeros(string nombre, int codigo)
        : base(nombre, codigo)
    {
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

// ---------------

class Pacientes : PersonalHospital
{

    public Pacientes(string nombre, int codigo)
        : base(nombre, codigo)
    {
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

// ---------------

class Visitas
{
    public Pacientes Paciente { get; set; }
    
    public Medicos Medico { get; set; }

    public DateTime Fecha { get; set; }

    public string Motivo { get; set; }

    public string Diagnostico { get; set; }

    public Visitas(Pacientes paciente, Medicos medico, 
            DateTime fecha, string motivo, string diagnostico)
    {
        this.Paciente = paciente;
        this.Medico = medico;
        this.Fecha = fecha;
        this.Motivo = motivo;
        this.Diagnostico = diagnostico;
    }

    public override string ToString()
    {
        return Paciente.Nombre + " - " + Medico.Nombre
            + " - " + Fecha
            + " - " + Motivo
            + " - " + Diagnostico;
    }

}

class Urgencias : Visitas
{
    public bool VisitaPosterior { get; set; }

    public Urgencias(Pacientes paciente, Medicos medico, DateTime fecha, 
            string motivo, string diagnostico, bool visitaPosterior)
        : base(paciente, medico, fecha, motivo, diagnostico)
    {
        this.VisitaPosterior = visitaPosterior;
    }

    public override string ToString()
    {
        if (VisitaPosterior == true)
            return "Urgencia - " + base.ToString() + "(P)";
        else
            return "Urgencia - " + base.ToString();
    }
}

// ---------------

class Planificadas : Visitas
{
    public Planificadas(Pacientes paciente, Medicos medico, DateTime fecha,
            string motivo, string diagnostico)
        : base(paciente, medico, fecha, motivo, diagnostico)
    {
    }

    public override string ToString()
    {
        return "Planificada - " + base.ToString();
    }
}

class Consulta
{
    private Pacientes[] pacientes;

    public Pacientes[] Pacientes
    {
        get { return pacientes; }
        set { pacientes = value; }
    }

    private Medicos[] medicos;

    public Medicos[] Medicos
    {
        get { return medicos; }
        set { medicos = value; }
    }

    private Visitas[] visitas;

    public Visitas[] Visitas
    {
        get { return visitas; }
        set { visitas = value; }
    }

    const int MAX = 100;

    private int contadorPacientes = 0;
    private int contadorVisitas = 0;
    private int contadorMedicos = 2;

    public void Ejecutar()
    {
        pacientes = new Pacientes[MAX];
        medicos = new Medicos[MAX];
        visitas = new Visitas[MAX];

        medicos[0] =
            new Medicos("Garcia Lozano, Alfonso", 12345678, "Oftalmologia");
        medicos[1] =
            new Medicos("Perez Fernandez, Paula", 93663379);

        Enfermeros enfermero = new Enfermeros("Martinez Torrent", 34895045);

        int opcion;

        do
        {
            Console.WriteLine("1 - Añadir un paciente");
            Console.WriteLine("2 - Buscar un paciente");
            Console.WriteLine("3 - Añadir una visita");
            Console.WriteLine("4 - Ver todas las visitas");
            Console.WriteLine("0 - Salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                default: Console.WriteLine("Opcion no valida"); 
                    break;
                case 0: Console.WriteLine("Hasta la proxima!");
                    break;
                case 1:
                    if (contadorPacientes >= MAX)
                        Console.WriteLine("Base de datos completa");
                    else
                    {
                        Console.Write("Nombre del paciente: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Apellidos del paciente: ");
                        string apellidos = Console.ReadLine();
                        Console.Write("Codigo: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        pacientes[contadorPacientes] =
                            new Pacientes(apellidos + ", " + nombre, codigo);
                        contadorPacientes++;
                    }
                    break;
                case 2:
                    if (contadorPacientes == 0)
                        Console.WriteLine("No existen pacientes");
                    else
                    {
                        Console.Write("Nombre o apellidos del paciente: ");
                        string texto = Console.ReadLine();

                        for (int i = 0; i < contadorPacientes; i++)
                        {
                            if (pacientes[i].Nombre.Contains(texto))
                                Console.WriteLine(pacientes[i].ToString());
                        }
                    }
                    break;
                case 3:
                    if (contadorVisitas >= MAX)
                        Console.WriteLine("Base de datos completa");
                    else
                    {
                        Console.Write("Numero de paciente: ");
                        int numero = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Numero de medico: ");
                        int numeroMedico = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Movito de la visita: ");
                        string motivo = Console.ReadLine();
                        Console.Write("Diagnostico: ");
                        string diagnostico = Console.ReadLine();
                        Console.Write("¿Urgencia o planificada? (U/P): ");
                        char opcionVisita = Convert.ToChar(Console.ReadLine());

                        switch (opcionVisita)
                        {
                            case 'U':
                                bool visitaPosterior = false;
                                Console.Write("Necesita visita posterior (S/N): ");
                                if (Convert.ToChar(Console.ReadLine()) == 'S')
                                    visitaPosterior = true;
                                visitas[contadorVisitas] =
                                    new Urgencias(pacientes[numero], 
                                        medicos[numeroMedico], DateTime.Now, 
                                        motivo, diagnostico, visitaPosterior);
                                break;
                            case 'P':
                                visitas[contadorVisitas] =
                                    new Planificadas(pacientes[numero],
                                        medicos[numeroMedico], DateTime.Now,
                                        motivo, diagnostico);
                                break;
                        }
                        contadorVisitas++;
                    }
                    break;
                case 4:
                    if (contadorVisitas == 0)
                        Console.WriteLine("No existen visitas");
                    else
                    {
                        for (int i = 0; i < contadorVisitas; i++)
                        {
                            Console.WriteLine(visitas[i].ToString());
                        }
                    }
                    break;

            }
        }
        while (opcion != 0);
    }

    static void Main()
    {
        Consulta c = new Consulta();
        c.Ejecutar();
    }
}
