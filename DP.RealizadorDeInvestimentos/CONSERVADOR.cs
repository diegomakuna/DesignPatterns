using System;
using System.Collections.Generic;
using System.Text;

namespace DP.RealizadorDeInvestimentos
{
    public class CONSERVADOR : IInvestimento
    {
       

        public double AplicarInvestimeto(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
