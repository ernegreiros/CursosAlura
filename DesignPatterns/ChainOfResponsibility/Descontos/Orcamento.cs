using System.Collections.Generic;

namespace ChainOfResponsibility.Descontos
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public List<Item> Itens { get; set; }
        public Orcamento()
        {
            this.Valor = 0.0;
            this.Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            this.Itens.Add(item);
            this.Valor += item.Valor;
        }
    }
}
