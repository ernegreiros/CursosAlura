using System;

namespace Strategy.Strategy_Investimento
{
    public class Moderado : IInvestimento
    {
        public double CalcularLucro(double valorInvestido)
        {
            var chances = new Random().Next(101);
            double rendimentos;

            if (chances <= 50)
                rendimentos = valorInvestido * 0.025;
            else
                rendimentos = valorInvestido * 0.07;

            return rendimentos;
        }
    }
}
