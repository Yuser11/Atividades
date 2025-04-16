using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EscolhaCompraCarro();
        }
        static void EscolhaCompraCarro()
        {
            try
            {
                Double valorCarro = 60852;
                Console.WriteLine("Escolha a opção que gostaria de comprar seu carro:\n1-A vista\n2-A prazo\n3-Deixar o dinheiro investido");
                string operacao = Console.ReadLine();
                switch (operacao)
                {

                    case "1":
                        Double descontoEmPorcentagem = 14.32;
                        descontoEmPorcentagem = descontoEmPorcentagem / 100;
                        Console.WriteLine("Pagando a vista, foi aplicado um desconto de " + descontoEmPorcentagem + ", o preço final do carro agora é R$" + (valorCarro * (1 - descontoEmPorcentagem)));
                        break;

                    case "2":
                        Double taxaEmPorcentagem = 22.12;
                        taxaEmPorcentagem = taxaEmPorcentagem / 100;
                        Console.WriteLine("Pagando a prazo, foi aplicado um aumento de " + taxaEmPorcentagem + ", o preço final do carro agora é R$" + (valorCarro * (1 + taxaEmPorcentagem)));
                        break;

                    case "3":
                        Console.WriteLine("Digite o valor que deseja deixar em investimento");
                        double capital = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Qual a taxa mensal em porcentagem desse investimento");
                        double taxaSimples = (Convert.ToDouble(Console.ReadLine()) / 100);
                        Console.WriteLine("Por quantos meses?");
                        int tempo = Convert.ToInt32(Console.ReadLine());
                        Double montante = capital * (1 + taxaSimples * tempo);
                        Console.WriteLine("O montante final vai ficar R$" + montante);
                        break;

                    default:
                        Console.WriteLine("Número não corresponde a uma operação na lista");
                        break;

                }
            }
            catch
            {
                Console.WriteLine("Operação inválida");
            }
        }
    }
}
