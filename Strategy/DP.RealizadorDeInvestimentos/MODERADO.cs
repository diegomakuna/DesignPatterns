using System;
using System.Collections.Generic;
using System.Text;

namespace DP.RealizadorDeInvestimentos
{
    public class MODERADO : IInvestimento
    {
        private Random random;

        public MODERADO()
        {
            this.random = new Random();
        }

        public double AplicarInvestimeto(Conta conta)
        {
            if (random.Next(2) == 0) return conta.Saldo * 0.025;
            else return conta.Saldo * 0.007;

        }
    }
}
