using ChainOfResponsibility.Descontos;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaDescontos();
            Console.ReadLine();
        }

        private static void CalculaDescontos()
        {
            Orcamento orcamento1 = new Orcamento();
            orcamento1.AdicionaItem(new Item("Coca-Cola", 9.00));
            orcamento1.AdicionaItem(new Item("Arroz", 5.00));
            orcamento1.AdicionaItem(new Item("Frango", 15.00));
            orcamento1.AdicionaItem(new Item("Bata frita", 40.00));
            orcamento1.AdicionaItem(new Item("Pudim", 15.00));
            orcamento1.AdicionaItem(new Item("Mousse", 12.00));

            Orcamento orcamento2 = new Orcamento();
            orcamento2.AdicionaItem(new Item("Bota", 400.00));
            orcamento2.AdicionaItem(new Item("Jaqueta de Couro", 300.00));

            Orcamento orcamento3 = new Orcamento();
            orcamento3.AdicionaItem(new Item("Balde de Pipoca", 30.00));

            CalculadorDeDesconto calculadora = new CalculadorDeDesconto();

            Console.WriteLine("Calculando Desconto Orçamento 1: ");
            var desconto1 = calculadora.CalculaDesconto(orcamento1);
            Console.WriteLine("Valor total: " + orcamento1.Valor + "\nValor Desconto: " + desconto1);

            Console.WriteLine("Calculando Desconto Orçamento 2: ");
            var desconto2 = calculadora.CalculaDesconto(orcamento2);
            Console.WriteLine("Valor total: " + orcamento2.Valor + "\nValor Desconto: " + desconto2);

            Console.WriteLine("Calculando Desconto Orçamento 3: ");
            var desconto3 = calculadora.CalculaDesconto(orcamento3);
            Console.WriteLine("Valor total: " + orcamento3.Valor + "\nValor Desconto: " + desconto3);

        }
    }
}
