using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
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
