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
            return base.MostrarDadosDoFuncionario() + "\n\t\tCapacidades Administrativas como Gerente estão ativas para este Funcionário.";
        }  
    }
}
