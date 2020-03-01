namespace Strategy.Strategy_Investimento
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }
        public ContaBancaria(double saldo)
        {
            this.Saldo = saldo;
        }

        public void AdicionaSaldo(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }
        }
    }
}
