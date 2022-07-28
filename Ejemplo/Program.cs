using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int entero;
            int entero2;
            int total_suma;

            Console.Write("Ingrese un entero: \n");
            entero = int.Parse(Console.ReadLine());

            Console.Write("Ingrese otro entero: \n");
            entero2 = int.Parse(Console.ReadLine());

            total_suma = entero + entero2/2;

            Console.Write("El total de la suma es: " + total_suma);
            Console.Read();
        }
    }
}
