﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DP.TM.Relatorios
{
    public class RelatorioSimples : TemplateRelatorios
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Saldo);
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine("(11) 1234-5678");
        }
    
    }
}
