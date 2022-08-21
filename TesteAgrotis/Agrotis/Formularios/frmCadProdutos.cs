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
    public partial class frmCadProdutos : Form
    {
        private ClsProdutos clsProdutos = new ClsProdutos();
        public frmCadProdutos()
        {
            InitializeComponent();
        }

        public string CodProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Quantidade { get; set; }
        public string PesoProduto { get; set; }
        public string PrecoProduto { get; set; }

        public void BuscarRegistro()
        {
            this.dtGridProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(delegate
            {
                string Res = Microsoft.VisualBasic.Interaction.InputBox("Digite a quantidade desejada", "", "");

                if (Res != "")
                {
                    CodProduto = txtCodProduto.Text;
                    NomeProduto = txtNomeProduto.Text;
                    Quantidade = Res;
                    PesoProduto = txtMskPesoProduto.Text;
                    PrecoProduto = txtMskPrecoProduto.Text;

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            });
        }


        #region UTIL
        private void ConfiguraForm(Operacao operacao)
        {
            switch (operacao)
            {
                case Operacao.NovoRegistro:
                    btnCadastrarProdutos.Visible = false;
                    btnEditarProdutos.Visible = false;
                    btnDeletarProdutos.Visible = false;

                    btnSalvarProdutos.Visible = true;
                    btnCancelar.Visible = true;

                    txtNomeProduto.ReadOnly = false;
                    txtDescricaoProduto.ReadOnly = false;
                    txtMskPesoProduto.ReadOnly = false;
                    txtMskPrecoProduto.ReadOnly = false;

                    dtGridProdutos.Enabled = false;

                    txtNomeProduto.Clear();
                    txtDescricaoProduto.Clear();
                    txtMskPesoProduto.Clear();
                    txtMskPrecoProduto.Clear();
                    break;
                case Operacao.EditarRegistro:
                    btnCadastrarProdutos.Visible = false;
                    btnEditarProdutos.Visible = false;
                    btnDeletarProdutos.Visible = false;

                    btnSalvarProdutos.Visible = true;
                    btnCancelar.Visible = true;

                    txtNomeProduto.ReadOnly = false;
                    txtDescricaoProduto.ReadOnly = false;
                    txtMskPesoProduto.ReadOnly = false;
                    txtMskPrecoProduto.ReadOnly = false;

                    dtGridProdutos.Enabled = false;
                    break;
                case Operacao.Resetar:
                    btnCadastrarProdutos.Visible = true;
                    btnEditarProdutos.Visible = true;
                    btnDeletarProdutos.Visible = true;

                    btnSalvarProdutos.Visible = false;
                    btnCancelar.Visible = false;

                    txtNomeProduto.ReadOnly = true;
                    txtDescricaoProduto.ReadOnly = true;
                    txtMskPesoProduto.ReadOnly = true;
                    txtMskPrecoProduto.ReadOnly = true;

                    dtGridProdutos.Enabled = true;
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
            dtGridProdutos.DataSource = clsProdutos.CarregarProdutos();

            dtGridProdutos.ClearSelection();
            dtGridProdutos.CurrentCell = null;

            this.dtGridProdutos.SelectionChanged += new System.EventHandler(delegate (object sender_, EventArgs e_)
            {
                string CodProduto = dtGridProdutos.Rows[dtGridProdutos.SelectedRows[0].Index].Cells[0].Value.ToString();

                Produto produto = clsProdutos.CarregarProdutos(CodProduto);

                txtCodProduto.Text = CodProduto;
                txtNomeProduto.Text = produto.Nome;
                txtDescricaoProduto.Text = produto.Descricao;
                txtMskPesoProduto.Text = produto.Peso.ToString();
                txtMskPrecoProduto.Text = produto.Preco.ToString();

                btnEditarProdutos.Enabled = true;
                btnDeletarProdutos.Enabled = true;
            });
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            ConfiguraForm(Operacao.NovoRegistro);

            txtNomeProduto.Focus();

            txtCodProduto.Text = clsProdutos.ProximoCodigoCliente().ToString();

            this.btnSalvarProdutos.Click += new System.EventHandler(this.btnSalvarNovo_Click);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ConfiguraForm(Operacao.EditarRegistro);

            this.btnSalvarProdutos.Click += new System.EventHandler(this.btnSalvarEdicao_Click);
        }


        private void btnSalvarNovo_Click(object sender, EventArgs e)
        {
            try
            {
                clsProdutos.SalvarNovoRegistro(new Produto()
                {
                    Nome = txtNomeProduto.Text,
                    Descricao = txtDescricaoProduto.Text,
                    Preco = (txtMskPrecoProduto.Text.Replace(" ", "") != "") ? int.Parse(txtMskPrecoProduto.Text.Replace(" ", "")) : 0,
                    Peso = (txtMskPesoProduto.Text.Replace(" ", "") != "") ? int.Parse(txtMskPesoProduto.Text.Replace(" ", "")) : 0
                });

                MessageBox.Show("Registro salvo com sucesso!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.btnSalvarProdutos.Click -= new System.EventHandler(this.btnSalvarNovo_Click);

                ConfiguraForm(Operacao.Resetar);
                ConfiguraForm(Operacao.ResetarDataGrid);
                dtGridProdutos.DataSource = clsProdutos.CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            try
            {
                clsProdutos.EditarRegistro(new Produto()
                {
                    Cod = txtCodProduto.Text,
                    Nome = txtNomeProduto.Text,
                    Descricao = txtDescricaoProduto.Text,
                    Preco = (txtMskPrecoProduto.Text.Replace(" ", "") != "") ? int.Parse(txtMskPrecoProduto.Text.Replace(" ", "")) : 0,
                    Peso = (txtMskPesoProduto.Text.Replace(" ", "") != "") ? int.Parse(txtMskPesoProduto.Text.Replace(" ", "")) : 0
                });

                MessageBox.Show("Registro salvo com sucesso!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.btnSalvarProdutos.Click -= new System.EventHandler(this.btnSalvarEdicao_Click);

                ConfiguraForm(Operacao.Resetar);
                ConfiguraForm(Operacao.ResetarDataGrid);
                dtGridProdutos.DataSource = clsProdutos.CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ConfiguraForm(Operacao.Resetar);
        }

        private void btnDeletarProdutos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar esse registro?", "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    clsProdutos.DeletarProduto(txtCodProduto.Text);

                    MessageBox.Show("Produto deletado com sucesso!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ConfiguraForm(Operacao.Resetar);
                    ConfiguraForm(Operacao.ResetarDataGrid);
                    dtGridProdutos.DataSource = clsProdutos.CarregarProdutos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ConfiguraForm(Operacao.ResetarDataGrid);
                if (txtPesquisa.Text != "")
                {
                    dtGridProdutos.DataSource = clsProdutos.FiltrarProdutos(txtPesquisa.Text);
                }
                else
                {
                    dtGridProdutos.DataSource = clsProdutos.CarregarProdutos();
                }
            }
        }
    }
}
