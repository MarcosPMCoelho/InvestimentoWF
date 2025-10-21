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
    public partial class FrmCadContaCorrente : Form
    {
        Business.Variaveis variaveis = Business.Variaveis.Instance;
        public FrmCadContaCorrente()
        {
            InitializeComponent();
        }

        internal void Carregar(string id, string data, string descricao, string valor, string tipo)
        {
            txtId.Text = id;
            txtData.Text = data;
            txtDescricao.Text = descricao;
            txtValor.Text = valor;
            cmbTipo.SelectedItem = tipo;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string vlValue="";

            Api.ContaCorrente conta = new Api.ContaCorrente();
            if (cmbTipo.SelectedItem is Business.ComboBoxItem selectedItem)
            {
                vlValue = selectedItem.Value.ToString();
            }

            if (txtId.Text.Trim() == "")
            {

                conta.Incluir(new Model.ContaCorrente()
                {
                    data = Convert.ToDateTime(txtData.Text.Trim()),
                    descricao = txtDescricao.Text.Trim(),
                    valor = Convert.ToDecimal(txtValor.Text.Trim()),
                    tipo = vlValue,
                    corretora = variaveis.CorretoraId
                });
            }
            else
            {
                conta.Atualizar(new Model.ContaCorrente()
                {
                    id = Convert.ToInt32(txtId.Text.Trim()),
                    data = Convert.ToDateTime(txtData.Text.Trim()),
                    descricao = txtDescricao.Text.Trim(),
                    valor = Convert.ToDecimal(txtValor.Text.Trim()),
                    tipo = vlValue,
                    corretora = variaveis.CorretoraId
                });
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadContaCorrente_Load(object sender, EventArgs e)
        {
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add(new Business.ComboBoxItem { Text = "Depósito", Value= (int)Business.EnumTipoMov.Deposito });
            cmbTipo.Items.Add(new Business.ComboBoxItem { Text = "Saque", Value = (int)Business.EnumTipoMov.Saque });
            cmbTipo.Items.Add(new Business.ComboBoxItem { Text = "Aplicação", Value = (int)Business.EnumTipoMov.Aplicacao });
            cmbTipo.Items.Add(new Business.ComboBoxItem { Text = "Resgate", Value = (int)Business.EnumTipoMov.Resgate });
            cmbTipo.Items.Add(new Business.ComboBoxItem { Text = "Crédito", Value = (int)Business.EnumTipoMov.Credito });
            cmbTipo.Items.Add(new Business.ComboBoxItem { Text = "Taxa", Value = (int)Business.EnumTipoMov.Taxa });
            //Depósito
            //Saque
            //Aplicação
            //Resgate
            //Crédito

        }
    }
}
