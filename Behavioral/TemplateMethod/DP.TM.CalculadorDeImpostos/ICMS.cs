using System;
using System.Collections.Generic;
using System.Text;

namespace DP.TM.CalculadorDeImpostos
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + 50;
        }
    }
}
