using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%3 == 0 && num%5==0) 
            {
                Console.WriteLine("O numero é divisivel por 3 e por 5");
            }else
            {
                Console.WriteLine("O numero não é divisivel por 3 e por 5");
            }
            Console.WriteLine("Aperte enter para finalizar");
            Console.Read();
        }
    }
}
