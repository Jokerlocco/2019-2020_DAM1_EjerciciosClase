using System;

abstract class Cliente
{
    //protected string codigo;
    //public string Codigo { get { return codigo; } }
    
    public string Codigo { get; }
    
    public string Direccion { get; set; }
    public string Telefono { get; set; }

    public Cliente(string codigo, string direccion, string telefono)
    {
        Codigo = codigo;
        Direccion = direccion;
        Telefono = telefono;
    }

    public Cliente(string codigo, string direccion)
        : this(codigo, direccion, "")
    {
    }
}

// -------------------------------------------------

class Particular : Cliente
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }

    public Particular(string codigo, string nombre, string apellidos, 
            string direccion, string telefono) 
        : base(codigo, direccion, telefono)
    {
        Nombre = nombre;
        Apellidos = apellidos;
    }

    public Particular(string codigo, string nombre, string apellidos, string direccion)
        : this(codigo, nombre, apellidos, direccion, "")
    {
    }

    public override string ToString()
    {
        return Codigo + " " + Nombre + " " + Apellidos + "\n" + Direccion;
    }
}

// -------------------------------------------------

class Empresa : Cliente
{
    public string RazonSocial { get; set; }

    public Empresa(string codigo, string razonSocial, string direccion, string telefono)
        : base(codigo, direccion, telefono)
    {
        RazonSocial = razonSocial;
    }

    public Empresa(string codigo, string razonSocial, string direccion)
        : this(codigo, razonSocial, direccion, "")
    {
    }

    public override string ToString()
    {
        return Codigo + " " + RazonSocial + "\n" + Direccion;
    }
}


// -------------------------------------------------

abstract class Producto
{
    protected string codigo;
    public string Codigo { get { return codigo; } }
    public string Descripcion { get; set; }
    public double PrecioUnitario { get; set; }

    public Producto(string codigo, string descripcion, double precioUnitario)
    {
        this.codigo = codigo;
        Descripcion = descripcion;
        PrecioUnitario = precioUnitario;
    }

    public override string ToString()
    {
        return Codigo + " " + Descripcion + " " + PrecioUnitario;
    }
}

// -------------------------------------------------

class Perecedero : Producto
{
    public string FechaCaducidad { get; set; }
    public Perecedero(string codigo, string descripcion, double precioUnitario,
            string fechaCaducidad) : base(codigo, descripcion, precioUnitario)
    {
        FechaCaducidad = fechaCaducidad;
    }

    public override string ToString()
    {
        return base.ToString() + " caduca: " + FechaCaducidad;
    }
}

// -------------------------------------------------

class NoPerecedero : Producto
{
    public NoPerecedero(string codigo, string descripcion, double precioUnitario)
        : base(codigo, descripcion, precioUnitario)
    {
    }
}

// -------------------------------------------------

class Pedido
{
    private int numero;
    private string codCliente;
    private string fecha;
    private string[] codArticulos;
    private double[] precArticulos;
    private int cantidadArticulos;

    public Pedido(int numero, string codCliente, string fecha)
    {
        this.numero = numero;
        this.codCliente = codCliente;
        this.fecha = fecha;
        codArticulos = new string[100];
        precArticulos = new double[100];
        cantidadArticulos = 0;
    }

    public void AnadirProducto(string codProducto, double precioUnitario)
    {
        codArticulos[cantidadArticulos] = codProducto;
        precArticulos[cantidadArticulos] = precioUnitario;

        cantidadArticulos++;
    }

    public void Mostrar(Cliente[] clientes, Producto[] productos)
    {
        Console.WriteLine("Número pedido: " + numero +
            " - Fecha: " + fecha);

        foreach (Cliente c in clientes)
        {
            if (c.Codigo == codCliente)
            {
                Console.WriteLine(c);
            }
        }

        double total = 0;
        for (int i = 0; i < cantidadArticulos; i++)
        {
            foreach (Producto p in productos)
            {
                if (codArticulos[i] == p.Codigo)
                {
                    Console.WriteLine(p.Codigo + " " + p.Descripcion
                        + precArticulos[i]);
                    total += precArticulos[i];
                }
            }
        }
        Console.WriteLine("Total: " + total);
    }

}


// -------------------------------------------------

namespace GestionPedidos
{
    class Gestion
    {
        private Pedido[] pedidos;
        private int cantidadPedidos;
        private Producto[] productos;
        private int cantidadProductos;
        private Cliente[] clientes;
        private int cantidadClientes;

        private const int MAX_PEDIDOS = 100;
        private const int MAX_PRODUCTOS = 100;
        private const int MAX_CLIENTES = 100;

        public Gestion()
        {
            pedidos = new Pedido[MAX_PEDIDOS];
            productos = new Producto[MAX_PRODUCTOS];
            clientes = new Cliente[MAX_CLIENTES];

            cantidadClientes = 0;
            cantidadPedidos = 0;
            cantidadProductos = 0;
        }


        public void AnadirCliente()
        {
            if (cantidadClientes < MAX_CLIENTES)
            {
                Console.Write(" Cliente particular (1) o de empresa (2): ");
                string opcion = Console.ReadLine().ToUpper();

                Console.Write(" Código: ");
                string cod = Console.ReadLine();
                Console.Write(" Direccion: ");
                string dir = Console.ReadLine();
                Console.Write(" Telefono: ");
                string tel = Console.ReadLine();


                switch (opcion)
                {
                    case "1":
                        Console.Write(" Nombre: ");
                        string nomP = Console.ReadLine();
                        Console.Write(" Apellidos: ");
                        string apP = Console.ReadLine();
                        clientes[cantidadClientes] = new Particular(cod,
                            nomP, apP, dir, tel);
                        break;
                    case "2":
                        Console.Write(" Razón Social: ");
                        string razE = Console.ReadLine();
                        clientes[cantidadClientes] = new Particular(cod,
                            razE, dir, tel);
                        break;
                    default:
                        Console.WriteLine("Tipo de cliente no encontrado.");
                        break;
                }
                cantidadClientes++;
            }
            else
            {
                Console.WriteLine("Base de datos de clientes llena!");
            }
        }


        public void MostrarClientes()
        {
            for (int i = 0; i < cantidadClientes; i++)
            {
                Console.WriteLine(clientes[i]);
            }
        }


        public void AnadirProducto()
        {
            if (cantidadProductos < MAX_PRODUCTOS)
            {
                Console.Write(" Producto perecedero (1) o " +
                        "no perecedero (2): ");
                string opcion = Console.ReadLine();

                Console.Write(" Código: ");
                string cod = Console.ReadLine();
                Console.Write(" Descripción: ");
                string desc = Console.ReadLine();
                Console.Write(" Precio: ");
                double pre = Convert.ToDouble(Console.ReadLine());

                switch (opcion)
                {
                    case "1":
                        Console.Write(" Fecha caducidad: ");
                        string fecha = Console.ReadLine();

                        productos[cantidadProductos] = new Perecedero(cod,
                            desc, pre, fecha);
                        break;
                    case "2":
                        productos[cantidadProductos] = new NoPerecedero(cod,
                            desc, pre);
                        break;
                    default:
                        Console.WriteLine("Tipo de producto no encontrado.");
                        break;
                }
                cantidadProductos++;
            }
            else
            {
                Console.WriteLine("Base de datos de productos llena!");
            }
        }

        public void MostrarProductos()
        {
            for (int i = 0; i < cantidadProductos; i++)
            {
                Console.WriteLine(productos[i]);
            }
        }


        public void MostrarUnPedido()
        {
            Console.Write(" Número de pedido que deseas ver: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > cantidadPedidos)
            {
                Console.WriteLine("No hay tantos pedidos.");
            }
            else
            {
                pedidos[num].Mostrar(clientes, productos);
            }
        }


        public void AnadirPedido()
        {
            if (cantidadPedidos < MAX_PEDIDOS)
            {
                Console.Write(" Numero de pedido: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Código cliente: ");
                string cod = Console.ReadLine();
                Console.Write(" Fecha: ");
                string fecha = Console.ReadLine();
                Console.WriteLine("¿Cuántos artículos?");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                pedidos[cantidadPedidos] = new Pedido(num, cod, fecha);
                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write(" Código del artículo: ");
                    string codArtic = Console.ReadLine();
                    Console.WriteLine(" Precio: ");
                    double precio = Convert.ToDouble(Console.ReadLine());
                    pedidos[cantidadPedidos].AnadirProducto(codArtic, precio);
                }
                cantidadPedidos++;
            }
            else
            {
                Console.WriteLine("Base de datos de pedidos llena!");
            }
        }


        public void Ejecutar()
        {
            string opcion;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Mostrar clientes");
                Console.WriteLine("2. Añadir clientes");
                Console.WriteLine("3. Mostrar productos");
                Console.WriteLine("4. Añadir productos");
                Console.WriteLine("5. Mostrar un pedido");
                Console.WriteLine("6. Añadir pedido");
                Console.WriteLine("S. Salir");
                Console.WriteLine();
                Console.Write(" -> ");
                opcion = Console.ReadLine().ToUpper();
                Console.WriteLine();
                switch (opcion)
                {
                    case "1":
                        MostrarClientes();
                        break;
                    case "2":
                        AnadirCliente();
                        break;
                    case "3":
                        MostrarProductos();
                        break;
                    case "4":
                        AnadirProducto();
                        break;
                    case "5":
                        MostrarUnPedido();
                        break;
                    case "6":
                        AnadirPedido();
                        break;
                    case "S":
                        Console.WriteLine("Adiós!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
            while (opcion != "S");
        }


        static void Main()
        {
            Gestion g = new Gestion();
            g.Ejecutar();
        }
    }
}
