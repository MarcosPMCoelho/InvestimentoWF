using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestWF.Model
{
    internal class Corretora
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataAtualizacao { get; set; }
    }
}
