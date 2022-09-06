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
        public double SaldoEmConta { get; set; }
        public List<Pagamento> Registro { get; set; }


        public ContaCorrente()
        {

        }
        public ContaCorrente (int numeroDaConta,/*, bool cartaoDeCreditoint numeroDoCartao, */ Agencia agencia, double saldoEmConta)
        {
            this.NumeroDaConta = numeroDaConta;
            this.Agencia = agencia;
            //this.CartaoDeCredito = cartaoDeCredito;
            //this.NumeroDoCartao = numeroDoCartao;
            this.SaldoEmConta = saldoEmConta;
            this.Registro = new List<Pagamento> ();
        }

        public String VerSaldo ()
        {
            return "\nSaldo atual em Conta Corrente:    R$: " + this.SaldoEmConta;
        }

        public bool Sacar (double valor)
        {
            if (this.SaldoEmConta < valor)
            {
                return false;
            }
            else
            {
                this.SaldoEmConta -= valor;
                return true;
            }
        }

        public bool Depositar (double valorDeposito)
        {
            if (valorDeposito <= 0)
            {            
                return false;
            }
            else
            {
                this.SaldoEmConta = this.SaldoEmConta + valorDeposito;
                return true;
            }
        }
    
        public String VerExtrato()
        {
            return ""; ///chamar extrato para mostrar na tela
        }
        public  void RegistrarTransacao () ///gerar extrato
        {

        }
    }
}
