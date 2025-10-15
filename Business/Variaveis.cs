using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestWF.Business
{
    public sealed class Variaveis
    {
        private static readonly Lazy<Variaveis> lazy = new Lazy<Variaveis>(() => new Variaveis());
        public static Variaveis Instance { get { return lazy.Value; } }
        private Variaveis()
        {
        }
        public string Token { get; set; }
        public int CorretoraId { get; set; }
        public string CorretoraNome { get; set; }
        public string Usuario { get; internal set; }
    }
}
