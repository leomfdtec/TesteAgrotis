using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json.Serialization;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using RestSharp.Serialization.Json;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Web.UI.WebControls;
using System.Data.SQLite;
using System.Data.Entity;
using System.Xml;
using static Agrotis.Ferramentas;

namespace Agrotis
{
    public partial class frmPedidos : Form
    {
        private ClsPedidos clsPedidos = new ClsPedidos();
        private frmPedidosDetalhado frmPedidosDetalhado_;
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void frmCadPedidos_Load(object sender, EventArgs e)
        {
            dtGridPedidos.DataSource = clsPedidos.CarregarPedidos();
        }

        private void dtGridPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmPedidosDetalhado_ = new frmPedidosDetalhado();
                frmPedidosDetalhado_.CodPedidos = dtGridPedidos.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmPedidosDetalhado_.DataEmissao = dtGridPedidos.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmPedidosDetalhado_.CodCliente = dtGridPedidos.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmPedidosDetalhado_.NomeCliente = dtGridPedidos.Rows[e.RowIndex].Cells[3].Value.ToString();
                frmPedidosDetalhado_.ShowDialog();
                frmPedidosDetalhado_ = null;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnCadastrarPedido_Click(object sender, EventArgs e)
        {
            frmPedidosDetalhado_ = new frmPedidosDetalhado();
            frmPedidosDetalhado_.operacao_ = Operacao.NovoRegistro;
            frmPedidosDetalhado_.ShowDialog();
            frmPedidosDetalhado_ = null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmPedidosDetalhado_ = new frmPedidosDetalhado();
            frmPedidosDetalhado_.CodPedidos = dtGridPedidos.Rows[dtGridPedidos.SelectedRows[0].Index].Cells[0].Value.ToString();
            frmPedidosDetalhado_.DataEmissao = dtGridPedidos.Rows[dtGridPedidos.SelectedRows[0].Index].Cells[1].Value.ToString();
            frmPedidosDetalhado_.CodCliente = dtGridPedidos.Rows[dtGridPedidos.SelectedRows[0].Index].Cells[2].Value.ToString();
            frmPedidosDetalhado_.NomeCliente = dtGridPedidos.Rows[dtGridPedidos.SelectedRows[0].Index].Cells[3].Value.ToString();
            frmPedidosDetalhado_.operacao_ = Operacao.EditarRegistro;
            frmPedidosDetalhado_.ShowDialog();
            frmPedidosDetalhado_ = null;
        }

        private void btnDeletarPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar esse registro?", "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    clsPedidos.DeletarProduto(dtGridPedidos.Rows[dtGridPedidos.SelectedRows[0].Index].Cells[0].Value.ToString());

                    try { dtGridPedidos.DataSource = null; }
                    catch { dtGridPedidos.DataSource = null; }

                    dtGridPedidos.DataSource = clsPedidos.CarregarPedidos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
