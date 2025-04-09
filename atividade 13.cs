using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num %3 ==0) 
            {
                Console.WriteLine("O numero é multiplo de 3");
            }else
            {
                Console.WriteLine("O numero não é multiplo de 3");
            }
            Console.WriteLine("Aperte enter para finalizar");
            Console.Read();
        }
    }
}
