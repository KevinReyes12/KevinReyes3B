using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear un programa que escriba dos columnas de números, en la primera se colocan los números del 1 al
//100, en la segunda los números del 100 al 1
namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Columna del 1 al 100");
            Console.WriteLine("\n");
            int contador1 = 0, contador2 = 101;
            for (int i = 0; i < 100; i++)
            {
                contador1++;
                Console.WriteLine($"  {contador1} ");             
            }
            Console.WriteLine("\n");
            Console.WriteLine("Columna del 100 al 1");
            Console.WriteLine("\n");
            for (int j = 0; j < 100; j++)
            {
                contador2--;
                Console.WriteLine($"  {contador2} ");
            }
            Console.ReadKey();
        }
    }
}
