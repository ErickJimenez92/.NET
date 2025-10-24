using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuracontrol
{
    internal class Program
    {
        static void Main(string[] args) //punto de partida
        {
            //tipo de datos

            Console.WriteLine("Bienvenido Mathew");
            Console.WriteLine("ingrese la primera nota");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            if (nota1>5 || nota1<1)
            {
                Console.WriteLine("ingrese nuevamente el numero, numero ingresado invalido");
                decimal nota1 = decimal.Parse(Console.ReadLine());
            }




        }
    }
}
