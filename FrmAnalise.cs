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
    public partial class FrmAnalise : Form
    {
        public FrmAnalise()
        {
            InitializeComponent();
        }

        private void FrmAnalise_Load(object sender, EventArgs e)
        {
            Api.Analise analise = new Api.Analise();
            var listaAnalise = analise.GetAnalise();
            dgAnalise.DataSource = listaAnalise;

        }

        private void dgAnalise_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgAnalise_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgAnalise_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgAnalise.Columns[e.ColumnIndex].Name == "TotalCompra")
                {
                    // Certifique-se de que você tem acesso às outras colunas (Quantidade e Preco)
                    decimal valor_unit = Convert.ToDecimal(dgAnalise.Rows[e.RowIndex].Cells["vl_unit"].Value);
                    int qtd = Convert.ToInt32(dgAnalise.Rows[e.RowIndex].Cells["quantidade"].Value);
                    e.Value = valor_unit * qtd;
                }

                if (dgAnalise.Columns[e.ColumnIndex].Name == "TotalAtual")
                {
                    // Certifique-se de que você tem acesso às outras colunas (Quantidade e Preco)
                    decimal vl_unitario = Convert.ToDecimal(dgAnalise.Rows[e.RowIndex].Cells["valor_cotacao"].Value);
                    int qtd = Convert.ToInt32(dgAnalise.Rows[e.RowIndex].Cells["quantidade"].Value);
                    e.Value = vl_unitario * qtd;
                }

                if (dgAnalise.Columns[e.ColumnIndex].Name == "Resultado")
                {
                    // Certifique-se de que você tem acesso às outras colunas (Quantidade e Preco)
                    decimal valor_unit = Convert.ToDecimal(dgAnalise.Rows[e.RowIndex].Cells["vl_unit"].Value);
                    decimal valor_cotacao = Convert.ToDecimal(dgAnalise.Rows[e.RowIndex].Cells["valor_cotacao"].Value);
                    int qtd = Convert.ToInt32(dgAnalise.Rows[e.RowIndex].Cells["quantidade"].Value);
                    e.Value = (valor_cotacao - valor_unit ) * qtd;
                }

            }
        }
    }
}
