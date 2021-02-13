using System;
using System.Collections.Generic;
using System.Text;

namespace DP.RequisicoesWeb.Chain
{
    public class RespostaEmPorcento : IResposta
    {
        public IResposta OutraResposta { get;  set; }

        public RespostaEmPorcento(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

    
        public RespostaEmPorcento()
        {
            this.OutraResposta = null;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato.Equals(EnumFormato.PORCENTO))
            {
                Console.WriteLine($"PORCENTO: {conta.Titular} % {conta.Saldo}");
                return;
            }
            
            if(OutraResposta != null)
                OutraResposta.Responde(req, conta);
            else
                throw new Exception("Formato de resposta não encontrado");
        }
    }
}
