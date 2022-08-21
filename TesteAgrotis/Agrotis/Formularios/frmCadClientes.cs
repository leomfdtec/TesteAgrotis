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
    public partial class frmCadClientes : Form
    {

        private ClsClientes clsClientes = new ClsClientes();
        public frmCadClientes()
        {
            InitializeComponent();
        }

        #region ENCAPSULAMENTOS
        public string CodCliente { get; set; }
        public string NomeCliente { get; set; }

        public void BuscarRegistro()
        {
            this.dtGridClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(delegate
            {
                CodCliente = dtGridClientes.Rows[dtGridClientes.SelectedRows[0].Index].Cells[0].Value.ToString();
                NomeCliente = dtGridClientes.Rows[dtGridClientes.SelectedRows[0].Index].Cells[1].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            });
        }

        #endregion

        #region UTIL
        private void ConfiguraCmbUF(string UF)
        {
            switch (UF)
            {
                case "RR": cmbUFCliente.SelectedItem = "Roraima - RR"; break;
                case "AP": cmbUFCliente.SelectedItem = "Amapá - AP"; break;
                case "AM": cmbUFCliente.SelectedItem = "Amazonas - AM"; break;
                case "PA": cmbUFCliente.SelectedItem = "Pará - PA"; break;
                case "AC": cmbUFCliente.SelectedItem = "Acre - AC"; break;
                case "RO": cmbUFCliente.SelectedItem = "Rondônia - RO"; break;
                case "TO": cmbUFCliente.SelectedItem = "Tocantins - TO"; break;
                case "MA": cmbUFCliente.SelectedItem = "Maranhão - MA"; break;
                case "PI": cmbUFCliente.SelectedItem = "Piauí - PI"; break;
                case "CE": cmbUFCliente.SelectedItem = "Ceará - CE"; break;
                case "RN": cmbUFCliente.SelectedItem = "Rio Grande do Norte - RN"; break;
                case "PB": cmbUFCliente.SelectedItem = "Paraíba - PB"; break;
                case "PE": cmbUFCliente.SelectedItem = "Pernambuco - PE"; break;
                case "AL": cmbUFCliente.SelectedItem = "Alagoas - AL"; break;
                case "SE": cmbUFCliente.SelectedItem = "Sergipe - SE"; break;
                case "BA": cmbUFCliente.SelectedItem = "Bahia - BA"; break;
                case "MT": cmbUFCliente.SelectedItem = "Mato Grosso - MT"; break;
                case "DF": cmbUFCliente.SelectedItem = "Distrito Federal - DF"; break;
                case "GO": cmbUFCliente.SelectedItem = "Goiás - GO"; break;
                case "MS": cmbUFCliente.SelectedItem = "Mato Grosso do Sul - MS"; break;
                case "MG": cmbUFCliente.SelectedItem = "Minas Gerais - MG"; break;
                case "ES": cmbUFCliente.SelectedItem = "Espírito Santo - ES"; break;
                case "RJ": cmbUFCliente.SelectedItem = "Rio de Janeiro - RJ"; break;
                case "SP": cmbUFCliente.SelectedItem = "São Paulo - SP"; break;
                case "PR": cmbUFCliente.SelectedItem = "Paraná - PR"; break;
                case "SC": cmbUFCliente.SelectedItem = "Santa Catarina - SC"; break;
                case "RS": cmbUFCliente.SelectedItem = "Rio Grande do Sul - RS"; break;
            }
        }

        private void txtMskCEPCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtMskCEPCliente.Text.Length == 8 && txtMskCEPCliente.ReadOnly == false)
            {
                try
                {
                    Ferramentas.DadosCEP dadosCep = null;
                    Ferramentas.PesquisaCep(txtMskCEPCliente.Text, ref dadosCep);

                    txtLogradouroCliente.Text = dadosCep.Logradouro;
                    txtBairroCliente.Text = dadosCep.Bairro;
                    txtCidadeCliente.Text = dadosCep.Localidade;

                    txtIBGECliente.Text = dadosCep.IBGE;

                    ConfiguraCmbUF(dadosCep.UF);

                    txtNumeroLogCliente.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmbUFCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUFCliente.Items[0].ToString().Length == 0)
            {
                cmbUFCliente.Items.RemoveAt(0);
            }
            this.cmbUFCliente.SelectedIndexChanged -= new System.EventHandler(this.cmbUFCliente_SelectedIndexChanged);
        }

        private void ConfiguraForm(Operacao operacao)
        {
            switch (operacao)
            {
                case Operacao.NovoRegistro:
                    btnEditar.Visible = false;
                    btnDeletar.Visible = false;
                    btnCadastrarCliente.Visible = false;

                    dtGridClientes.Enabled = false;

                    btnSalvar.Visible = true;
                    btnCancel.Visible = true;

                    txtMskTelefoneCliente.ReadOnly = false;
                    txtNomeClientes.ReadOnly = false;
                    txtNumeroLogCliente.ReadOnly = false;
                    txtMskCEPCliente.ReadOnly = false;
                    txtComplementoCliente.ReadOnly = false;

                    cmbUFCliente.Items.Insert(0, "");
                    cmbUFCliente.SelectedIndex = 0;
                    this.cmbUFCliente.SelectedIndexChanged += new System.EventHandler(this.cmbUFCliente_SelectedIndexChanged);

                    txtNomeClientes.Clear();
                    txtMskCEPCliente.Clear();
                    txtLogradouroCliente.Clear();
                    txtNumeroLogCliente.Clear();
                    txtIBGECliente.Clear();
                    txtBairroCliente.Clear();
                    txtCidadeCliente.Clear();
                    txtComplementoCliente.Clear();
                    txtMskTelefoneCliente.Clear();
                    txtNomeClientes.Focus();

                    txtCodClientes.Text = clsClientes.ProximoCodigoCliente().ToString();

                    this.btnSalvar.Click += new System.EventHandler(this.btnSalvarNovo_Click);

                    break;
                case Operacao.EditarRegistro:
                    btnEditar.Visible = false;
                    btnDeletar.Visible = false;
                    btnCadastrarCliente.Visible = false;

                    dtGridClientes.Enabled = false;

                    btnSalvar.Visible = true;
                    btnCancel.Visible = true;

                    txtMskTelefoneCliente.ReadOnly = false;
                    txtMskCEPCliente.ReadOnly = false;
                    txtComplementoCliente.ReadOnly = false;

                    this.btnSalvar.Click += new System.EventHandler(this.btnSalvarEdicao_Click);
                    break;
                case Operacao.Resetar:
                    btnEditar.Visible = true;
                    btnDeletar.Visible = true;
                    btnCadastrarCliente.Visible = true;

                    dtGridClientes.Enabled = true;

                    btnSalvar.Visible = false;
                    btnCancel.Visible = false;

                    txtNomeClientes.ReadOnly = true;
                    txtMskTelefoneCliente.ReadOnly = true;
                    txtMskCEPCliente.ReadOnly = true;
                    txtComplementoCliente.ReadOnly = true;
                    txtNumeroLogCliente.ReadOnly = true;
                    break;

                case Operacao.ResetarDataGrid:
                    try { dtGridClientes.DataSource = null; }
                    catch { dtGridClientes.DataSource = null; }
                    break;
            }
        }
        #endregion UTIL

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            dtGridClientes.DataSource = clsClientes.CarregarClientes();

            dtGridClientes.ClearSelection();
            dtGridClientes.CurrentCell = null;

            this.dtGridClientes.SelectionChanged += new System.EventHandler(delegate (object sender_, EventArgs e_)
            {
                string CodCliente = dtGridClientes.Rows[dtGridClientes.SelectedRows[0].Index].Cells[0].Value.ToString();

                Clientes clientes = clsClientes.CarregarClientes(CodCliente);

                txtCodClientes.Text = CodCliente;
                txtNomeClientes.Text = dtGridClientes.Rows[dtGridClientes.SelectedRows[0].Index].Cells[1].Value.ToString();
                txtMskCEPCliente.Text = clientes.CEP;
                txtMskTelefoneCliente.Text = clientes.Telefone;
                txtLogradouroCliente.Text = clientes.Logradouro;
                txtNumeroLogCliente.Text = clientes.Numero;
                txtComplementoCliente.Text = clientes.Complemento;
                txtBairroCliente.Text = clientes.Bairro;
                txtCidadeCliente.Text = clientes.Cidade;

                ConfiguraCmbUF(clientes.UF);

                txtIBGECliente.Text = clientes.IBGE;

                btnEditar.Enabled = true;
                btnDeletar.Enabled = true;
            });
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            ConfiguraForm(Operacao.NovoRegistro);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ConfiguraForm(Operacao.EditarRegistro);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ConfiguraForm(Operacao.Resetar);
        }

        private void btnSalvarNovo_Click(object sender, EventArgs e)
        {
            string cmbUF = cmbUFCliente.SelectedItem.ToString();
            try
            {
                clsClientes.SalvarNovoRegistro(new Clientes()
                {
                    Nome = txtNomeClientes.Text,
                    Telefone = txtMskTelefoneCliente.Text,
                    Logradouro = txtLogradouroCliente.Text,
                    Numero = txtNumeroLogCliente.Text,
                    Bairro = txtBairroCliente.Text,
                    Complemento = txtComplementoCliente.Text,
                    CEP = txtMskCEPCliente.Text,
                    Cidade = txtCidadeCliente.Text,
                    UF = (cmbUF.Length > 0) ? cmbUF.Substring(cmbUF.IndexOf("-") + 2, 2) : "",
                    IBGE = txtIBGECliente.Text
                });

                MessageBox.Show("Registro salvo com sucesso!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.btnSalvar.Click -= new System.EventHandler(this.btnSalvarNovo_Click);

                ConfiguraForm(Operacao.Resetar);
                ConfiguraForm(Operacao.ResetarDataGrid);
                dtGridClientes.DataSource = clsClientes.CarregarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            string cmbUF = cmbUFCliente.SelectedItem.ToString();
            try
            {
                clsClientes.EditarRegistro(new Clientes()
                {
                    Cod = int.Parse(txtCodClientes.Text),
                    Nome = txtNomeClientes.Text,
                    Telefone = txtMskTelefoneCliente.Text,
                    Logradouro = txtLogradouroCliente.Text,
                    Numero = txtNumeroLogCliente.Text,
                    Bairro = txtBairroCliente.Text,
                    Complemento = txtComplementoCliente.Text,
                    CEP = txtMskCEPCliente.Text,
                    Cidade = txtCidadeCliente.Text,
                    UF = (cmbUF.Length > 0) ? cmbUF.Substring(cmbUF.IndexOf("-") + 2, 2) : "",
                    IBGE = txtIBGECliente.Text
                });

                MessageBox.Show("Registro salvo com sucesso!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.btnSalvar.Click -= new System.EventHandler(this.btnSalvarEdicao_Click);

                ConfiguraForm(Operacao.Resetar);
                ConfiguraForm(Operacao.ResetarDataGrid);
                dtGridClientes.DataSource = clsClientes.CarregarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja deletar esse registro?", "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    clsClientes.DeletarRegistro(txtCodClientes.Text);

                    ConfiguraForm(Operacao.Resetar);
                    ConfiguraForm(Operacao.ResetarDataGrid);
                    dtGridClientes.DataSource = clsClientes.CarregarClientes();

                    MessageBox.Show("Cliente deletado com sucesso!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                ConfiguraForm(Operacao.ResetarDataGrid);
                if (txtPesquisa.Text != "")
                {
                    dtGridClientes.DataSource = clsClientes.FiltrarClientes(txtPesquisa.Text);
                }
                else
                {
                    dtGridClientes.DataSource = clsClientes.CarregarClientes();
                }
            }
        }
    }
}
