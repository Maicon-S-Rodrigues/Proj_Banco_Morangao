﻿using System;
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
        public bool Gerencia { get; set; }
        public Agencia Agencia { get; set; }

        public Funcionario (String nome, int matricula, bool gerencia, Agencia agencia)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.Gerencia = gerencia;
            this.Agencia = agencia;
        }

        public void VerificarTipoDeConta ()
        {

        }
        public void AprovarCadastroCliente()
        {

        }

        public String MostrarDadosDoFuncionario ()
        {
            return "\nNome: " + Nome + "\nAgencia: " + Agencia + "\nNº Matrícula: " + Matricula;
        }
    }
}
