using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Banco_Morangao
{
    internal class Gerente : Funcionario
    {
        public Gerente (String nome, int matricula, Agencia agencia) : base (nome, matricula, agencia)
        {
            
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
        
        public void VerFuncionariosCadastrados ()
        {

        }

        public void VerAgenciasCadastradas()
        {

        }

        public void VerClientesCadastrados()
        {

        }
        public bool AprovarEmprestimo ()
        {
            return false;
        }
    }
}
