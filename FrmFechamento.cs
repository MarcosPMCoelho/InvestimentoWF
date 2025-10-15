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
    public partial class FrmFechamento : Form
    {
        public FrmFechamento()
        {
            InitializeComponent();
        }

        private void FrmFechamento_Load(object sender, EventArgs e)
        {
            Api.Fechamento fechamento = new Api.Fechamento();
            var listaFechamento = fechamento.GetFechamento();
            dgFechamento.DataSource = listaFechamento;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var lista = Api.Fechamento.GetFechamentoFechar();
            dgFechamento.DataSource = lista;
        }

        private void FrmFechamento_Resize(object sender, EventArgs e)
        {
            dgFechamento.Top = 70;
            dgFechamento.Left = 10;
            dgFechamento.Width = this.ClientSize.Width - 20;
            dgFechamento.Height = this.ClientSize.Height - 80;

        }

        private void dgFechamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgFechamento.Columns[e.ColumnIndex].Name == "Total")
                {
                    // Certifique-se de que você tem acesso às outras colunas (Quantidade e Preco)
                    decimal total = Convert.ToDecimal(dgFechamento.Rows[e.RowIndex].Cells["total_Aplicado"].Value);
                    decimal fechamento_val = Convert.ToInt32(dgFechamento.Rows[e.RowIndex].Cells["fechamento"].Value);
                    e.Value = total - fechamento_val;
                }

                if (dgFechamento.Columns[e.ColumnIndex].Name == "SaldoFinal")
                {
                    // Certifique-se de que você tem acesso às outras colunas (Quantidade e Preco)
                    decimal saldoFundo = Convert.ToDecimal(dgFechamento.Rows[e.RowIndex].Cells["SaldoFundo"].Value);

                    decimal saldoPrev = Convert.ToDecimal(dgFechamento.Rows[e.RowIndex].Cells["SaldoPrev"].Value);

                    decimal saldoCC = Convert.ToDecimal(dgFechamento.Rows[e.RowIndex].Cells["SaldoCC"].Value);

                    decimal fechamento_st = Convert.ToInt32(dgFechamento.Rows[e.RowIndex].Cells["fechamento"].Value);
                    e.Value = saldoFundo + saldoPrev + saldoCC + fechamento_st;
                }

                //    if (dgAnalise.Columns[e.ColumnIndex].Name == "Resultado")
                //    {
                //        // Certifique-se de que você tem acesso às outras colunas (Quantidade e Preco)
                //        decimal valor_unit = Convert.ToDecimal(dgAnalise.Rows[e.RowIndex].Cells["vl_unit"].Value);
                //        decimal valor_cotacao = Convert.ToDecimal(dgAnalise.Rows[e.RowIndex].Cells["valor_cotacao"].Value);
                //        int qtd = Convert.ToInt32(dgAnalise.Rows[e.RowIndex].Cells["quantidade"].Value);
                //        e.Value = (valor_cotacao - valor_unit) * qtd;
                //    }

            }
        }

        private void dgFechamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
