using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestWF
{
    public partial class FrmResultado : Form
    {
        public FrmResultado()
        {
            InitializeComponent();
        }

        private void FrmResultado_Load(object sender, EventArgs e)
        {
            Api.Resultado resultado = new Api.Resultado();
            var lisResultado = resultado.GetResultado();
            dbResultado.DataSource = lisResultado;
        }
    }
}
