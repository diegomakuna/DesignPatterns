﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DP.TM.Relatorios
{
    public class RelatorioComplexo : TemplateRelatorios
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
            Console.WriteLine("Avenida Paulista, 1234");
            Console.WriteLine("(11) 1234-5678");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Numero + " - " + c.Agencia + " - " + c.Saldo);
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine("banco@xyz.com.br");
            Console.WriteLine(DateTime.Now);
        }
    }
}
