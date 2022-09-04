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
        public Agencia Agencia { get; set; }

        //public bool CartaoDeCredito { get; set; }
        //public int NumeroDoCartao { get; set; }
        public double SaldoEmConta { get; set; }
        public double ChequeEspecial { get; set; } // saldo de limite especial
        public Pagamento Registro { get; set; }
        //public ContaPoupanca contaPoupanca { get; set; }
        //public Cartao CartaoCredito { get; set; }

        public ContaCorrente()
        {

        }

        public ContaCorrente(int id)
        {

        }

        public ContaCorrente(int id, Agencia agencia)
        {

        }

        public ContaCorrente (int numeroDaConta,/*, bool cartaoDeCreditoint numeroDoCartao, */ Agencia agencia, double saldoEmConta, double chequeEspecial)
        {
            this.NumeroDaConta = numeroDaConta;
            this.Agencia = agencia;
            //this.CartaoDeCredito = cartaoDeCredito;
            //this.NumeroDoCartao = numeroDoCartao;
            this.SaldoEmConta = saldoEmConta;
            this.ChequeEspecial = chequeEspecial;
        }

        public String VerSaldo ()
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
