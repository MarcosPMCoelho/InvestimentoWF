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
    public partial class FrmContaCorrente : Form
    {

        int rowConta;
        public FrmContaCorrente()
        {
            InitializeComponent();
        }

        private void FrmContaCorrente_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        private void Carregar()
        {
            Api.ContaCorrente contaCorrente = new Api.ContaCorrente();
            var saldo = contaCorrente.GetContaCorrenteSaldo();
            lblSaldo.Text = "Saldo: " + saldo.ToString("C2");

            dgSaldo.DataSource = contaCorrente.GetContaCorrente();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmCadContaCorrente frmCadContaCorrente = new FrmCadContaCorrente();
            frmCadContaCorrente.ShowDialog();
            Carregar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgSaldo.Rows[rowConta];
            string id = row.Cells["id"].Value.ToString();
            string data = row.Cells["data"].Value.ToString();
            string descricao = row.Cells["descricao"].Value.ToString();
            string valor = row.Cells["valor"].Value.ToString();
            string tipo = row.Cells["tipo"].Value.ToString();
            
            FrmCadContaCorrente frmCadContaCorrente = new FrmCadContaCorrente();
            frmCadContaCorrente.Carregar(id, data, descricao, valor, tipo);
            frmCadContaCorrente.ShowDialog();
            Carregar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void dgSaldo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowConta = e.RowIndex;
            }
        }

        //TODO: Implementar funcionalidades de adicionar, editar e excluir transações na conta corrente
    }
}
