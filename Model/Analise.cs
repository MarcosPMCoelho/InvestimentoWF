using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestWF.Model
{
    internal class Analise
    {
        public string possibilidade { get; set; }
        public string papel { get; set; }
        public int quantidade { get; set; }
        public decimal vl_unit { get; set; }
        public decimal valor_cotacao { get; set; }
        public decimal pm { get; set; }
        public DateTime dataOperacao { get; set; }
        public DateTime minimoVenda { get; set; }
        public DateTime dataCotacao { get; set; }
    }
}
