using System;
using System.Collections.Generic;
using System.Text;

namespace DP.RequisicoesWeb
{
    public class Requisicao
    {
        public EnumFormato Formato { get; private set; }

        public Requisicao(EnumFormato formato)
        {
            this.Formato = formato;
                
        }
    }
}
