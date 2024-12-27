using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("introduzca su edad");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("introduzca su sexo");
            String sexo = Console.ReadLine();

            if (edad < 18)
            {
                Console.WriteLine("no puedes entrar a la discoteca eres menor de edad");
                }
            else
            {

                if (sexo == "femenino")
                {
                    Console.WriteLine("puede entrar gratis");
                }
                else if (sexo == "masculino")
                {
                    Console.WriteLine("puede entrar, pero debe pagar");
                }

            }
        }
    }
}
