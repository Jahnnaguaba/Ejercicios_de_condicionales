using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
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

            int mayor, central, menor;

           
            if (num1 >= num2 && num1 >= num3)
            {
                mayor = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                mayor = num2;
            }
            else
            {
                mayor = num3;
            }

            if (num1 <= num2 && num1 <= num3)
            {
                menor = num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                menor = num2;
            }
            else
            {
                menor = num3;
            }

           
            central = num1 + num2 + num3 - mayor - menor;

            Console.WriteLine("El mayor es: " + mayor);
            Console.WriteLine("El central es: " + central);
            Console.WriteLine("El menor es: " + menor);
        }
    }
}
