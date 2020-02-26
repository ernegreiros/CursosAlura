using System;

namespace Strategy_Imposto
{
    public class CalculadorDeImposto
    {
        public void CalcularImposto(Orcamento orcamento, IImposto impostoEscolhido)
        {
            var valorDoImposto = impostoEscolhido.Calcula(orcamento);
            Console.WriteLine("Valor do Imposto: " + valorDoImposto);
        }
    }
}
