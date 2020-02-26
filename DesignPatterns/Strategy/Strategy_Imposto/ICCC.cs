namespace Strategy_Imposto
{
    public class ICCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double valorDoImposto;

            if (orcamento.Valor < 1000.00)
            {
                valorDoImposto = orcamento.Valor * 0.05;
            }
            else if (orcamento.Valor <= 3000.0 && orcamento.Valor >= 1000.00)
            {
                valorDoImposto  = orcamento.Valor * 0.07;
            }
            else
            {
                valorDoImposto = (orcamento.Valor * 0.08) + 30.0;
            }

            return valorDoImposto;
        }
    }
}
