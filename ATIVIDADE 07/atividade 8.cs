using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor");
            int valor = Convert.ToInt32(Console.ReadLine());
            if (valor > 0) 
            {
                Console.WriteLine("Escreva mais 2 numeros inteiros");
                int valor1 = Convert.ToInt32(Console.ReadLine());
                int valor2 = Convert.ToInt32(Console.ReadLine());
                int resultado = valor * valor1 * valor2;
                if (resultado > 45) 
                {
                    resultado++; resultado++; resultado++; resultado++; resultado++;
                    Console.WriteLine("O resultado, adicionando 5, é " + resultado);
                }
                Console.WriteLine("Aperte enter para finalizar");
                Console.Read();

            }
        }
    }
}
