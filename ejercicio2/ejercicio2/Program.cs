using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el precio del artículo: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            decimal descuento = 0;

            if (precio >= 1000 && precio <= 5000)
                descuento = precio * 0.03m;

            else if (precio > 5000 && precio <= 10000)
                descuento = precio * 0.05m;

            else if (precio > 10000 && precio <= 15000)
                descuento = precio * 0.08m;

            else if (precio > 15000 && precio <= 20000)
                descuento = precio * 0.10m;

            Console.WriteLine("Precio original: " + precio);
            Console.WriteLine("Descuento aplicado: " + descuento);
        }
    }
}
