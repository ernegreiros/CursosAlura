namespace ChainOfResponsibility.Descontos
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        public IDesconto ProximoDesconto { get; set;}
    }
}
