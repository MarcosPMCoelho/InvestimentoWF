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
    public partial class FrmResultado : Form
    {
        public FrmResultado()
        {
            InitializeComponent();
        }

        private void FrmResultado_Load(object sender, EventArgs e)
        {
            Api.Resultado resultado = new Api.Resultado();
            var lisResultado = resultado.GetResultado();
            dgResultado.DataSource = lisResultado;
        }

        
        private void dgResultado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //if (dbResultado.Columns[e.ColumnIndex].Name == "TotalCompra")
                //{
                //    // Certifique-se de que você tem acesso às outras colunas (Quantidade e Preco)
                //    decimal valor_unit = Convert.ToDecimal(dbResultado.Rows[e.RowIndex].Cells["vl_unit"].Value);
                //    int qtd = Convert.ToInt32(dbResultado.Rows[e.RowIndex].Cells["quantidade"].Value);
                //    e.Value = valor_unit * qtd;
                //}

                //    if (dgAnalise.Columns[e.ColumnIndex].Name == "TotalAtual")
                //    {
                //        // Certifique-se de que você tem acesso às outras colunas (Quantidade e Preco)
                //        decimal vl_unitario = Convert.ToDecimal(dgAnalise.Rows[e.RowIndex].Cells["valor_cotacao"].Value);
                //        int qtd = Convert.ToInt32(dgAnalise.Rows[e.RowIndex].Cells["quantidade"].Value);
                //        e.Value = vl_unitario * qtd;
                //    }

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

        private void FrmResultado_Resize(object sender, EventArgs e)
        {

        }
    }
}
