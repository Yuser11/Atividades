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
            int nota1 = 8;
            int nota2 = 8;
            int nota3 = 6;
            int media = (nota1 + nota2 + nota3)/3;
            if (media >7)
            {
                Console.WriteLine("Você tirou uma nota maior que a média");
            }
            else
            {
                Console.WriteLine("Você não tirou uma nota maior que a média");
            }
            Console.WriteLine("Aperte enter para finalizar");
            Console.Read();

        }
    }
}