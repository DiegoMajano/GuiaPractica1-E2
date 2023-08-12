using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuíaPractica1_E2
{
    internal class Program
    {

        static int Edad(int año)
        {
            int edad = (2023 - año);
            return edad;
        }

        static void Main(string[] args)
        {
            int año;

            Console.WriteLine("\t \t PROGRAMA PARA CONOCER EDAD POR AÑO DE NACIMIENTO ");
            Console.WriteLine("\n Digitar su año de nacimiento:");

            año = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Su edad actual es: " + Edad(año) + " años");

            Console.ReadKey();
        }
    }
}
