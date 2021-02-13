using System;
using System.Collections.Generic;
using System.Text;

namespace DP.CalculadorDeDescontos
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens;
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
