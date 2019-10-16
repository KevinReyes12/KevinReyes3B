using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear el programa en el que se introduce un número entero y se crea un rombo de
//asteriscos.
namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número para crear el rombo: ");
            int numero = 0;
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for (int i = 1; i <= numero - 1; i++)
            {
                for (int j = numero; j >= i; j--)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("  ");
            }
            for (int i = 1; i <= numero; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 2*numero-1; k >= 2 * i - 1; k--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("  ");
            }
            Console.ReadKey();
        }
    }
}
