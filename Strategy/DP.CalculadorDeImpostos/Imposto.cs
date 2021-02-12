using System;
using System.Collections.Generic;
using System.Text;

namespace DP.CalculadorDeImpostos
{
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
    }
}
