using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear un programa que muestre un menú como este:
//1) Salir
//2) Sumatorio
//3) Factorial
//Tras mostrar el menú, el programa debe leer un número del 1 al tres si se elige 1, el programa acaba.Si se
//elige 2 se calcula el sumatorio del número, si se elige 3 se calcula la factorial(en ambos casos el programa
//pedirá escribir el número sobre el que se calcula el sumatorio o la factorial). Tras calcular el sumatorio o la
//factorial e indicar el resultado, el programa volverá a mostrar el menú y así sucesivamente.
namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Menu();
           
        }
        static void Menu()
        {
            int opcion = 0;
            Console.WriteLine("1) Salir");
            Console.WriteLine("2) Sumatorio");
            Console.WriteLine("3) Factorial");
            opcion = int.Parse(Console.ReadLine());
            Opciones(opcion);
            Console.ReadKey();
        }
                       
        static void Opciones(int op)
        {
            switch (op)
            {
                case(1): Console.ReadKey();
                    break;
                case(2): Program.Sumatorio();
                    break;

                case(3): Program.Factorial();
                    break;
                default: Console.WriteLine("Opcion no válida");
                    break;
            }
            
        }

        static void Sumatorio()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese un número para calcular el sumatorio");
            int numero = 0, resultado = 0;
            numero = int.Parse(Console.ReadLine());
            for (int i = 0; i <= numero; i++)
            {
                resultado = resultado + i;
            }
            Console.WriteLine($"El resultado es: {resultado}");
            Console.WriteLine("\n");
            Program.Menu();
            
        }
        static void Factorial()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese un número para calcular la factorial");
            int numero = 0, resultado = 1;
            numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }
            Console.WriteLine($"El resultado es: {resultado}");
            Console.WriteLine("\n");
            Program.Menu();
           
        }
        
        
    }
}
