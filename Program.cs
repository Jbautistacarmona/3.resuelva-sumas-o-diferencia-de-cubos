using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.resuelva_sumas_o_diferencia_de_cubos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculador de Suma o Diferencia de Cubos");//mensaje en pantalla inicial.
            Console.WriteLine("-----------------------------------------");

            Console.Write("Ingrese el primer número: ");
            int firstNumber = int.Parse(Console.ReadLine());//Convierte la representación en forma de cadena de un número en el entero de 32 bits con signo equivalente.

            Console.Write("Ingrese el segundo número: ");
            int secondNumber = int.Parse(Console.ReadLine());//Convierte la representación en forma de cadena de un número en el entero de 32 bits con signo equivalente.

            Console.WriteLine("\n¿Qué operación desea realizar?");//menu para que el usuario eliga la operacion a realizar.
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Diferencia");
            Console.Write("Su elección: ");
            int choice = int.Parse(Console.ReadLine());//variable local.

            int result = 0;
            if (choice == 1)//la bifurcación condicional. El cuerpo de una instrucción if se ejecuta si el valor de la expresión es distinto de cero.
            {
                result = CubeSum(firstNumber, secondNumber);
                Console.WriteLine("\nEl resultado es: " + firstNumber + "^3 + " + secondNumber + "^3 = " + result);
            }
            else if (choice == 2)//Es usada para ejecutar una instrucción o bloque de instrucciones solo si una condición es cumplida
            {
                result = CubeDifference(firstNumber, secondNumber);
                Console.WriteLine("\nEl resultado es: " + firstNumber + "^3 - " + secondNumber + "^3 = " + result);
            }
            else//Es usada para ejecutar una instrucción o bloque de instrucciones solo si una condición es cumplida
            {
                Console.WriteLine("\nOpción inválida.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static int CubeSum(int a, int b) //Una variable int estática permanece en la memoria mientras se ejecuta el programa
        {
            return a * a * a + b * b * b;
        }

        static int CubeDifference(int a, int b) //Una variable int estática permanece en la memoria mientras se ejecuta el programa
        {
            return a * a * a - b * b * b;
        }
    }
}