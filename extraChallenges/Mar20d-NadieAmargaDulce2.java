import java.util.*;

//Team titanic

class Pastel implements  Comparable<Pastel>
{
    public int aa;
    public int an;
    public int ap;
    public Pastel (int a,int n,int p)
    {
        aa = a;
        an = n;
        ap = p;
    }

    @Override
    public int compareTo(Pastel p) {
       int resultado;
       resultado = Integer.compare(this.aa,p.aa);
       if(resultado == 0)
       {
           resultado = Integer.compare(this.an,p.an);
           if(resultado== 0)
           {
               resultado= Integer.compare(p.ap,this.ap);
           }
       }
       return resultado;
    }
}

public class Programa
{
    public static void main(String [] args)
    {
        Scanner sc = new Scanner(System.in);
        Pastel pa;
        List <Pastel> paste = new ArrayList<Pastel>();
        String entrada = sc.nextLine();
        
        for( int i = 0; i < Integer.parseInt(entrada.split(" ")[0]); i++)
        {
            String linea = sc.nextLine();
            int n1 = Integer.parseInt(linea.split(" ")[0]);
            int n2 = Integer.parseInt(linea.split(" ")[1]);
            int n3 = n1 + n2;

            if(n3 <= Integer.parseInt(entrada.split(" ")[1]))
            {
                int [] valores ={Integer.parseInt(linea.split(" ")[0]),
                        Integer.parseInt(linea.split(" ")[1]),
                        Integer.parseInt(linea.split(" ")[2])};

                         if(valores[0] <=Integer.parseInt(entrada.split(" ")[1]) &&
                                 valores[1] <= Integer.parseInt(entrada.split(" ")[1])&&
                                 valores[2]<=Integer.parseInt(entrada.split(" ")[1]))
                {
                    pa = new Pastel(valores[0], valores[1], valores[2]);
                    paste.add(pa);
                }
            }
        }

        Collections.sort(paste);

        for(int i = 0; i < paste.size(); i++)
        {
            System.out.println(paste.get(i).aa+" "+paste.get(i).an+" "+paste.get(i).ap);
        }
    }
}
       
