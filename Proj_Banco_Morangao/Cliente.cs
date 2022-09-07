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
        public double FaixaSalarialCliente { get; set; }
        public int TipoDeConta { get; set; }  /// 1 - Universitaria, 2 - Comum, 3 - VIP
        public int NumeroDaConta { get; set; }     
        public bool Acesso { get; set; }

        public Cliente (int numeroDaConta, Agencia agenciaCadastrada, String nome, String cpf, DateTime dataNascimento, String telefone, Endereco endereco, double faixaSalarial, int tipoDeConta)
        {
            this.AgenciaCliente = agenciaCadastrada;
            this.NomeCliente = nome;
            this.NumeroDaConta = numeroDaConta;
            this.CpfCliente = cpf;
            this.DataNascimentoCliente = dataNascimento;
            this.TelefoneCliente = telefone;
            this.EnderecoCliente = endereco;
            this.FaixaSalarialCliente = faixaSalarial;
            this.TipoDeConta = tipoDeConta;
            this.Acesso = false; ///sera mudado para true quando o funcionario aprovar cadastro
        }
        public void LiberarAcesso()
        {
            this.Acesso = true;
            this.ContaCorrente = new ContaCorrente(this.NumeroDaConta, this.AgenciaCliente, 0);
        }
        public bool VerificarAcesso()
        {
            if (this.Acesso == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string VerTipoDeConta()
        {
            if (this.TipoDeConta == 1)
            {
                return "Conta Universitária.";
            }
            else if (this.TipoDeConta == 2)
            {
                return "Conta Comum.";
            }
            else
            {
                return "Conta VIP.";
            }
        }
        public string MostrarPedidoDeAbertura()
        {
            return "\n\t\tDados do Cliente:\n" +
                   "\n\t\tNome: " + this.NomeCliente +
                   "\n\t\tCPF: " + this.CpfCliente +
                   "\n\t\tData de Nascimento: " + DataNascimentoCliente.ToShortDateString() +
                   "\n\t\tTelefone: " + this.TelefoneCliente +
                   "\n\t\tEndereço: " + this.EnderecoCliente.MostrarEndereco() +
                   "\n\n\t\tAgência ao qual a Conta foi Solicitada abertura: " + this.AgenciaCliente.NumeroId +
                   "\n\t\tFaixa Salarial informada pelo Cliente: " + this.FaixaSalarialCliente +
                   "\n\t\tNúmero de ID cadastrado pelo Cliente que solicita abertura: " + this.NumeroDaConta;
        }
    }
}
