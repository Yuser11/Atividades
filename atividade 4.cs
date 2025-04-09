using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade > 16) 
            {
                Console.WriteLine("Você pode votar");
            }else
            {
                Console.WriteLine("Você não pode votar");
            }
            Console.WriteLine("Aperte enter para finalizar");
            Console.ReadLine();
        }
    }
}
