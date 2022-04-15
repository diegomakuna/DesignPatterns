using System;
using System.Collections.Generic;
using System.Text;

namespace DP.RequisicoesWeb
{
    public class Conta
    {
        public String Titular { get; private set; }
        public double Saldo { get; set; }

        public Conta(string titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}
