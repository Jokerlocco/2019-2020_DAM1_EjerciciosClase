//Abraham García

using System;

abstract class Persona
{
    public string NombreApellidos { get; set; }
    public int Codigo { get; set; }

    public Persona(string nombreapellidos, int codigo)
    {
        NombreApellidos = nombreapellidos;
        Codigo = codigo;
    }

    public override string ToString()
    {
        string[] nombrePartido = NombreApellidos.Split(',');
        nombrePartido[1] = nombrePartido[1].Substring(1);
        return Codigo + ", " + nombrePartido[1] + nombrePartido[0];
    }
}

class Medico : Persona
{
    public string Especialidad { get; set; }

    public Medico(string nombreapellidos, int codigo, string especialidad)
        : base(nombreapellidos, codigo)
    {
        Especialidad = especialidad;
    }

    public Medico(string nombreapellidos, int codigo)
        : this(nombreapellidos, codigo, "Medicina general")
    {
    }

    public override string ToString()
    {
        return base.ToString() + ", " + Especialidad;
    }
}

class Enfermero : Persona
{
    public Enfermero(string nombreapellidos, int codigo)
        : base(nombreapellidos, codigo)
    {
    }
}

class Paciente : Persona
{
    public Paciente(string nombreapellidos, int codigo)
        : base(nombreapellidos, codigo)
    {
    }
}

abstract class Visita
{
    public Paciente Paciente { get; set; }
    public Medico Medico { get; set; }
    public DateTime Fecha { get; set; }
    public string Motivo { get; set; }
    public string Diagnostico { get; set; }

    public Visita(Paciente paciente, Medico medico,
        string motivo, string diagnostico)
    {
        Paciente = paciente;
        Medico = medico;
        Fecha = DateTime.Now;
        Motivo = motivo;
        Diagnostico = diagnostico;
    }

    public override string ToString()
    {
        return Paciente.NombreApellidos + " - " + Medico.NombreApellidos +
            " - " + Fecha + " - " + Motivo + " - " + Diagnostico;
    }
}

class Planificada : Visita
{
    public Planificada(Paciente paciente, Medico medico, DateTime fecha,
        string motivo, string diagnostico)
        : base(paciente, medico, motivo, diagnostico)
    {
    }

    public override string ToString()
    {
        return "Planificada- " + base.ToString();
    }
}

class Urgencia : Visita
{
    public bool VisitaPosterior { get; set; }

    public Urgencia(Paciente paciente, Medico medico, DateTime fecha,
        string motivo, string diagnostico, bool visitaPosterior)
        : base(paciente, medico, motivo, diagnostico)
    {
        VisitaPosterior = visitaPosterior;
    }

    public override string ToString()
    {
        string cadena = "Urgencia- " + base.ToString();
        if (VisitaPosterior)
            cadena += " (P)";

        return cadena;
    }
}

sealed class Consulta
{
    public Enfermero[] ListadoEnfermeros { get; set; }
    public Medico[] ListadoMedicos { get; set; }
    public int CantidadEnfermeros { get; set; }
    public int CantidadMedicos { get; set; }

    public void Ejecutar()
    {
        ListadoEnfermeros = new Enfermero[999];
        ListadoMedicos = new Medico[999];

        Medico m1 = new Medico("García, Pepe", 234);

    }

    static void Main()
    {
        Consulta c = new Consulta();
        c.Ejecutar();

        // new Consulta().Ejecutar();
    }
}
