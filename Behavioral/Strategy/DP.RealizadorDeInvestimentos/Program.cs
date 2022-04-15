using System;

namespace DP.RealizadorDeInvestimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta contaC = new Conta(100.0);
            Conta contaM = new Conta(100.0);
            Conta contaA = new Conta(100.0);
            
            IInvestimento conservador = new CONSERVADOR();
            IInvestimento moderado = new MODERADO();
            IInvestimento arrojado = new ARROJADO();

            RealizadorDeInvestimentos RI = new RealizadorDeInvestimentos();

            Console.WriteLine($"Saldo da conta C:{ contaC.Saldo} ");
            RI.Realiza(contaC, conservador);
            Console.WriteLine($"Saldo da conta C com investimento:{ contaC.Saldo.ToString("C")} ");

            Console.WriteLine('\n');

            Console.WriteLine($"Saldo da conta M:{ contaM.Saldo} ");
            RI.Realiza(contaM, moderado);
            Console.WriteLine($"Saldo da conta M com investimento:{ contaM.Saldo} ");

            Console.WriteLine('\n');

            Console.WriteLine($"Saldo da conta A:{ contaA.Saldo} ");
            RI.Realiza(contaA, arrojado);
            Console.WriteLine($"Saldo da conta A com investimento:{ contaA.Saldo} ");

            Console.ReadKey();


        }
    }
}
