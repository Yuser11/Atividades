using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma letra");
            char letra = (char)Console.Read();      
                if (letra == 'a'||letra =='e'|| letra == 'i' || letra == 'o'||letra == 'u'|| letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U') 
                {
                    Console.WriteLine("É uma vogal");
                }
                else
                {
                    Console.WriteLine("É uma consoante");
                }                        
            Console.WriteLine("Aperte enter para finalizar");
            Console.Read();            
        }
    }
}
