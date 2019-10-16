using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear un programa para calcular el salario semanal de unos empleados a los que se les paga 15 dólares
//por hora si éstas no superan las 35 horas.Cada hora por encima de 35 se considerará extra y se paga a
//22 dólares.
//El programa pide las horas del trabajador y devuelve el salario que se le debe pagar.
//Además, el programa debe preguntar si deseamos calcular otro salario, si es así el programa se repite.
namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Ingreso_hora();
        }
        static void Calcular(int h)
        {
            int salario = 0, extrah = 0;
            if (h<=35)
            {
                salario = h * 15;
            }
            else
            {
                extrah = h - 35;
                salario = (extrah * 22 )+525;//525 es el pago por las m5 horas
            }
            Console.WriteLine($"El salario a pagar es de: {salario}");
            Console.WriteLine("\n");
            Program.Seguir();
        }
        static int Ingreso_hora()
        {
            int hora = 0;
            Console.WriteLine("Ingrese las horas del trabajador");
            hora = int.Parse(Console.ReadLine());
            Calcular(hora);
            return hora;
        }
        static void Seguir()
        {
            Console.WriteLine("¿Desea calcular otro salario?");
            Console.WriteLine("Escriba SI para continuar ó NO para terminar");
            string respuesta = "", s = "SI", n = "NO";
            respuesta = Console.ReadLine();
            Console.WriteLine("\n");
            if (respuesta==s)
            {
                Program.Ingreso_hora();
            }
            else
            {
                if (respuesta==n)
                {
                    Console.ReadKey();
                }
            }
        }
    }
}
