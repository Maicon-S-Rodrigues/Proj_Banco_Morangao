using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Banco_Morangao
{
    internal class Endereco
    {
        public String Rua { get; set; }
        public String Cidade { get; set; }
        public int Numero { get; set; }

        public Endereco (String rua, String cidade, int numero)
        {
            this.Rua = rua;
            this.Cidade = cidade;
            this.Numero = numero;
        }
        public Endereco ()
        {
            this.Rua = "";
            this.Cidade = "";
            this.Numero = 0;
        }

        public String MostrarEndereco ()
        {
            return "Cidade: " + this.Cidade + "\nRua: " + this.Rua + "\nNúmero: " + this.Numero;
        }
    }
}
