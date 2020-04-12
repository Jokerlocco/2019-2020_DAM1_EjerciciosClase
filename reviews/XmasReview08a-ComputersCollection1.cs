//Lautaro Álvaro Fernández

using System;

class Xmas8
{
    struct Ordenador
    {
        public string marca;
        public string modelo;
        public int anyo;
        public string ram;
        public string comentarios;
    }
    static string QuitarEspacios(string s)
    {      
        s = s.TrimEnd();
        s = s.TrimStart();
        
        string[] aux = s.Split(' ');
        string resultado = "";
        
        for ( int i = 0; i < aux.Length; i++ )
        {
            if ( aux[i] != "" )
            {
                resultado += aux[i];
                
                if ( i != aux.Length-1 )
                {
                    resultado += " ";
                }
            }
        }
        
        return resultado;
    }
    static void Main()
    {
        const int MAX = 600;
        Ordenador[] ordenadores = new Ordenador [MAX];
        
        int cantidad = 0;
        bool salir = false;
        string opcion;
        
        do
        {
            Console.WriteLine();
            Console.WriteLine(" 1- Añadir ");
            Console.WriteLine(" 2- Mostrar ");
            Console.WriteLine(" 3- Buscar ");
            Console.WriteLine(" 4- Modificar ");
            Console.WriteLine(" 5- Eliminar registro ");
            Console.WriteLine(" 6- Insertar ");
            Console.WriteLine(" 7- Ordenar ");
            Console.WriteLine(" 8- Eliminar espacios ");
            Console.WriteLine(" Q- Salir ");
            Console.WriteLine();
            Console.Write(" -> ");
            opcion = Console.ReadLine().ToUpper();
            Console.WriteLine();
            
            switch (opcion)
            {
                case "1":
                    if ( cantidad < MAX )
                    {
                        do
                        {
                            Console.Write("Marca: ");
                            ordenadores[cantidad].marca = Console.ReadLine();
                        }
                        while( ordenadores[cantidad].marca == "" );
                        
                        do
                        {
                            Console.Write("Modelo: ");
                            ordenadores[cantidad].modelo = Console.ReadLine();
                        }
                        while( ordenadores[cantidad].modelo.Length > 50 ); 
                        
                        Console.Write("Año: ");                                
                        string tempAnyo = Console.ReadLine();
                        
                        if ( tempAnyo != "" )
                        {
                            if ( Convert.ToInt32(tempAnyo) < 1900 )
                                tempAnyo = "0";
                                
                            ordenadores[cantidad].anyo = 
                                Convert.ToInt32(tempAnyo);
                        }
                        
                        Console.Write("Ram: ");
                        ordenadores[cantidad].ram = Console.ReadLine();
                        
                        Console.Write("Comentarios: ");
                        ordenadores[cantidad].comentarios = Console.ReadLine();
                        
                        cantidad++;
                    }
                    else
                    {
                        Console.WriteLine("La base de datos está llena! ");
                    }
                    break;
                    
                case "2":
                    if ( cantidad <= 0 )
                    {
                        Console.WriteLine("No hay ordenadores registrados! ");
                    }
                    else
                    {
                        for ( int i = 0; i < cantidad; i++ )
                        {
                            Console.WriteLine((i+1) + " - " + 
                                ordenadores[i].marca + " - " + 
                                ordenadores[i].modelo);
                        
                            if ( i%24 == 0)
                            {
                                Console.Write("Pulsa Intro para continuar");
                                Console.ReadLine();
                            }
                        }
                        Console.WriteLine();
                    }
                    break;
                
                case "3":
                    if ( cantidad <= 0 )
                    {
                        Console.WriteLine("No hay ordenadores registrados! ");
                    }
                    else
                    {
                        Console.Write("Buscar: ");
                        string busqueda = Console.ReadLine().ToLower();
                        bool encontrada = false;
                        for ( int i = 0; i < cantidad; i++ )
                        {
                            if( (ordenadores[i].marca.ToLower()
                                        .IndexOf(busqueda) != -1)
                                || (ordenadores[i].modelo.ToLower()
                                        .IndexOf(busqueda) != -1) 
                                || (ordenadores[i].comentarios.ToLower()
                                        .IndexOf(busqueda) != -1) )
                            {  
                                Console.WriteLine("Marca: " + 
                                        ordenadores[i].marca);
                                        
                                Console.WriteLine("Modelo: " + 
                                        ordenadores[i].modelo);
                                        
                                if ( ordenadores[i].anyo == 0 )
                                {
                                    Console.WriteLine("Año: desconocido");
                                }
                                else
                                {
                                    Console.WriteLine("Año: " + 
                                            ordenadores[i].anyo);
                                }
                                
                                Console.WriteLine("Ram: " + 
                                        ordenadores[i].ram);
                                        
                                Console.WriteLine("Comentario: " + 
                                        ordenadores[i].comentarios);
                                        
                                Console.WriteLine();
                                encontrada = true;
                            }
                        }
                        if( !encontrada )
                        {
                            Console.WriteLine("No se ha encontrado nada.");
                            Console.WriteLine();
                        }
                    }
                    break;
                
                case "4":
                    Console.Write("Registro a modificar: ");
                    int modificar = Convert.ToInt32(Console.ReadLine());
                    if ( modificar > cantidad )
                    {
                        Console.WriteLine("Registro inválido. ");
                    }
                    else
                    {
                        Console.WriteLine("Marca: " + 
                                ordenadores[modificar-1].marca);
                                
                        Console.WriteLine("Nueva marca: ");
                        string tempMarca = Console.ReadLine();
                        
                        if ( tempMarca != "" )
                        {
                            ordenadores[modificar-1].marca = tempMarca;
                        }
                            
                        Console.WriteLine("Modelo: " + 
                                ordenadores[modificar-1].modelo);
                                
                        Console.WriteLine("Nuevo modelo: ");
                        string tempModelo = Console.ReadLine();
                        
                        if ( tempModelo != "" ) 
                        {
                            ordenadores[modificar-1].modelo = tempModelo;
                        }
                            
                        Console.WriteLine("Año: " + 
                                ordenadores[modificar-1].anyo);
                                
                        Console.WriteLine("Nuevo año: ");
                        string tempAnyo = Console.ReadLine();
                        
                        if ( tempAnyo != "")
                        {          
                            ordenadores[modificar-1].anyo = 
                                    Convert.ToInt32(tempAnyo);
                        }
                            
                        Console.WriteLine("Ram: " + 
                                ordenadores[modificar-1].ram);
                                
                        Console.WriteLine("Nueva ram: ");
                        string tempRam = Console.ReadLine();
                        
                        if ( tempRam != "" )
                        {
                            ordenadores[modificar-1].ram = tempRam;
                        }
                        
                        Console.WriteLine("Comentario: " + 
                                ordenadores[modificar-1].comentarios);
                                
                        Console.WriteLine("Nuevo comentario: ");
                        string tempComentario = Console.ReadLine();
                        
                        if ( tempComentario != "")
                        {
                            ordenadores[modificar-1].comentarios = 
                                    tempComentario;
                        }
                    }
                    break;
                
                case "5":
                    Console.Write("Registro a eliminar: ");
                    int eliminar = Convert.ToInt32(Console.ReadLine()) - 1;
                    
                    if ( eliminar > cantidad )
                    {
                        Console.WriteLine("Registro inválido. ");
                    }
                    else
                    {
                        for ( int i = eliminar; i < cantidad; i++ )
                        {
                            ordenadores[i] = ordenadores[i+1];
                        }
                        cantidad--;
                    }
                    break;
                
                case "6":
                    Console.Write("Donde quiere insertar el nuevo registro? ");
                    int posicion = Convert.ToInt32(Console.ReadLine()) - 1;
                    
                    if ( posicion > cantidad )
                    {
                        Console.WriteLine("Posición inválida. ");
                    }
                    else
                    {
                        for ( int i = cantidad; i >= posicion; i-- )
                        {
                            ordenadores[i+1] = ordenadores[i]; 
                        }
                        
                        do
                        {
                            Console.Write("Marca: ");
                            ordenadores[posicion].marca = Console.ReadLine();
                        }
                        while( ordenadores[posicion].marca == "" );
                        
                        do
                        {
                            Console.Write("Modelo: ");
                            ordenadores[posicion].modelo = Console.ReadLine();
                        }
                        while( ordenadores[posicion].modelo.Length > 50 ); 
                        
                        Console.Write("Año: ");                                
                        string tempAnyo = Console.ReadLine();
                        
                        if ( tempAnyo != "" )
                        {
                            if ( Convert.ToInt32(tempAnyo) < 1900 )
                            {
                                tempAnyo = "0";
                            }
                                
                            ordenadores[posicion].anyo = 
                                Convert.ToInt32(tempAnyo);
                        }
                        
                        Console.Write("Ram: ");
                        ordenadores[posicion].ram = Console.ReadLine();
                        
                        Console.Write("Comentarios: ");
                        ordenadores[posicion].comentarios = Console.ReadLine();
                        
                        cantidad++;
                    }
                    break;
                    
                case "7":
                    if ( cantidad < 1 )
                    {
                        Console.WriteLine("Base de datos vacío! ");
                    }
                    else
                    {
                        string marcaModelo1 = "";
                        string marcaModelo2 = "";
                        
                        for ( int i = 0; i < cantidad-1; i++ )
                        {
                            for ( int j = i+1; j < cantidad; j++ )
                            {
                                marcaModelo1 = ordenadores[i].marca + 
                                            ordenadores[i].modelo;
                                            
                                marcaModelo2 = ordenadores[j].marca + 
                                            ordenadores[j].modelo;
                                
                                if ( marcaModelo1.CompareTo(marcaModelo2) > 0 )
                                {
                                    Ordenador aux = ordenadores[i];
                                    ordenadores[i] = ordenadores[j];
                                    ordenadores[j] = aux;
                                }
                            }
                        }
                        Console.WriteLine("Ordenado alfabéticamente " + 
                                    " completado.");
                    }
                    break;
                
                case "8":
                    if ( cantidad < 1 )
                    {
                        Console.WriteLine("No hay ningun registro.");
                    }
                    else
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            ordenadores[i].marca = 
                            QuitarEspacios(ordenadores[i].marca);
                            ordenadores[i].modelo = 
                            QuitarEspacios(ordenadores[i].modelo);
                            ordenadores[i].comentarios = 
                            QuitarEspacios(ordenadores[i].comentarios);
                        }
                    }                             
                    break;
                case "Q":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opcion inválida. ");
                    break;
            }
            
        }
        while ( !salir );
    }
}
