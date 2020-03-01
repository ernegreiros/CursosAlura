using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.RequisicaoBancaria
{
    public class FormatoCSV : IFormato
    {
        public IFormato ProximoFormato { get; set; }

        public void Formatar(Conta conta, Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + "," + conta.Saldo);
            }
            else
            {
                ProximoFormato.Formatar(conta, requisicao);
            }
        }
    }
}
