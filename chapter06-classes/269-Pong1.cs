﻿using System;

class Pong
{
    public Pong()
    {
        Console.WriteLine("Starting Pong...");
    }

    ~Pong()
    {
        Console.WriteLine("Session finished");
    }

    static void Main()
    {
        Pong pong = new Pong();
    }
}
