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

        public Endereco ()
        {

        }
        public Endereco (String rua, int numero, String cidade)
        {
            this.Rua = rua;
            this.Numero = numero;
            this.Cidade = cidade;
        }

        public String MostrarEndereco ()
        {
            return "\n\t\tCidade: " + this.Cidade + "\n\t\tRua: " + this.Rua + ", " + "Número: " + this.Numero;
        }

        //public string getData () // metodo para gravar no arquivo de texto
        //{
        //    return this.Rua + ";" + this.Cidade + ";" + this.Numero + ";";
        //}
    }
}
