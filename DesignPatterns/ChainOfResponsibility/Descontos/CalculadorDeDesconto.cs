using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Descontos
{
    public class CalculadorDeDesconto
    {
        public double CalculaDesconto(Orcamento orcamento)
        {
            DescontoMaisDeCincoItens descCincoItens = new DescontoMaisDeCincoItens();
            DescontoValorMaiorQueQuinhentoscs descQuinhentos = new DescontoValorMaiorQueQuinhentoscs();
            SemDesconto semDesconto = new SemDesconto();

            descCincoItens.ProximoDesconto = descQuinhentos;
            descQuinhentos.ProximoDesconto = semDesconto;

            return descCincoItens.Desconta(orcamento);
        }
    }
}
