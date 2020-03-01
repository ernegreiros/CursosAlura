using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.RequisicaoBancaria
{
    public class Requisicao
    {
        public Formato Formato { get; private set;}
        public Requisicao(Formato formato)
        {
            this.Formato = formato;
        }
    }
}
