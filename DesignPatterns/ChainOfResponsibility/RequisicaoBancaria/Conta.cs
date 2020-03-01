using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.RequisicaoBancaria
{
    public class Conta
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(string titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}
