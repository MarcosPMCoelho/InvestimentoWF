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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Api.Corretora apiCorretora = new Api.Corretora();
            var corretoras = apiCorretora.GetCorretoras();
            cmbCorretora.DataSource = corretoras;
            cmbCorretora.ValueMember = "id";
            cmbCorretora.DisplayMember = "nome";
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Api.Seguranca apiSeguranca = new Api.Seguranca();
                Model.Seguranca seguranca = new Model.Seguranca
                {
                    usuario = txtUsuario.Text,
                    senha = txtSenha.Text
                };
                var token = await apiSeguranca.GetToken(seguranca);

                Business.Variaveis variaveis = Business.Variaveis.Instance;
                variaveis.Token = token.token;
                variaveis.CorretoraId = (int)cmbCorretora.SelectedValue;
                variaveis.CorretoraNome = cmbCorretora.Text;
                variaveis.Usuario = txtUsuario.Text;

                MDIParent mdiParent = new MDIParent();
                this.Hide();
                mdiParent.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
