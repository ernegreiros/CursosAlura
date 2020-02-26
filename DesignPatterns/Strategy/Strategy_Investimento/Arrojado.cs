using System;

namespace Strategy.Strategy_Investimento
{
    public class Arrojado : IInvestimento
    {
        public double CalcularLucro(double valorInvestido)
        {
            var chances = new Random().Next(101);
            double rendimentos;

            if (chances <= 20)
                rendimentos = valorInvestido * 0.05;
            else if(chances <= 30)
                rendimentos = valorInvestido * 0.03;
            else 
                rendimentos = valorInvestido * 0.006;

            return rendimentos;
        }
    }
}
