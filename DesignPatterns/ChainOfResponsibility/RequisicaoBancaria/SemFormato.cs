using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.RequisicaoBancaria
{
    public class SemFormato : IFormato
    {
        public IFormato ProximoFormato { get; set; }

        public void Formatar(Conta conta, Requisicao requisicao)
        {
            Console.WriteLine(conta.Titular);
            Console.WriteLine(conta.Saldo);
        }
    }
}
