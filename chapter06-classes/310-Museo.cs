using System;

class Museo
{
    private Obra[] obras;

    public Obra[] Obras
    {
        get { return obras; }
        set { obras = value; }
    }

    private Empleado[] empleados;

    public Empleado[] Empleados
    {
        get { return empleados; }
        set { empleados = value; }
    }

    const int TAM_MAX = 100;

    private int countObras = 2;
    private int countEmpleados = 2;

    public void Ejecutar()
    {
        obras = new Obra[TAM_MAX];
        empleados = new Empleado[TAM_MAX];

        empleados[0] = new EnPlantilla("111", "111", "trauma", "apfdja");
        empleados[1] = new EnPlantilla("222", "222", "rayos", "apfdja");
        obras[0] = new Pintura("333", "monalisa", 254254, "dedos");
        obras[1] = new Pintura("444", "adfa", 4542452, "dedos");
        string opcion = "";
        do
        {
            Console.WriteLine("Escoja una opcion");

            Console.WriteLine("1. Añadir empleado en plantilla");
            Console.WriteLine("2. Añadir empleado interesado");
            Console.WriteLine("3. Buscar empleados");
            Console.WriteLine("4. Añadir una obra");
            Console.WriteLine("5. Buscar en las obras");
            Console.WriteLine("Salir");

            opcion = Console.ReadLine().ToLower();
            switch (opcion)
            {
                case "1":
                    AnyadirEmpleadoPlantilla();
                    break;
                case "2":
                    AnyadirEmpleadoInteresado();
                    break;
                case "3":
                    BuscarEmpleados();
                    break;
                case "4":
                    AnaydirObra();
                    break;
                case "5":
                    BuscarObras();
                    break;
                case "salir":
                    Console.WriteLine("Adios");
                    break;
                case "default":
                    Console.WriteLine("Opcion incorrecto");
                    break;
            }
        }
        while (opcion == "salir");
    }

    private void BuscarObras()
    {
        Console.WriteLine("busqueda de Obras");
        Console.Write("Introduce el texto a buscar: ");
        string texto = Console.ReadLine();

        for (int i = 0; i < countObras; i++)
        {
            if (obras[i].ToString().Contains(texto))
            {
                Console.WriteLine(obras[i]);
            }
        }
    }

    private void AnaydirObra()
    {
        if (countObras <= TAM_MAX)
        {
            Console.WriteLine("Añadir Obra");
            Console.WriteLine(
                "Que tipo de obra?, Pintura o Escultura");
            string tipo = Console.ReadLine().ToUpper();
            if (tipo != "PINTURA" && tipo != "ESCULTURA")
            {
                Console.WriteLine("tipo incorrecto");
            }
            else
            {
                Console.WriteLine("Dime su autor");
                string autor = Console.ReadLine();
                Console.WriteLine("Dime su titulo");
                string titulo = Console.ReadLine();
                Console.WriteLine("Dime su fecha");
                int anyo = Convert.ToInt32(Console.ReadLine());

                if (tipo == "PINTURA")
                {
                    Console.WriteLine("Dime la tecnica empleada");
                    string tecnica = Console.ReadLine();
                    obras[countObras] =
                        new Pintura(autor, titulo, anyo, tecnica);
                }
                else if (tipo == "ESCULTURA")
                {
                    Console.WriteLine("Dime el material");
                    string material = Console.ReadLine();
                    obras[countObras] =
                        new Escultura(
                            autor, titulo, anyo, material);
                }
                countObras++;
            }
        }
        else
        {
            Console.WriteLine("no cabe");
        }
    }

    private void BuscarEmpleados()
    {
        Console.WriteLine("busqueda empleados");
        Console.Write("Introduce el texto a buscar: ");
        string texto = Console.ReadLine();

        for (int i = 0; i < countEmpleados; i++)
        {
            if (empleados[i].ToString().Contains(texto))
            {
                Console.WriteLine(empleados[i]);
            }
        }
    }

    private void AnyadirEmpleadoInteresado()
    {
        if (countEmpleados <= TAM_MAX)
        {
            Console.WriteLine("Añadir empleado interesado");
            Console.WriteLine("Dime su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Dime su especialidad");
            string sector = Console.ReadLine();
            Console.WriteLine("Dime su fecha");
            string fecha = Console.ReadLine();
            empleados[countEmpleados] =
                new Interesado(nombre, sector, fecha);
            countEmpleados++;
        }
        else
        {
            Console.WriteLine("no cabe");
        }
    }

    private void AnyadirEmpleadoPlantilla()
    {
        if (countEmpleados <= TAM_MAX)
        {
            Console.WriteLine("Añadir empleado en plantila");
            Console.WriteLine("Dime su codigo");
            string codigo = Console.ReadLine();
            Console.WriteLine("Dime su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Dime su especialidad");
            string sector = Console.ReadLine();
            Console.WriteLine("Dime su direccion");
            string direccion = Console.ReadLine();
            empleados[countEmpleados] =
                new EnPlantilla(codigo, nombre, sector, direccion);
            countEmpleados++;
        }
        else
        {
            Console.WriteLine("no cabe");
        }
    }

    static void Main()
    {
        Museo m = new Museo();
        m.Ejecutar();
    }

}

// -------------------------------------------

abstract class Empleado
{
    public string Nombre { get; set; }
    public string Sector { get; set; }

    public Empleado(string nombre, string sector)
    {
        Nombre = nombre;
        Sector = sector;
    }

    public override string ToString()
    {
        return Nombre + "|" + Sector;
    }

}

// -------------------------------------------


sealed class EnPlantilla : Empleado
{
    public string Codigo { get; }
    public string Direccion { get; set; }

    public EnPlantilla(
            string codigo, string nombre, string sector, string direccion)
                : base(nombre, sector)
    {
        Codigo = codigo;
        Direccion = direccion;
    }

    public EnPlantilla(
            string codigo, string nombre, string sector)
                : base(nombre, sector)
    {
        Codigo = codigo;
    }

    public override string ToString()
    {
        return base.ToString() + " (P)";
    }

}

// -------------------------------------------

class Interesado : Empleado
{
    public string Fecha { get; set; }

    public Interesado(string nombre, string sector, string fecha)
                : base(nombre, sector)
    {
        Fecha = fecha;
    }


    public override string ToString()
    {
        return base.ToString() + " (I)";
    }

}

// -------------------------------------------

abstract class Descartado : Interesado
{
    public string Motivo { get; set; }

    public Descartado(
        string nombre, string sector, string fecha, string motivo)
            : base(nombre, sector, fecha)
    {
        Motivo = motivo;
    }
}

// -------------------------------------------

abstract class Obra
{
    protected string autor;
    protected string titulo;
    protected int anyo;

    public Obra(string autor, string titulo, int anyo)
    {
        this.autor = autor;
        this.titulo = titulo;
        this.anyo = anyo;
    }

    public string GetAutor()
    {
        return autor;
    }
    public string GetTitulo()
    {
        return titulo;
    }
    public int GetAnyo()
    {
        return anyo;
    }

    public void SetAutor(string autor)
    {
        this.autor = autor;
    }

    public void SetTitulo(string titulo)
    {
        this.titulo = titulo;
    }

    public void SetAnyo(int anyo)
    {
        this.anyo = anyo;
    }

    public override string ToString()
    {
        return autor + "-" + titulo + "-" + anyo;
    }

}

// -------------------------------------------

class Pintura : Obra
{
    protected string tecnica;

    public Pintura(string autor, string titulo, int anyo, string tecnica)
            : base(autor, titulo, anyo)
    {
        this.tecnica = tecnica;
    }

    public void SetTecnica(string tecnica)
    {
        this.tecnica = tecnica;
    }

    public string GetTecnica()
    {
        return tecnica;
    }


    public override string ToString()
    {
        return base.ToString() + " (Pintura)";
    }

}

// -------------------------------------------

class Escultura : Obra
{
    protected string material;

    public Escultura(string autor, string titulo, int anyo, string material)
            : base(autor, titulo, anyo)
    {
        this.material = material;
    }

    public void SetMaterial(string material)
    {
        this.material = material;
    }

    public string GetMaterial()
    {
        return material;
    }

    public override string ToString()
    {
        return base.ToString() + " (Escultura)";
    }

}
