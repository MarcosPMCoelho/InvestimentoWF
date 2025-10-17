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
        public FrmContaCorrente()
        {
            InitializeComponent();
        }

        private void FrmContaCorrente_Load(object sender, EventArgs e)
        {
            Api.ContaCorrente contaCorrente = new Api.ContaCorrente();  
            var saldo = contaCorrente.GetContaCorrenteSaldo();
            lblSaldo.Text = "Saldo: " + saldo.ToString("C2");

            dgSaldo.DataSource = contaCorrente.GetContaCorrente();
        }

        //TODO: Implementar funcionalidades de adicionar, editar e excluir transações na conta corrente
    }
}
