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
            Console.WriteLine("Escreva a senha");
            int senha = Convert.ToInt32(Console.ReadLine());
            if (senha == 56789) 
            {
                Console.WriteLine("Acesso permitido");
            }else
            {
                Console.WriteLine("Acesso negado");
            }
            Console.WriteLine("Aperte enter para finalizar");
            Console.ReadLine();
        }
    }
}
