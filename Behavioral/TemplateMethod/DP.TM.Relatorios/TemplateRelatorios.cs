using System;
using System.Collections.Generic;
using System.Text;

namespace DP.TM.Relatorios
{
    public abstract class TemplateRelatorios
    {
        protected abstract void Cabecalho();
        protected abstract void Rodape();
        protected abstract void Corpo(IList<Conta> contas);

        public void Imprime(IList<Conta> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();

        }


    }
}
