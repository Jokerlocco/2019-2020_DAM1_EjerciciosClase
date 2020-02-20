using System;

public class OldstyleList
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
    }

    static Node first;

    static void Add(int data)
    {
        Node newNode = new Node();
        newNode.Data = data;
        newNode.Next = null;

        if (first == null)
            first = newNode;
        else
        {
            Node current = first;
            while (current != null)
            {
                if (current.Next == null)
                {
                    current.Next = newNode;
                    return;
                }
                else
                    current = current.Next;
            }
        }
    }

    static void DisplayList()
    {
        Node current;

        current = first;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }

    static void Main()
    {
        first = null;
        Add(5);
        Add(3);
        Add(2);
        Add(6);
        DisplayList();
    }
}
