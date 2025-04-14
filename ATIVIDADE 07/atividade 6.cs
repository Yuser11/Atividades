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
            Console.WriteLine("Quantos produtos foram comprados?");
            int quant = Convert.ToInt32(Console.ReadLine());
            if ( quant > 100 ) 
            {
                Console.WriteLine("Qual o preço?");
            Double preco = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("O novo preço com desconto de 12,5% é " + (preco * 0.875));
            }else
            {
                Console.WriteLine("Não tem desconto");
            }           
          
            Console.WriteLine("Aperte enter para finalizar");
            Console.Read();
        }
    }
}