using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Decorator
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }
        public Imposto()
        {
            OutroImposto = null;
        }
        public abstract double Calcula(Orcamento orcamento);

        protected double CalculaOutroImposto(Orcamento orcamento)
        {
           return (OutroImposto == null ? 0 : OutroImposto.Calcula(orcamento));
        }
    }
}
