﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.RequisicaoBancaria
{
    public interface IFormato
    {
        public void Formatar(Conta conta, Requisicao requisicao);
    }
}
