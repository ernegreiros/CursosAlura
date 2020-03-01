namespace ChainOfResponsibility.Descontos
{
    public class DescontoValorMaiorQueQuinhentoscs : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }
            else
            {
                return ProximoDesconto.Desconta(orcamento);
            }
        }
    }
}
