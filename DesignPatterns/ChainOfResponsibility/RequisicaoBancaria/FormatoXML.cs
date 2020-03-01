using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.RequisicaoBancaria
{
    public class FormatoXML : IFormato
    {
        public IFormato ProximoFormato { get; private set; }

        public FormatoXML(IFormato proximoFormato)
        {
            this.ProximoFormato = proximoFormato;
        }

        public void Formatar(Conta conta, Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.XML)
            {
                Console.WriteLine("<CONTA>\n" + "<TITULAR>" + conta.Titular + "</TITULAR>\n" + "<SALDO>" + conta.Saldo + "</SALDO>\n</CONTA>");
            }
            else
            {
                try
                {
                    ProximoFormato.Formatar(conta, requisicao);
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
