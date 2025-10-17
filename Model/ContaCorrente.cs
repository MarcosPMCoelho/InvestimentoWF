using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InvestWF.Model
{
    internal class ContaCorrente
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public string tipo { get; set; }
        public decimal saldo_atual { get; set; }
        public int id_desdobra { get; set; }
        public int corretora { get; set; }
    }
}
