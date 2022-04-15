using DP.CalculadorDeImpostos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP.TM.CalculadorDeImpostos
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento);
            else
                return MinimaTaxacao(orcamento);
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500; 
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
