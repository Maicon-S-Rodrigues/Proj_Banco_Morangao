using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Banco_Morangao
{
    internal class Funcionario
    {
        public String Nome { get; set; }
        public int Matricula { get; set; }
        public bool Gerente { get; set; }
        public Agencia Agencia { get; set; }

        public Funcionario (string nome, int matricula, bool gerente, Agencia agencia)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.Gerente = gerente;
            this.Agencia = agencia;
        }

        public void VerificarTipoDeConta ()
        {

        }
        public void AprovarCadastroCliente()
        {

        }
    }
}
