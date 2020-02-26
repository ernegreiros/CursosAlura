namespace Strategy.Strategy_Investimento
{
    public class RealizadorDeInvestimentos
    {
        public void Investir(ContaBancaria conta, IInvestimento estrategiaDeInvestimento)
        {
            var rendimentoInvestimento = estrategiaDeInvestimento.CalcularLucro(conta.Saldo);
            var impostoSobreORendimento = rendimentoInvestimento * 0.25;

            var rendimentoSemImposto = rendimentoInvestimento - impostoSobreORendimento;

            conta.AdicionaSaldo(rendimentoSemImposto);
        }
    }
}
