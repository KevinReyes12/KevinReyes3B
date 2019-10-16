using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear el programa tablaMultiplicar que escriba la tabla de multiplicar del número 1 al número 15.
namespace tablaMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Multiplicar();
        }
        static void Multiplicar()
        {
            Console.WriteLine("Tabla de multiplicar del número 1 al número 15.");
            int resultado = 0;
            int multiplicador = 1, multiplicando = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 12; j++)//Columnas
                {
                    multiplicando++;
                    resultado = multiplicador * multiplicando;
                    Console.WriteLine($"{multiplicador} * {multiplicando} = {resultado}");
                }
                Console.WriteLine("\n");
                multiplicador++;
                multiplicando=0;
                
            }
            Console.ReadKey();
        }
    }
}
