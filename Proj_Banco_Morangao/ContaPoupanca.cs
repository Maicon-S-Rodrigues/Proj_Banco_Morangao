using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Banco_Morangao
{
    internal class ContaPoupanca : ContaCorrente
    {
        public double SaldoContaPoupanca { get; set; }


        public ContaPoupanca(int numeroDaConta, bool cartaoDeCredito, int numeroDoCartao,
            double saldoEmConta, double saldoChequeEspecial)
            : base(numeroDaConta, cartaoDeCredito, numeroDoCartao, saldoEmConta, saldoChequeEspecial)
        {
            this.SaldoContaPoupanca = 0;
        }

        public void AdicionarRendimento() ///calculo de porcentagem de rendimento mensal na poupança 
        {

        }
    }
}
