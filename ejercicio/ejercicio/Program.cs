﻿using System;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] dato = new char[10];

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("ingrese una letra: " );
                dato[i] = char.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
