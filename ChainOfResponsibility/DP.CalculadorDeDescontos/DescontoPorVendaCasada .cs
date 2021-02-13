using System;
using System.Collections.Generic;
using System.Text;

namespace DP.CalculadorDeDescontos
{
    class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (AconteceuVendaCasada(orcamento)) return orcamento.Valor * 0.05;

            return Proximo.Desconta(orcamento);
        }

        private bool AconteceuVendaCasada(Orcamento orcamento)
        {
            return existe("LAPIS", orcamento) && existe("CANETA", orcamento);
        }

        private bool existe(string nomeDoItem, Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem)) return true;
            }

            return false;
        }
    }
}
