using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestWF.Model
{
    internal class Extrato
    {
        public DateTime data { get; set; }
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public string tipo { get; set; }
        public decimal saldoAtual { get; set; }
    }
}
