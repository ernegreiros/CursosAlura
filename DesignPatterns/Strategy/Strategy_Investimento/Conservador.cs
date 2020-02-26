namespace Strategy.Strategy_Investimento
{
    public class Conservador : IInvestimento
    {
        public double CalcularLucro(double valorInvestido)
        {
            return valorInvestido * 0.008;
        }
    }
}
