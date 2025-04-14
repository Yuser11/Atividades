using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero");
            Double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("escreva outro");
            Double num2 = Convert.ToDouble(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Os numeros são iguais");
            }
            else
            {
                Console.WriteLine("Os numeros são diferente");
            }
            Console.WriteLine("Aperte enter para finalizar");
            Console.Read();

        }
    }
}