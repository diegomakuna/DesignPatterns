using DP.State;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(500);

            Console.WriteLine(orcamento.Valor);
            
            orcamento.AplicaDescontoExtra(orcamento);
            Console.WriteLine(orcamento.Valor);

            orcamento.Aprova();

            orcamento.AplicaDescontoExtra(orcamento);
            Console.WriteLine(orcamento.Valor);

            orcamento.Finaliza();

            Console.ReadKey();

        }
    }
}
