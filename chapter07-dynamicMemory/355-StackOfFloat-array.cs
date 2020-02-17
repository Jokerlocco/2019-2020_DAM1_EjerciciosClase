using System;

class StackOfFloat
{
    private float[] data;
    private int count;
    public int Count { get { return count; } }

    public StackOfFloat()
    {
        data = new float[100];
        count = 0;
    }

    public void Push(float num)
    {
        data[count++] = num;
    }

    public float Pop()
    {
        return data[--count];
    }

    public float Peek()
    {
        return data[count-1];
    }
}

class StackOfIntExample
{
    static void Main()
    {
        StackOfFloat stackie = new StackOfFloat();

        stackie.Push(1.3f);
        stackie.Push(2);
        stackie.Push(3);

        Console.WriteLine("Amount : " + stackie.Count);
        Console.WriteLine(stackie.Peek());
        while (stackie.Count > 0)
            Console.WriteLine(stackie.Pop());
    }
}
