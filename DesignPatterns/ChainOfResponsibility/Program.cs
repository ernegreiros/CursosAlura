using ChainOfResponsibility.Descontos;
using ChainOfResponsibility.RequisicaoBancaria;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaDescontos();
            Console.WriteLine("\n\n-------------------------------------\n\n");
            FormataConta();
            Console.ReadLine();
        }

        private static void FormataConta()
        {
            Conta conta = new Conta("Joao", 1000.0);
            
            Requisicao requisicaoXML = new Requisicao(Formato.XML);
            Requisicao requisicaoCSV = new Requisicao(Formato.CSV);
            Requisicao requisicaoPorcento = new Requisicao(Formato.PORCENTO);

            FormatadorDeConta formatador = new FormatadorDeConta();

            Console.WriteLine("Requisitando Formato XML...");
            formatador.Formatar(conta, requisicaoXML);

            Console.WriteLine("Requisitando Formato CSV...");
            formatador.Formatar(conta, requisicaoCSV);

            Console.WriteLine("Requisitando Formato Porcentagem...");
            formatador.Formatar(conta, requisicaoPorcento);
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

            Orcamento orcamento4 = new Orcamento();
            orcamento4.AdicionaItem(new Item("Lapis", 30.00));
            orcamento4.AdicionaItem(new Item("Caneta", 30.00));

            CalculadorDeDesconto calculadora = new CalculadorDeDesconto();
            double desconto;

            Console.WriteLine("Calculando Desconto Orçamento 1: ");
            desconto = calculadora.CalculaDesconto(orcamento1);
            Console.WriteLine("Valor total: " + orcamento1.Valor + "\nValor Desconto: " + desconto);

            Console.WriteLine("Calculando Desconto Orçamento 2: ");
            desconto = calculadora.CalculaDesconto(orcamento2);
            Console.WriteLine("Valor total: " + orcamento2.Valor + "\nValor Desconto: " + desconto);

            Console.WriteLine("Calculando Desconto Orçamento 3: ");
            desconto = calculadora.CalculaDesconto(orcamento3);
            Console.WriteLine("Valor total: " + orcamento3.Valor + "\nValor Desconto: " + desconto);

            Console.WriteLine("Calculando Desconto Orçamento 4: ");
            desconto = calculadora.CalculaDesconto(orcamento4);
            Console.WriteLine("Valor total: " + orcamento4.Valor + "\nValor Desconto: " + desconto);
        }
    }
}
