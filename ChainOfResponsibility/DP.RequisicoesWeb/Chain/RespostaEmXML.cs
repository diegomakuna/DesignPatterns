using System;
using System.Collections.Generic;
using System.Text;

namespace DP.RequisicoesWeb.Chain
{
    public class RespostaEmXML : IResposta
    {
        public IResposta OutraResposta { get;  set; }

        public RespostaEmXML()
        {
                
        }
        public RespostaEmXML(IResposta outraResposta)
        {
             this.OutraResposta = outraResposta;
        }
        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato.Equals(EnumFormato.XML))
            {
                Console.WriteLine($"XML: <conta><titular>{conta.Titular}</titular><saldo>{conta.Saldo}</saldo></conta>");
                return;
            }

            OutraResposta.Responde(req, conta);


        }
    }
}
