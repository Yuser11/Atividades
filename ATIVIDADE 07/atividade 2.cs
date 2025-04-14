using System;

namespace verifica_positivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double num1 = 14.1;
            Console.Write("O numero "+ num1);
            if (num1 > 0)
            {
                Console.WriteLine(" é positivo");
            }
            else if (num1 < 0)
            {
                Console.WriteLine(" é negativo");
            }
            else
            {
                Console.WriteLine(" é neutro");
            }
            Console.WriteLine("Aperte enter para finalizar");
            Console.Read();
        }
    }
}