using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Decorator
{
    public class Conta
    {
        public String Nome { get; private set; }
        public double Saldo { get; private set; }
        public int Numero { get; private set; }
        public int Agencia { get; private set; }

        public DateTime DataAbertura { get; private set; }

        public Conta(string nome, double saldo, int numero, int agencia)
        {
            this.Nome = nome;
            this.Saldo = saldo;
            Numero = numero;
            Agencia = agencia;
        }
    }
}
