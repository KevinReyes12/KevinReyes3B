using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear el programa asteriscos4 en el que se introduce un número entero y se crea una pirámide de
//asteriscos.Por ejemplo, si se introduce el 6, el resultado sería:
//     *
//    ***
//   *****
//  *******
// *********
//***********
namespace asteriscos4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número para crear la pirámide: ");
            int numero = 0;
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for (int i = 1; i <= numero; i++)
            {
                for (int j = numero; j >= i; j--)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2*i-1; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("  ");
            }
            Console.ReadKey();
        }
    }
}
