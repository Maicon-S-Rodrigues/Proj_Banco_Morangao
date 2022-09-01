using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Banco_Morangao
{
    internal class Agencia
    {
        public int NumeroId { get; set; }
        public Endereco Endereco { get; set; }

        public Agencia (int numeroId, Endereco endereco)

        {
            this.NumeroId = numeroId;
            this.Endereco = endereco;
        }

        public string MostrarAgenciaCadastrada()
        {
            return "\n\t\tAgencia id: " + this.NumeroId + "\n\t\tEndereço da Agência: " + Endereco.MostrarEndereco(); 
        }
    }
}
