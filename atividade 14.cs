using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double novoSalario;
            Console.WriteLine("Digite seu salario atual");
            Double salario = Convert.ToDouble(Console.ReadLine());
            Double novoValeRefeicao;
            if (salario == 2000) 
            {
                Console.WriteLine("Qual o valor do vale refeição");
                Double valeRefeicao = Convert.ToDouble(Console.ReadLine());
                novoSalario = salario * 1.15;
                if(valeRefeicao >= 1000)
                {
                    novoValeRefeicao = valeRefeicao * 1.2253;
                    Console.WriteLine("O novo salário é de R$" + novoSalario);
                    Console.WriteLine("O vale refeição agora é de R$" + novoValeRefeicao);
                }
                else
                {
                    Console.WriteLine("O novo salário é de R$" + novoSalario);
                    Console.WriteLine("O vale refeição continua sendo de R$" + valeRefeicao);
                }
                
            }
            else
            {
                Console.WriteLine("Qual o valor do vale refeição");
                Double valeRefeicao = Convert.ToDouble(Console.ReadLine());
                novoSalario = salario * 1.1;
                Console.WriteLine("O novo salário é de R$" + novoSalario);
                Console.WriteLine("O vale refeição continua sendo de R$" + valeRefeicao);

            }
        }
    }
}
