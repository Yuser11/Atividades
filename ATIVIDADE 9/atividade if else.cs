using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static void Nota()
        {
            Console.WriteLine("Qual a nota do aluno?");
            Double nota = Convert.ToDouble(Console.ReadLine());
            if (nota >= 9&& nota <=10) 
            {
                Console.WriteLine("A nota " + nota + " recebe o conceito A");
            }
            if (nota >= 7 && nota < 9)
            {
                Console.WriteLine("A nota " + nota + " recebe o conceito B");
            }
            if (nota >= 5 && nota < 7)
            {
                Console.WriteLine("A nota " + nota + " recebe o conceito C");
            }
            if (nota >= 3 && nota < 5)
            {
                Console.WriteLine("A nota " + nota + " recebe o conceito D");
            }
            if (nota < 3)
            {
                Console.WriteLine("A nota " + nota + " recebe o conceito E");
            }else
            {
                Console.WriteLine("Nota inválida");
            }
        }
        public static void JuroSimples()
        {
            Console.WriteLine("Qual o capital inicial?");
            Double capital = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a taxa de juros em porcentagem?");
            Double taxa = (Convert.ToDouble(Console.ReadLine())/100);
            Console.WriteLine("Por quantos meses?");
            Double tempo = Convert.ToDouble(Console.ReadLine());
            Double juro = capital * taxa * tempo;
            Console.WriteLine("O juro é de R$"+juro);
        }
        public static void Numero100 ()
        {
            Console.WriteLine("Digite um número");
            Double num1 = Convert.ToDouble(Console.ReadLine());
            if (num1 > 0 &&num1 < 100)
            {
                Console.WriteLine("Valor permitido");

            }
            else 
            { 
                Console.WriteLine("O valor não é permitido");
            }
        }
        public static void MontanteSimples() 
        {
            Console.WriteLine("Qual o capital inicial?");
            Double capital = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a taxa de juros em porcentagem?");
            Double taxa = (Convert.ToDouble(Console.ReadLine()) / 100);
            Console.WriteLine("Por quantos meses?");
            Double tempo = Convert.ToDouble(Console.ReadLine());
            Double montante = capital * (1+taxa * tempo);
            Console.WriteLine("O montante final é de R$"+montante);
        }
        public static void MontanteComposto()
        {        
            Console.WriteLine("Qual o capital inicial?");
            Double capital = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a taxa de juros mensal em porcentagem?");
            Double taxa = (Convert.ToDouble(Console.ReadLine()) / 100);
            Console.WriteLine("Por quantos meses?");
            int tempo = Convert.ToInt32(Console.ReadLine());
            Double resultado = Math.Pow((1+taxa), tempo);
            Double montante = capital * resultado;
            Console.WriteLine("O montante final é de R$"+montante);
        }
        public static void Categoria()
        {
            Console.WriteLine("Qual a idade do nadador?");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade <= 8)
            {
                Console.WriteLine("O nadador é da categoria infantil A");
            }
            else if (idade < 13)
            {
                Console.WriteLine("O nadador é da categoria infantil B");
            }
            else if ( idade < 18)
            {
                Console.WriteLine("O nadador é da categoria Juvenil A");
            }
            else if (idade< 21)
            {
                Console.WriteLine("O nadador é da categoria Juvenil B");
            }
            else if (idade >=21)
            {
                Console.WriteLine("O nadador é da categoria Sênior"); ;
            }
            else
            {
                Console.WriteLine("idade inválida");
            }
        }
        public static void MediaFrequencia() 
        {
            Console.WriteLine("Digite a freqência em porcentagem?");
            Double frequencia = Convert.ToDouble(Console.ReadLine());
            if( frequencia <90)
            {
                Console.WriteLine("Qual a primeira nota");
                int nota1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Qual a segunda nota");
                int nota2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Qual a terceira nota");
                int nota3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Qual a quarta nota");
                int nota4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Qual a quinta nota");
                int nota5 = Convert.ToInt32(Console.ReadLine());
                double media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
                if (media >= 8)
                {
                    Console.WriteLine("Aluno aprovado");
                }
                else if (media > 5 && media < 8) 
                {
                    Console.WriteLine("Aluno em recuperação");
                }else
                {
                    Console.WriteLine("Aluno réprovado");
                }

            }
            else
            {
                Console.WriteLine("Aluno reprovou por falta");
            }
            
        }
        public static void TresValores()
        {
            Console.WriteLine("Digite 3 valores inteiros");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2 && num3 > num2)
            {
                int soma = num1 + num2 + num3;
                Console.WriteLine("Os dois primeiros números são iguais, e " + num3 + " é maior que " + num2);
                Console.WriteLine("Somando todos, resulta em " + soma);
            }
            else if (num3 < num2)
            {
                int result = num3 * num2;
                Console.WriteLine("Os dois primeiros números são diferentes, e "+num2 + " é maior que " + num3 + ",\n multiplicando os dois ultimos resulta em " + result);
            }else if (num1 != num2)
            {
                Console.WriteLine("O número 1 e o número 2 não são iguais");
            }else 
            {
                Console.WriteLine("Nada acontece");
            }
        }
        public static void ProfissaoIdade()
        {
            Console.WriteLine("Qual sua profissão");
            string prof = Console.ReadLine().ToLower();
            Console.WriteLine("Digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (prof == "nadador" || prof == "jogador de futebol")
            {
                if (idade < 12)
                {
                    Console.WriteLine("Catregoria infantil");
                }
                else if (idade < 16) 
                {
                    Console.WriteLine("Categoria juvenil");
                }else if(idade < 20) 
                {
                    Console.WriteLine("Categoria júnior");
                }else 
                {
                    Console.WriteLine("Categoria adulto");
                }
            }else
            {
                Console.WriteLine("Sua profissão é " + prof);
            }

        }
        public static void Perguntas()
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 18)
            {
                Console.WriteLine("Qual a faculdade que você gostaria de fazer?");
                string faculdade = Console.ReadLine();
                Console.WriteLine("Você quer tirar carta?");
                string resposta = Console.ReadLine().ToLower();
                if (resposta == "sim") { resposta = ""; }
                Console.WriteLine("Qual país gostaria de morar");
                string pais= Console.ReadLine();
                Console.WriteLine("Você quer fazer faculdade na " + faculdade);
                Console.WriteLine("Você " + resposta + "quer tirar a carta");
                Console.WriteLine("O país que você gostaria morar é " + pais);
            }
            else
            {
                Console.WriteLine("Você é menor de idade");
            }
        }
        public static void DoisNumeros()
        {
            Console.WriteLine("Digite 2 números inteiros");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if(num1 > 10&& num2 >10&& num1>num2)
            {
                int soma = num1 + num2;
                int sub = num1 - num2;
                int mult = num1 * num2;
                Double div =  Convert.ToDouble(num1)/Convert.ToDouble(num2);
                Console.WriteLine("A soma dos dois é " + soma + "\nA subtração dos dois é "+sub+"\nA multiplicação dos dois é "+mult+"\nA divisão dos dois é "+div  );
            }else if ((num1 > num2)==false)
            {
                Console.WriteLine("O número 1 é menor que o número 2");
            }else if ((num1 > 10 && num2> 10)==false)
            {
                Console.WriteLine("Números menores que 10");
            }
        }
        public static void Triangulo()
        {
            Console.WriteLine("Qual a base do triângulo?");
            Double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a altura do triângulo?");
            Double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A área desse triângulo é "+(n1*n2/2));
        }
        public static void ComparaJuros() 
        {
            Console.WriteLine("Qual o capital inicial?");
            Double capital = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a taxa de juros mensal em porcentagem?");
            Double taxa = (Convert.ToDouble(Console.ReadLine()) / 100);
            Console.WriteLine("Por quantos meses?");
            Double tempo = Convert.ToDouble(Console.ReadLine());
            Double montanteSimples = capital * (1 + taxa * tempo);
            Double resultado = Math.Pow((1 + taxa), tempo);
            Double montanteComposto = capital * resultado;
            if (montanteComposto > montanteSimples)
            {
                Console.WriteLine("O juros composto vai gerar R$" + (montanteComposto - montanteSimples) + " a mais, sendo mais lucrativo que o simples");
            }
            else
            {
                Console.WriteLine("O juros simples vai gerar R$" + (montanteSimples - montanteComposto) + " a mais, sendo mais lucrativo que o composto");
            }
        }
        public static void Imposto() 
        {
            Console.WriteLine("Digite o valor do seu salário mensal");
            Double salario= Double.Parse(Console.ReadLine());
            if (salario > 2000) 
            {
                Console.WriteLine("Isento de imposto");
            }
            else if (salario >= 2000 &&salario < 3500)
            {
                Console.WriteLine("Precisa pagar R$"+(salario*0.10)+ "de imposto(10%)");
            }
            else if (salario >= 3500 && salario < 5000)
            {
                Console.WriteLine("Precisa pagar R$" + (salario * 0.15) + "de imposto(15%)");
            }
            else
            {
                Console.WriteLine("Precisa pagar R$" + (salario * 0.20) + "de imposto(20%)");
            }
        }
        public static void Recuperacao()
        {
            Console.WriteLine("Digite as 3 notas do aluno");
            double num1 = Convert.ToInt32(Console.ReadLine());
            double num2 = Convert.ToInt32(Console.ReadLine());
            double num3 = Convert.ToInt32(Console.ReadLine());
            double media = (num1 + num2+ num3)/3;
            if (media <4)
            {   
                Console.WriteLine("Aluno reprovado");
            }
            else if (media >=4 && media <6)
            {
                Console.WriteLine("Qual a nota da recuperação?");
                Double recupercao= Convert.ToDouble(Console.ReadLine());
                media = (media + recupercao) / 2;
                if (media >= 6)
                {
                    Console.WriteLine("Aprovado após recuperação");
                }
                else
                {
                    Console.WriteLine("Reprovado após recuperação");
                }
            }
            else
            {
                Console.WriteLine("Aluno aprovado");
            }
            
        }
        public static void Desconto()
        {
            Console.WriteLine("Digite o valor total da compra");
            Double valor = Double.Parse(Console.ReadLine());
            if (valor <= 100)
            {
                Console.WriteLine("Não tem desconto");
            }
            else if (valor > 100 && valor <= 500)
            {
                Console.WriteLine("Sua compra de R$"+valor+ " com 10% de desconto ficará R$"+(valor*0.90));
            }
            else if (valor > 500 && valor <= 1000)
            {
                Console.WriteLine("Sua compra de R$" + valor + " com 15% de desconto ficará R$" + (valor * 0.85));
            }
            else
            {
                Console.WriteLine("Sua compra de R$" + valor + " com 20% de desconto ficará R$" + (valor * 0.80));
            }
        }
    }
}
