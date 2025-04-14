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
            Console.WriteLine("Escreva o primeiro numero");
            Double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva o segundo numero");
            Double num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2) 
            {
                Console.WriteLine("O numero um é maior que o numero 2");
            }else
            {
                Console.WriteLine("O numero um não é maior que o numero 2");
            }
            Console.WriteLine("Aperte enter para finalizar");
            Console.Read();
        }
    }
}
