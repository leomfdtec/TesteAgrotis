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
using System.Globalization;

namespace Agrotis
{
    public partial class frmPedidosDetalhado : Form
    {
        private frmCadClientes frmClientes;
        private frmCadProdutos frmProdutos;
        private ClsPedidos clsPedidos = new ClsPedidos();

        #region ENCAPSULAMENTOS
        public string CodPedidos
        {
            set
            {
                txtCodPedido.Text = value;
                ConfiguraForm(Operacao.ResetarDataGrid);
                dtGridProdutos.DataSource = clsPedidos.CarregarProdutosPedido(value);

                int PrecoTotal = 0;
                int PesoTotal = 0;

                for (int i = 0; i < dtGridProdutos.RowCount; i++)
                {
                    PrecoTotal += int.Parse(dtGridProdutos.Rows[i].Cells[4].Value.ToString().Replace("R$", "").Replace(".", ""));
                    PesoTotal += int.Parse(dtGridProdutos.Rows[i].Cells[6].Value.ToString().Replace("Kg", "").Replace(".", ""));
                }

                txtPrecoTotalPedido.Text = string.Format("R${0:#.00}", Convert.ToDecimal(PrecoTotal) / 100);
                txtPesoTotalPedido.Text = string.Format("{0:#.00}Kg", Convert.ToDecimal(PesoTotal) / 100);

                dtGridProdutos.ClearSelection();
                dtGridProdutos.CurrentCell = null;
            }
        }
        public string CodCliente
        {
            set
            {
                txtCodCliente.Text = value;
            }
        }
        public string NomeCliente
        {
            set
            {
                txtNomeCliente.Text = value;
            }
        }
        public string DataEmissao
        {
            set
            {
                txtMskDatEmissao.Text = value;
            }
        }

        private Operacao operacao;
        public Operacao operacao_
        {
            set
            {
                ConfiguraForm(value);
                operacao = value;
            }
            get
            {
                return operacao;
            }
        }

        #endregion ENCAPSULAMENTOS

        public frmPedidosDetalhado()
        {
            InitializeComponent();
        }

        #region UTIL
        private void ConfiguraForm(Operacao _operacao_)
        {
            switch (_operacao_)
            {
                case Operacao.NovoRegistro:
                    txtCodPedido.Text = clsPedidos.ProximoCodigoPedidos().ToString();
                    txtMskDatEmissao.Text = DateTime.Now.ToString();

                    btnCadastrarPedidos.Visible = false;
                    btnEditarPedidos.Visible = false;

                    btnSalvarPedidos.Visible = true;
                    btnCancelar.Visible = true;

                    btnBuscarProdutos.Visible = true;

                    txtCodCliente.Clear();
                    txtNomeCliente.Clear();
                    txtDescricaoProduto.Clear();

                    try { dtGridProdutos.DataSource = null; }
                    catch { dtGridProdutos.DataSource = null; }

                    operacao = _operacao_;
                    break;
                case Operacao.EditarRegistro:

                    dtGridProdutos.Enabled = true;
                    btnBuscarProdutos.Visible = true;

                    btnSalvarPedidos.Visible = true;
                    btnCancelar.Visible = true;


                    btnCadastrarPedidos.Visible = false;
                    btnEditarPedidos.Visible = false;

                    break;
                case Operacao.Resetar:

                    break;

                case Operacao.ResetarDataGrid:
                    try { dtGridProdutos.DataSource = null; }
                    catch { dtGridProdutos.DataSource = null; }
                    break;
            }
        }
        #endregion UTIL

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {
            if (operacao == Operacao.Null)
            {
                txtDescricaoProduto.Text = clsPedidos.CarregaDecricaoProduto(dtGridProdutos.Rows[dtGridProdutos.SelectedRows[0].Index].Cells[0].Value.ToString());
            }
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            ConfiguraForm(Operacao.NovoRegistro);

            this.btnSalvarPedidos.Click += new System.EventHandler(this.btnSalvarNovo_Click);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ConfiguraForm(Operacao.EditarRegistro);

            this.btnSalvarPedidos.Click += new System.EventHandler(this.btnSalvarEdicao_Click);
        }


        private void btnSalvarNovo_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos p = new Pedidos()
                {
                    CodPedido = txtCodPedido.Text,
                    CodCliente = txtCodCliente.Text,
                    dtEmissao = txtMskDatEmissao.Text,
                    Produto = new List<Produto>()
                };

                for (int i = 0; i < dtGridProdutos.Rows.Count; i++)
                {
                    p.Produto.Add(new Produto
                    {
                        Cod = dtGridProdutos.Rows[i].Cells[0].Value.ToString(),
                        Quantidade = dtGridProdutos.Rows[i].Cells[2].Value.ToString()
                    });
                }

                clsPedidos.SalvarNovoPedido(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                this.btnSalvarPedidos.Click -= new System.EventHandler(this.btnSalvarNovo_Click);
            }
        }

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos p = new Pedidos()
                {
                    CodPedido = txtCodPedido.Text,
                    CodCliente = txtCodCliente.Text,
                    dtEmissao = txtMskDatEmissao.Text,
                    Produto = new List<Produto>()
                };

                for (int i = 0; i < dtGridProdutos.Rows.Count; i++)
                {
                    p.Produto.Add(new Produto
                    {
                        Cod = dtGridProdutos.Rows[i].Cells[0].Value.ToString(),
                        Quantidade = dtGridProdutos.Rows[i].Cells[2].Value.ToString()
                    });
                }

                clsPedidos.EditarRegistro(p);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.btnSalvarPedidos.Click -= new System.EventHandler(this.btnSalvarEdicao_Click);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ConfiguraForm(Operacao.Resetar);
        }

        private void dtGridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtDescricaoProduto.Text = clsPedidos.CarregaDecricaoProduto(dtGridProdutos.Rows[dtGridProdutos.SelectedRows[0].Index].Cells[0].Value.ToString());
            }
            catch
            {

            }
        }

        private void txtBuscarCliente_DoubleClick(object sender, EventArgs e)
        {
            if (operacao == Operacao.NovoRegistro)
            {
                frmClientes = new frmCadClientes();
                frmClientes.BuscarRegistro();
                if(frmClientes.ShowDialog() == DialogResult.OK)
                {
                    txtCodCliente.Text = frmClientes.CodCliente;
                    txtNomeCliente.Text = frmClientes.NomeCliente;
                }
                frmClientes = null;
            }
        }

        private void btnBuscarProdutos_Click(object sender, EventArgs e)
        {
            if (operacao == Operacao.NovoRegistro || operacao == Operacao.EditarRegistro)
            {
                frmProdutos = new frmCadProdutos();
                frmProdutos.BuscarRegistro();
                if (frmProdutos.ShowDialog() == DialogResult.OK)
                {

                    int PrecoTotal = 0;
                    int PesoTotal = 0;

                    for (int i = 0; i < dtGridProdutos.Rows.Count; i++)
                    {
                        PrecoTotal += int.Parse(dtGridProdutos.Rows[i].Cells[4].Value.ToString().Replace("R$", "").Replace(",", "").Replace(".", ""));
                        PesoTotal += int.Parse(dtGridProdutos.Rows[i].Cells[6].Value.ToString().Replace("Kg", "").Replace(",", "").Replace(".", ""));
                    }


                    dtGridProdutos.ColumnCount = 7;

                    dtGridProdutos.Columns[0].Name = "Código";
                    dtGridProdutos.Columns[1].Name = "Nome";
                    dtGridProdutos.Columns[2].Name = "Qnt";
                    dtGridProdutos.Columns[3].Name = "Preço Unt";
                    dtGridProdutos.Columns[4].Name = "Preço Total";
                    dtGridProdutos.Columns[5].Name = "Peso Unt";
                    dtGridProdutos.Columns[6].Name = "Peso Total";

                    dtGridProdutos.Rows.Add
                        (frmProdutos.CodProduto,
                        frmProdutos.NomeProduto,
                        frmProdutos.Quantidade,
                        string.Format("R${0:#.00}", Convert.ToDecimal(frmProdutos.PrecoProduto) / 100),
                        string.Format("R${0:#.00}", Convert.ToDecimal((int.Parse(frmProdutos.PrecoProduto) * int.Parse(frmProdutos.Quantidade))) / 100),
                        string.Format("{0:#.00}Kg", Convert.ToDecimal(frmProdutos.PesoProduto) / 100),
                        string.Format("{0:#.00}Kg", Convert.ToDecimal((int.Parse(frmProdutos.PesoProduto) * int.Parse(frmProdutos.Quantidade))) / 100));



                    PrecoTotal += (int.Parse(frmProdutos.PrecoProduto) * int.Parse(frmProdutos.Quantidade));
                    PesoTotal += (int.Parse(frmProdutos.PesoProduto) * int.Parse(frmProdutos.Quantidade));

                    txtPrecoTotalPedido.Text = string.Format("R${0:#.00}", Convert.ToDecimal(PrecoTotal) / 100);
                    txtPesoTotalPedido.Text = string.Format("{0:#.00}Kg", Convert.ToDecimal(PesoTotal) / 100);
                }

                frmClientes = null;
            }
        }
    }
}
