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
    public partial class FrmExtrato : Form
    {
        public FrmExtrato()
        {
            InitializeComponent();
        }

        private void FrmExtrato_Load(object sender, EventArgs e)
        {
            CarregarQtdDias();
        }

        private void CarregarQtdDias()
        {
            cmbQtdDias.Items.Clear();
            cmbQtdDias.Items.Add("7");
            cmbQtdDias.Items.Add("30");
            cmbQtdDias.Items.Add("90");
            cmbQtdDias.Items.Add("180");
            cmbQtdDias.Items.Add("360");
            cmbQtdDias.Items.Add("720");
            cmbQtdDias.Items.Add("1080");
            cmbQtdDias.Items.Add("1440");
            cmbQtdDias.Items.Add("1880");
        }

        private void cmbQtdDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int qtd = Convert.ToInt32(cmbQtdDias.SelectedItem.ToString());
            Api.Extrato extrato = new Api.Extrato();
            List<Model.Extrato> lextrato = extrato.GetDays(qtd);
            dgExtrato.DataSource = lextrato;
        }

        private void FrmExtrato_Resize(object sender, EventArgs e)
        {
            dgExtrato.Top = 80;
            dgExtrato.Height = this.Height - 140;
        }
    }
}
