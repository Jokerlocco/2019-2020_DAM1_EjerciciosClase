//Pablo Conde - 2/4/2020


using System;

class Calendario
{
    static void Main()
    {
        string[] meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo",
            "Junio", "Julio", "Agosto", "Septiembre", "Octubre",
            "Noviembre","Diciembre"};
        
        Console.Write("Año del calendario: ");
        int anyo = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Mes del calendario: ");
        int mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        
        
        int diasMes = DateTime.DaysInMonth(anyo, mes);
        string mesLetra = meses[mes-1];
     
       
        DateTime fecha = new DateTime(anyo, mes, 1);
        int primerDia = (int)fecha.DayOfWeek;
        
        primerDia += 6;
        primerDia %= 7;
        
        string huecosIniciales = new string(' ', primerDia*3);
     
        Console.WriteLine("    " + mesLetra + " " + anyo);
        Console.WriteLine();
        Console.WriteLine("lu ma mi ju vi sa do");
        Console.Write(huecosIniciales);
        
        for (int i = 1; i <= diasMes; i++)
        {
            if(i < 10)
                Console.Write(" " + i + " ");
            else
                Console.Write(i + " ");
                
            if((primerDia + i) % 7 == 0)
                Console.WriteLine();      
        }
    }
}
