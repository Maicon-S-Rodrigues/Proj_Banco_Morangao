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


        public ContaPoupanca(int id, Agencia agencia, double saldoContaPoupanca) : base(id, agencia)
        {
            this.SaldoContaPoupanca = saldoContaPoupanca;
        }

        public void AdicionarRendimento() ///calculo de porcentagem de rendimento mensal na poupança 
        {

        }
    }
}
