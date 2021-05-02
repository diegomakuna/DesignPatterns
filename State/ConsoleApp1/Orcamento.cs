using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.State
{
    public class Orcamento
    {
        public EstadoDeUmOrcamento EstadoAtual { get; set; }
        public double Valor { get;  set; }
        public IList<Item> Itens;
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }
        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }
    }
}
