using System;
using System.Collections.Generic;
using System.Text;

namespace DP.RealizadorDeInvestimentos
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }
    }
}
