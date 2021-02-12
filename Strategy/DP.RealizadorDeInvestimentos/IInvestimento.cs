using System;
using System.Collections.Generic;
using System.Text;

namespace DP.RealizadorDeInvestimentos
{
    public interface IInvestimento
    {
        double AplicarInvestimeto(Conta conta);
    }
}
