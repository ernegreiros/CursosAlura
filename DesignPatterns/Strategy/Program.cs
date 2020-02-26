using Strategy.Strategy_Investimento;
using Strategy_Imposto;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Imposto");
            CalculoDeImpostos();

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Exercicio Investimento");

            CalculoDeInvestimento();

            Console.ReadLine();
        }

        private static void CalculoDeInvestimento()
        {
            ContaBancaria contaArrojado = new ContaBancaria(1000.0);
            ContaBancaria contaModerado = new ContaBancaria(1000.0);
            ContaBancaria contaConservador = new ContaBancaria(1000.0);

            Arrojado investimentoArrojado = new Arrojado();
            Moderado investimentoModerado = new Moderado();
            Conservador investimentoConservador = new Conservador();
            RealizadorDeInvestimentos investimento = new RealizadorDeInvestimentos();

            Console.WriteLine("Saldo pré investimento: " + contaArrojado.Saldo);
            investimento.Investir(contaArrojado, investimentoArrojado);
            Console.WriteLine("Saldo após investimento ARROJADO: " + contaArrojado.Saldo);

            Console.WriteLine("Saldo pré investimento: " + contaModerado.Saldo);
            investimento.Investir(contaModerado, investimentoModerado);
            Console.WriteLine("Saldo após investimento MODERADO: " + contaModerado.Saldo);

            Console.WriteLine("Saldo pré investimento: " + contaConservador.Saldo);
            investimento.Investir(contaConservador, investimentoConservador);
            Console.WriteLine("Saldo após investimento CONSERVADOR: " + contaConservador.Saldo);

        }

        private static void CalculoDeImpostos()
        {
            Orcamento orcamento = new Orcamento(1000.0);

            ICMS icms = new ICMS();
            ISS iss = new ISS();
            ICCC iccc = new ICCC();

            CalculadorDeImposto calculadorDeImposto = new CalculadorDeImposto();

            Console.WriteLine("Calculando ICMS");
            calculadorDeImposto.CalcularImposto(orcamento, icms);
            Console.WriteLine("Calculando ISS");
            calculadorDeImposto.CalcularImposto(orcamento, iss);
            Console.WriteLine("Calculando ICCC");
            calculadorDeImposto.CalcularImposto(orcamento, iccc);
        }
    }
}
