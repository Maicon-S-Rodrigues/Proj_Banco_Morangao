using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Banco_Morangao
{
    internal class Gerente : Funcionario
    {
        public Gerente (String nome, int matricula, bool gerencia, Agencia agencia) : base (nome, matricula, gerencia, agencia)
        {
            this.Gerencia = gerencia;
        }

        public String MostrarDadosGerente ()
        {
            return base.MostrarDadosDoFuncionario() + "\nCapacidades Administrativas como Gerente estão ativas para este Funcionário.";
        }

        public void CadastrarFuncionario()
        {

        }

        public void CadastrarAgencia()
        {

        }

        public bool AprovarEmprestimo ()
        {
            return false;
        }
    }
}
