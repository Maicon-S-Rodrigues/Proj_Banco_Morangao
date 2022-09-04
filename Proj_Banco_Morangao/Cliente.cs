using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Banco_Morangao
{
    internal class Cliente
    {
        public String NomeCliente { get; set; }
        public String CpfCliente { get; set; }
        public DateTime DataNascimentoCliente { get; set; }
        public String TelefoneCliente { get; set; }
        public Endereco EnderecoCliente { get; set; }
        public Agencia AgenciaCliente { get; set; }
        public ContaCorrente ContaCorrente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public double FaixaSalarialCliente { get; set; }
        public int TipoDeConta { get; set; }
        public int NumeroDaConta { get; set; }

        public Cliente (int numeroDaConta, String nome, String cpf, DateTime dataNascimento, String telefone, Endereco endereco, double faixaSalarial, int tipoDeConta)
        {
            this.NomeCliente = nome;
            this.NumeroDaConta = numeroDaConta;
            this.CpfCliente = cpf;
            this.DataNascimentoCliente = dataNascimento;
            this.TelefoneCliente = telefone;
            this.EnderecoCliente = endereco;
            this.FaixaSalarialCliente = faixaSalarial;
            this.TipoDeConta = tipoDeConta;
        }

        public void SolicitarAbertura ()
        {

        }

        public void DesbloquearCartao ()
        {

        }
    }
}
