using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestWF.Model
{
    internal class Cotacao
    {
        public int id { get; set; }
        public string papel { get; set; }
        public decimal valor { get; set; }
        public DateTime data { get; set; }
        public string status { get; set; }
    }
}
