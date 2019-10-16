using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear un programa que lea cantidades y precios y al final indique el total de la factura.
//    Primero se pregunta:
//Introduzca la cantidad vendida tras lo cual el usuario introducirá un número entero positivo.
//Después se pregunta:
//Introduzca el precio que será un número decimal positivo.
//La lectura termina cuando en la cantidad se introduzca un cero.Si es así se escribirá el total.
namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("Introduzca la cantidad vendida:");
            int cantidad = 0;
            cantidad = int.Parse(Console.ReadLine());
            if (cantidad == 0)
            {
                //Console.Clear();
                Console.WriteLine($"El total de la factura es: {total}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Introduzaca el precio:");
                double precio = 0;
                precio = double.Parse(Console.ReadLine());


                total = precio * cantidad;
                Console.WriteLine($"El total de la factura es: {total}");

                Console.ReadKey();
            }
            
        }
    }
}
