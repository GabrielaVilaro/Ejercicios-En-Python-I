﻿using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número: ");

           int num1 = int.Parse( Console.ReadLine()); //Para que el usuario ingrese un número

            Console.WriteLine("Ingrese el segundo número: ");

            int num2 = int.Parse(Console.ReadLine()); //int.parse convierte string en entero

            Console.WriteLine("El resultado es " + (num1 + num2));
        }
    }
}
