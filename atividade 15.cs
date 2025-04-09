using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int digits =0;
                Console.WriteLine("Escreva um numero de 11 digitos, sem nenhum caracter");
                Double input = Convert.ToDouble(Console.ReadLine());
                /// Returns how many digits there are to the left of the .
                    while (input >= 1)
                    {
                        digits++;
                        input /= 10;
                    }
                Console.WriteLine(digits);
                if (digits == 11) 
                {
                    Console.WriteLine("Numero válido");
                }else
                {
                    Console.WriteLine("Numero inválido");
                }
            }
            catch
            {
                Console.WriteLine("Numero inválido");
            }
        }
    }
}
