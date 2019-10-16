using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear un programa que lea un número entero y a partir de él cree un cuadrado de asteriscos con ese
tamaño.Los asteriscos sólo se verán en el borde del cuadrado, no en el interior.*/
namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Cuadrado();
            
        }
        static void Cuadrado()
        {
            Console.Write("Ingrese número de tamaño del cuadrado: ");
            int numero = 0;
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for (int k = 0; k < numero; k++)//Línea de arriba
            {
                Console.Write(" *");
            }
            Console.WriteLine(" ");
            
            for (int i = 0; i < numero-2; i++)//Medio
            {
                Console.Write(" *");
                for (int j = 0; j < numero-2; j++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(" *");
            }
            
            for (int k = 0; k < numero; k++)//Línea de abajo
            {
                Console.Write(" *");
            }
            Console.WriteLine(" ");

            Console.ReadKey();
        }
    }
}
