using System;
using System.Collections.Generic;
using System.Text;

namespace DP.RequisicoesWeb.Chain
{
    public class RespostaEmCsv : IResposta
    {
        public IResposta OutraResposta { get;  set; }

        public RespostaEmCsv()
        {
                
        }
        public RespostaEmCsv(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato.Equals(EnumFormato.CSV))
            {
                Console.WriteLine($"CSV: {conta.Titular};{conta.Saldo}");
                return;
            }

            OutraResposta.Responde(req, conta);
        }
    }
}
