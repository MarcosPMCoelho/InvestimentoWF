using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestWF.Model
{
    internal class Fechamento
    {
        public DateTime dataFechamento { get; set; }
        public decimal total_Aplicado { get; set; }
        public decimal fechamento { get; set; }
        public decimal saldo_Fundo { get; set; }
        public decimal saldo_Prev { get; set; }
        public decimal saldo_CC { get; set; }
    }
}
