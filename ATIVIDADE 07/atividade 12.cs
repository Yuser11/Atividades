using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um ano");
            int ano = Convert.ToInt32(Console.ReadLine());
            if (ano >= 2001 && ano <=2100) 
            {
                Console.WriteLine("Pertence ao seculo XXI");
            }else
            {
                Console.WriteLine("Nao pertence ao seculo XXI");
            }
            Console.WriteLine("Aperte enter para finalizar");
            Console.Read();
        }
    }
}
