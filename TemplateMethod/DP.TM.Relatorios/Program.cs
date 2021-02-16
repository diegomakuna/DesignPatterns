using System;
using System.Collections.Generic;

namespace DP.TM.Relatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta("diego", 500.0, 4444, 3216578);

            var relatorioSemples = new RelatorioSimples();
            var contas = new List<Conta>();
            contas.Add(conta);
            relatorioSemples.Imprime(contas);

            Console.WriteLine("-----------------------------");

            var relatorioComplexo = new RelatorioComplexo();
            relatorioComplexo.Imprime(contas);

            Console.ReadLine();

        }
    }
}
