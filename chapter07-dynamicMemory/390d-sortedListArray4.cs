// Pablo Vigara Fernandez

using System;

struct node
{
    public string clave;
    public string valor;
}

class SortedListSS
{
    private node[] lista;

    private int count;
    public int Count { get { return count; } }

    public SortedListSS()
    {
        lista = new node[100];
        count = 0;
    }

    public void Add(string clave, string valor)
    {
        lista[count].clave = clave;
        lista[count].valor = valor;
        count++;

        int pos = 0;
        while (pos < count && lista[pos].clave.CompareTo(clave) < 0)
        {
            pos++;
        }
        for (int i = count + 1; i > pos; i--)
        {
            lista[i] = lista[i - 1];
        }
        lista[pos].clave = clave;
        lista[pos].valor = valor;
    }

    public string GetKey(int n)
    {
        return lista[n].clave;
    }

    public string GetValue(int n)
    {
        return lista[n].valor;
    }

    public bool Contains(string key)
    {
        for (int i = 0; i < count; i++)
        {
            if (lista[i].clave == key)
                return true;
        }
        return false;
    }

    public string GetByKey(string key)
    {
        for (int i = 0; i < count; i++)
        {
            if (lista[i].clave == key)
                return lista[i].valor;
        }

        throw new Exception("Not found");
    }
}

// Pablo Vigara Fernandez

class Ejercicio
{
    static void Main()
    {
        SortedListSS lista = new SortedListSS();

        lista.Add("hola", "hello");
        lista.Add("uno", "one");
        lista.Add("dos", "two");

        Console.WriteLine("Contains \"uno\": " + lista.Contains("uno"));
        Console.WriteLine("Contains \"tres\": " + lista.Contains("tres"));
        Console.WriteLine("Valor de \"hola\": " + lista.GetByKey("hola"));

        try
        {
            Console.WriteLine(lista.GetByKey("tres"));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine("Clave: " + lista.GetKey(i)
                + ", Valor: " + lista.GetValue(i));
        }
    }
}
