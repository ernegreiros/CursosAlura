namespace ChainOfResponsibility.Descontos
{
    public class SemDesconto : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
