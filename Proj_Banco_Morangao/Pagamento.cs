using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Banco_Morangao
{
    internal class Pagamento
    {
        public DateTime DataTransacoes { get; set; }
        public string TipoDaOperação { get; set; }
        public double Valor { get; set; }

        //public List<Pagamento> Extrato { get; set; } ///para guardar as movimentações em lista e imprimir todas de uma vez
        public Pagamento ()
        {

        }

        public Pagamento (DateTime dataTransacoes, string tipoDaOperação, double valor)
        {
            DataTransacoes = dataTransacoes;
            TipoDaOperação = tipoDaOperação;
            Valor = valor;
        }
    }
}
