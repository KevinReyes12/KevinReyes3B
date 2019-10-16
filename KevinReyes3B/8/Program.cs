using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear un programa en C# que lea un número entero y positivo y que escriba tres columnas. La primera
//cuenta desde uno hasta el número escrito contando de uno en uno; la segunda columna cuenta de dos
//en dos y la tercera de tres.
namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Ingrese un número entero: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (numero<=0)
            {
                Console.WriteLine("** Por favor, ingrese un número positivo **" );
            }
            Program.ColUno(numero);
            Program.ColDos(numero,numero);
            Program.ColTres(numero,numero);
                  
            Console.ReadKey();
        }
        static void ColUno(int num)
        {
            int contador = 0;
            Console.WriteLine("COLUMNA QUE CUENTA DE UNO EN UNO");//Columna que cuenta de uno en uno
            Console.WriteLine("\n");
            for (int i = 0; i < num; i++)
            {
                contador++;
                Console.WriteLine($"  {contador}");
            }
        }
        static void ColDos(int num,int num2)
        {
            int contador = 0;
            Console.WriteLine("\n");
            Console.WriteLine("COLUMNA QUE CUENTA DE DOS EN DOS (Se imprime el número que se ingreso, porque la actividad pide que cuente hasta el número escrito)");//Columna que cuenta de dos en dos
            Console.WriteLine("\n");
            num = num / 2;
            for (int i = 0; i < num; i++)
            {
                contador = contador + 2;
                Console.WriteLine($"  {contador}");
            }
            if (contador==num2)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"  {num2}");//Se imprime el número que se ingreso, porque la actividad pide que cuente hasta el número escrito 
            }
            
        }
        static void ColTres(int num,int num2)
        {
            
            int contador = 0;
            Console.WriteLine("\n");
            Console.WriteLine("COLUMNA QUE CUENTA DE TRES EN TRES (Se imprime el número que se ingreso, porque la actividad pide que cuente hasta el número escrito)");//Columna que cuenta de tres en tres
            Console.WriteLine("\n");
            num = num / 3;
            for (int i = 0; i < num; i++)
            {
                contador = contador + 3;
                Console.WriteLine($"  {contador}");
                
            }
            if (contador==num2)
            {
                Console.WriteLine("");
            }
            else {
                Console.WriteLine($"  {num2}");//Se imprime el número que se ingreso, porque la actividad pide que cuente hasta el número escrito 
            }
            
        }
    }
}
