using DP.TM.CalculadorDeImpostos;
using System;

namespace DP.CalculadorDeImpostos
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto Iss = new ISS();
            Imposto ICMS = new ICMS();
            
            Imposto ICCC = new ICCC();

            Orcamento orcamento = new Orcamento(500.0);
            var calculador = new DP.TM.CalculadorDeImpostos.CalculadorDeImpostos();

            //calculando o ISS
            var orcamentoIss = calculador.RealizaCalculo(orcamento, Iss);

            //calculando o ICMS
            var orcamentoIcms = calculador.RealizaCalculo(orcamento, ICMS);

            var iccc500 = calculador.RealizaCalculo(new Orcamento(500.0), ICCC);

            var iccc1500 = calculador.RealizaCalculo(new Orcamento(1500.0), ICCC);
            var iccc4500 = calculador.RealizaCalculo(new Orcamento(4500.0), ICCC);


            Console.WriteLine(orcamentoIss);
            Console.WriteLine(orcamentoIcms);

            Console.WriteLine(iccc500);
            Console.WriteLine(iccc1500);
            Console.WriteLine(iccc4500);

            Console.ReadKey();
        }
    }
}
