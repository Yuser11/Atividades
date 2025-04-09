using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as notas");
            Double nota1 = Convert.ToDouble(Console.ReadLine());
            Double nota2 = Convert.ToDouble(Console.ReadLine());
            Double nota3 = Convert.ToDouble(Console.ReadLine());
            Double nota4 = Convert.ToDouble(Console.ReadLine());
            Double nota5 = Convert.ToDouble(Console.ReadLine());
            Double media = (nota1 * nota2 * nota3 * nota4 * nota5) / 5;
            if (media >=7) 
            {
                Console.WriteLine("Escreva a frequencia em porcentagem");

                int frequencia = Convert.ToInt32(Console.ReadLine());
                if (frequencia >= 75)
                {
                    Console.WriteLine("Aluno aprovado");
                }else
                {
                    Console.WriteLine("Aluno reprovado por presença");
                }
            }
            else
            {
                Console.WriteLine("Aluno reprovado por nota");
            }
            Console.WriteLine("Aperte enter para finalizar");
            Console.Read();
        }
    }
}
