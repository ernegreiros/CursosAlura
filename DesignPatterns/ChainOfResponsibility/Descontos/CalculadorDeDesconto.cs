using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Descontos
{
    public class CalculadorDeDesconto
    {
        public double CalculaDesconto(Orcamento orcamento)
        {
            DescontoMaisDeCincoItens descontoCincoItens = new DescontoMaisDeCincoItens();
            DescontoValorMaiorQueQuinhentos descontoQuinhentos = new DescontoValorMaiorQueQuinhentos();
            DescontoVendaCasada descontoVendaCasada = new DescontoVendaCasada();
            SemDesconto semDesconto = new SemDesconto();

            descontoCincoItens.ProximoDesconto  = descontoQuinhentos;
            descontoQuinhentos.ProximoDesconto  = descontoVendaCasada;
            descontoVendaCasada.ProximoDesconto = semDesconto;

            return descontoCincoItens.Desconta(orcamento);
        }
    }
}
