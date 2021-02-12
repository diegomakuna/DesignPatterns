using System;
using System.Collections.Generic;
using System.Text;

namespace DP.CalculadorDeImpostos
{
    public class CalculadorDeImpostos
    {
        public double RealizaCalculo(Orcamento orcamento, Imposto imposto )
        {
            return imposto.Calcula(orcamento);
            
        }
    }
}
