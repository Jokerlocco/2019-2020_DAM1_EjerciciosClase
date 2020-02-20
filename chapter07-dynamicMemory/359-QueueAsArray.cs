using System;

class QueueOfString
{
    protected string[] myArray;
    protected int count;
    public int Count { get { return count; } }    
    
    public QueueOfString()
    {
        myArray = new string[1000];
        count = 0;
    }
    
    public string Peek()
    {
        return myArray[0];
    }
    
    public void Enqueue(string s)
    {
        myArray[count] = s;
        count++;
    }
    
    public String Dequeue()
    {
        string aux = myArray[0];
        for(int i = 0; i < myArray.Length - 1; i++)
        {
            myArray[i] = myArray[i + 1];
        }
        count--;
        return aux;
    }
}

class QueueTest
{
    static void Main()
    {
        QueueOfString myQueue = new QueueOfString();
        myQueue.Enqueue("Data1");
        myQueue.Enqueue("Data2");
        
        Console.WriteLine("First: " + myQueue.Peek());        
        Console.WriteLine("Count: " + myQueue.Count);
        
        while(myQueue.Count > 0)
        {
            Console.WriteLine(myQueue.Dequeue());
        }
    }
}
