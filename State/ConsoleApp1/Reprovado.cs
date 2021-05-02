using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.State
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados nao recebem desconto extra ");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento ja esta em Aprovação ");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento ja esta em Aprovado ");
        }
    }
}
