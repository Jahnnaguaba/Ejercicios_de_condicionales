﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("El mayor es: " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("El mayor es: " + num2);
            }
            else
            {
                Console.WriteLine("El mayor es: " + num3);
            }
        }
    }
}
