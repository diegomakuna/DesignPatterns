using System;
using System.Collections.Generic;
using System.Text;

namespace DP.RealizadorDeInvestimentos
{
    public class ARROJADO : IInvestimento
    {
        private Random random;
        public ARROJADO()
        {
            random = new Random();
        }
        public double AplicarInvestimeto(Conta conta)
        {
            var chances = random.Next(10);

            if (chances >= 0 && chances <= 1) return conta.Saldo * 0.004;
            else if (chances >= 2 && chances <= 4) return conta.Saldo * 0.003;
            else return conta.Saldo * 0.006;


        }
    }
}
