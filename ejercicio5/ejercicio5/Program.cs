﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
                Console.WriteLine("El número es positivo.");
            else if (numero < 0)
                Console.WriteLine("El número es negativo.");
            else
                Console.WriteLine("El número es cero.");
        }
    }
}