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
        public FrmCotacao()
        {
            InitializeComponent();
        }

        private void FrmCotacao_Load(object sender, EventArgs e)
        {
            Api.Cotacao cotacao = new Api.Cotacao();
            var listaCotacao = cotacao.GetCotacao();
            dgCotacao.DataSource = listaCotacao;

            var listaPendente = cotacao.GetPendente();
            dgPendente.DataSource = listaPendente;
        }

        private void btnAtualizaOnline_Click(object sender, EventArgs e)
        {
            Api.CotacaoOnline cotacaoOnline = new Api.CotacaoOnline();
            var listaCotacao = cotacaoOnline.GetCotacao();
            dgCotacao.DataSource = listaCotacao;

            Api.Cotacao cotacao = new Api.Cotacao();
            var listaPendente = cotacao.GetPendente();
            dgPendente.DataSource = listaPendente;

            MessageBox.Show("Cotações atualizadas com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadCotacao frmCadCotacao = new FrmCadCotacao();
            frmCadCotacao.ShowDialog();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmCadCotacao frmCadCotacao = new FrmCadCotacao();
            frmCadCotacao.ShowDialog();
            
               
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
