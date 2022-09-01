using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Banco_Morangao
{
    internal class ContaCorrente
    {
        public int NumeroDaConta { get; set; } //id da conta
        public bool CartaoDeCredito { get; set; }
        public int NumeroDoCartao { get; set; }
        public double SaldoEmConta { get; set; }
        public double SaldoChequeEspecial { get; set; } // saldo de limite especial
        public String ExtratoDeMovimentacaoDaConta { get; set; }
        public ContaPoupanca contaPoupanca { get; set; }
        public Cartao CartaoCredito { get; set; }


        public ContaCorrente (int numeroDaConta, bool cartaoDeCredito, int numeroDoCartao, double saldoEmConta, double saldoChequeEspecial)
        {
            this.NumeroDaConta = numeroDaConta;
            this.CartaoDeCredito = cartaoDeCredito;
            this.NumeroDoCartao = numeroDoCartao;
            this.SaldoEmConta = saldoEmConta;
            this.SaldoChequeEspecial = saldoChequeEspecial;
        }

        public String MostrarSaldoCorrente ()
        {
            return "\nSaldo atual em Conta Corrente:    R$: " + this.SaldoEmConta;
        }

        public void Sacar ()
        {

        }

        public void Depositar ()
        {

        }

        public void SolicitarEmprestimo ()
        {

        }

        public void TransferirValor ()
        {

        }


        ///no desenho está faltando essa parte de extrato para registros de movimentação da conta corrente
        public String VerExtrato()
        {
            return ""; ///chamar extrato para mostrar na tela
        }

        public void FazerPagamento ()
        {

        }

        public  void RegistrarTransacao () ///gerar extrato
        {

        }

        public bool VerificarSaldoDevedor ()
        {
            return false; ///mudar depois
        }


    }
}
