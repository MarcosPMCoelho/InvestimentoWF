using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestWF.Model
{
    internal class Resultado
    {
        public float dividendoYield { get; set; }
        public string papel { get; set; }
        public int quantidade { get; set; }
        public float vl_total { get; set; }
        public float pm { get; set; }
        public float dividendos { get; set; }
        public int qtd_meses { get; set; }
        public float pm_dividendos { get; set; }
        public float dividendos_unit { get; set; }
        public float valor { get; set; }
        public DateTime data_cotacao { get; set; }
        public float valor_total_atual { get; set; }
        public float resultado_final { get; set; }
        public Cadpapel cadPapel { get; set; }
        public Meta meta { get; set; }
        public float perc_total { get; set; }
    }
}
