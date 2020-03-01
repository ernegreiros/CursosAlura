using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.RequisicaoBancaria
{
    public class FormatoXML : IFormato
    {
        public IFormato ProximoFormato { get; set; }

        public void Formatar(Conta conta, Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.XML)
            {
                Console.WriteLine("<CONTA>\n" + "<TITULAR>" + conta.Titular + "</TITULAR>\n" + "<SALDO>" + conta.Saldo + "</SALDO>\n</CONTA>");
            }
            else
            {
                ProximoFormato.Formatar(conta, requisicao);
            }
        }
    }
}
