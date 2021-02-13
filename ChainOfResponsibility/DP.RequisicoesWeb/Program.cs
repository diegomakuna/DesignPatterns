using DP.RequisicoesWeb.Chain;
using System;

namespace DP.RequisicoesWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta("Diego", 700.0);
            var requisicao = new Requisicao(EnumFormato.CSV);


            IResposta rq1 = new RespostaEmCsv();
            IResposta rq2 = new RespostaEmXML();
            IResposta rq3 = new RespostaEmPorcento();




            rq1.OutraResposta = rq2;
            rq2.OutraResposta = rq3;
            rq3.OutraResposta = null;

            rq1.Responde(requisicao, conta);

            Console.ReadLine();

        }
    }
}
