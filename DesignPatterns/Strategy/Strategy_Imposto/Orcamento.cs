﻿namespace Strategy_Imposto
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public Orcamento(double valor)
        {
            this.Valor = valor;
        }
    }
}