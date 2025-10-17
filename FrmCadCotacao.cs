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
    public partial class FrmCadCotacao : Form
    {
        private string Id;
        private string Papel;
        private string Valor;
        private string Data;

        public FrmCadCotacao()
        {
            InitializeComponent();
        }

        public void Carregar(string id, string papel, string valor, string data)
        {
            Id = id;
            Papel = papel;
            Valor = valor;
            Data = data;
        }

        private void FrmCadCotacao_Load(object sender, EventArgs e)
        {
            txtId.Text = Id;
            txtPapel.Text = Papel;
            txtValor.Text = Valor;
            txtData.Text = Data;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Api.Cotacao cotacao = new Api.Cotacao();

            if (txtId.Text.Trim() == "")
            {
                
                cotacao.Incluir(new Model.Cotacao()
                {
                    papel = txtPapel.Text.Trim(),
                    valor = Convert.ToDecimal(txtValor.Text.Trim()),
                    data = Convert.ToDateTime(txtData.Text.Trim())
                });
            }
            else
            {
                cotacao.Atualizar(new Model.Cotacao()
                {
                    id = Convert.ToInt32(txtId.Text.Trim()),
                    papel = txtPapel.Text.Trim(),
                    valor = Convert.ToDecimal(txtValor.Text.Trim()),
                    data = Convert.ToDateTime(txtData.Text.Trim())
                });
            }

            this.Close();
        }
    }
}
