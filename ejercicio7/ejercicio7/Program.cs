using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine(num1 + " es mayor que " + num2 + ".");
            else if (num2 > num1)
                Console.WriteLine(num2 + " es mayor que " + num1 + ".");
            else
                Console.WriteLine("Ambos números son iguales.");
        }
    }
}
