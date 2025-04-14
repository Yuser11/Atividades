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
            Console.WriteLine("Qual sua idade?");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o nome da sua escola?");
            string escola =Console.ReadLine().ToUpper;
            Console.WriteLine("O novo preço com desconto de 12,5% é " + (preco * 0.875));
            if (idade <=18 && escola == "SENAI" ) 
            {         
                Console.Write("O aluno é estudante do curso técnico em desenvolvimento de sistemas")
            }else
            {
                Console.WriteLine("O aluno não é estudante do Sesi/Senai);
            }        
          
            Console.WriteLine("Aperte enter para finalizar");
            Console.Read();
        }
    }
}