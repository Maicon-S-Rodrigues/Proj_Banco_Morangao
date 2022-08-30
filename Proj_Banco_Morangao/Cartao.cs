using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Banco_Morangao
{
    internal class Cartao
    {
        public double Credito { get; set; }
        public int VencimentoFatura { get; set; }

        public Cartao (double credito, int vencimentoFatura)

        {
            Credito = credito;
            VencimentoFatura = vencimentoFatura;
        }
    }
}
