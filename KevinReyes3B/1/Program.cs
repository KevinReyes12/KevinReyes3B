using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programa que lea una serie de números por teclado e indique cuál es el mayor.
namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, n1 = 0, n2 = 0, n3 = 0;
            Console.WriteLine("Ingrese un número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número");
            n3 = int.Parse(Console.ReadLine());

            if (n3 >= n2)
            {
                if (n3 >= n1)
                {
                    numero = n3;
                }
                else
                    numero = n1;
            }
            else
                if (n2 >= n1)
            {
                numero = n2;
            }
            else
                numero = n1;

            Console.WriteLine($"El número MAYOR es: {numero}");
            Console.ReadKey();
        }
    }
}
