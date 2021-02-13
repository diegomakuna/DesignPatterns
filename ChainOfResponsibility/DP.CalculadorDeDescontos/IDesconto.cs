using System;
using System.Collections.Generic;
using System.Text;

namespace DP.CalculadorDeDescontos
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
