﻿using System;

namespace CIS501_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Manager m = new Manager();
            Client c = new Client();

            Console.WriteLine("Client has asked for assistance...");
            c.work();
            Console.WriteLine("Client is happy!");
        }
    }
}
