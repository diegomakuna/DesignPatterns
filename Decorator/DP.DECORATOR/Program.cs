using System;

namespace DP.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ImpostoMuitoAlto(new ICMS());
            Orcamento orcamento = new Orcamento(500);

            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);

            Console.ReadKey();
        }
    }
}
