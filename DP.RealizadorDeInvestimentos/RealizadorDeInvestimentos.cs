using System;
using System.Collections.Generic;
using System.Text;

namespace DP.RealizadorDeInvestimentos
{
    public class RealizadorDeInvestimentos
    {
        public void Realiza(Conta conta, IInvestimento investimento)
        {
            double resultado = investimento.AplicarInvestimeto(conta);
            conta.Deposita(resultado * 0.75);
            
        }
    }
}
