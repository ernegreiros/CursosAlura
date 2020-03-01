namespace ChainOfResponsibility.Descontos
{
    public class DescontoVendaCasada : IDesconto
    {
        public IDesconto ProximoDesconto { get ; set ; }

        public double Desconta(Orcamento orcamento)
        {
            if (OrcamentoContemVendaCasada(orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return ProximoDesconto.Desconta(orcamento);
            }
        }

        private bool OrcamentoContemVendaCasada(Orcamento orcamento)
        {
            if (Existe("Lapis", orcamento) && Existe("Caneta", orcamento))
                return true;
            else
                return false;
        }

        private bool Existe(string nomeItem, Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeItem))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
