using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.RequisicaoBancaria
{
    public class FormatoCSV : IFormato
    {
        public IFormato ProximoFormato { get; private set; }

        public FormatoCSV(IFormato proximoFormato)
        {
            this.ProximoFormato = proximoFormato;
        }

        public void Formatar(Conta conta, Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + "," + conta.Saldo);
            }
            else
            {
                try
                {
                    ProximoFormato.Formatar(conta, requisicao);
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Formato Invalido");
                }
            }
        }
    }
}
