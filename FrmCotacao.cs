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
    public partial class FrmCotacao : Form
    {

        internal int rowCotacao;

        public FrmCotacao()
        {
            InitializeComponent();
        }

        private void FrmCotacao_Load(object sender, EventArgs e)
        {
            Api.Cotacao cotacao = new Api.Cotacao();
            dgCotacao.DataSource= cotacao.GetCotacao();
            Atualizar();


        }

        private void btnAtualizaOnline_Click(object sender, EventArgs e)
        {
            Api.CotacaoOnline cotacaoOnline = new Api.CotacaoOnline();
            var listaCotacao = cotacaoOnline.GetCotacao();
            dgCotacao.DataSource = listaCotacao;

            Atualizar();

            MessageBox.Show("Cotações atualizadas com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Atualizar()
        {
           
            Api.Cotacao cotacao = new Api.Cotacao();
            var listaPendente = cotacao.GetPendente();
            dgPendente.DataSource = listaPendente;

            var dataAtualizacao = cotacao.GetAtualizacao();
            lblAtualizacao.Text = "Última atualização: " + dataAtualizacao.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadCotacao frmCadCotacao = new FrmCadCotacao();
            frmCadCotacao.ShowDialog();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgCotacao.Rows[rowCotacao];
            string id = row.Cells["Id"].Value.ToString();
            string papel = row.Cells["Papel"].Value.ToString();
            string valor = row.Cells["Valor"].Value.ToString();
            string data = row.Cells["Data"].Value.ToString();
            FrmCadCotacao frmCadCotacao = new FrmCadCotacao();
            frmCadCotacao.Carregar(id, papel, valor, data); 
            frmCadCotacao.ShowDialog();
                           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão da cotação?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow row = dgCotacao.Rows[rowCotacao];
                string id = row.Cells["Id"].Value.ToString();
                Api.Cotacao cotacao = new Api.Cotacao();
                cotacao.Excluir(id);
                FrmCotacao_Load(sender, e);
            }
        }

        private void dgCotacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgCotacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                rowCotacao = e.RowIndex;
            }
        }
    }
}
