namespace Agrotis
{
    partial class frmCadClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadClientes));
            this.txtMskCEPCliente = new System.Windows.Forms.MaskedTextBox();
            this.dtGridClientes = new System.Windows.Forms.DataGridView();
            this.txtCodClientes = new System.Windows.Forms.TextBox();
            this.txtNomeClientes = new System.Windows.Forms.TextBox();
            this.txtLogradouroCliente = new System.Windows.Forms.TextBox();
            this.txtComplementoCliente = new System.Windows.Forms.TextBox();
            this.txtBairroCliente = new System.Windows.Forms.TextBox();
            this.txtCidadeCliente = new System.Windows.Forms.TextBox();
            this.txtIBGECliente = new System.Windows.Forms.TextBox();
            this.grpEnderecoCliente = new System.Windows.Forms.GroupBox();
            this.lblIBGECliente = new System.Windows.Forms.Label();
            this.lblCEPCliente = new System.Windows.Forms.Label();
            this.cmbUFCliente = new System.Windows.Forms.ComboBox();
            this.lblUFCliente = new System.Windows.Forms.Label();
            this.lblCidadeCliente = new System.Windows.Forms.Label();
            this.lblComplementoCliente = new System.Windows.Forms.Label();
            this.lblBairroCliente = new System.Windows.Forms.Label();
            this.lblNumeroLogCliente = new System.Windows.Forms.Label();
            this.txtNumeroLogCliente = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCodRegistroCliente = new System.Windows.Forms.Label();
            this.grpInformacoesClientes = new System.Windows.Forms.GroupBox();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.txtMskTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.mnuCadClientes = new System.Windows.Forms.MenuStrip();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnCadastrarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeletar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.picIconFind = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridClientes)).BeginInit();
            this.grpEnderecoCliente.SuspendLayout();
            this.grpInformacoesClientes.SuspendLayout();
            this.mnuCadClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconFind)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMskCEPCliente
            // 
            this.txtMskCEPCliente.Location = new System.Drawing.Point(332, 86);
            this.txtMskCEPCliente.Mask = "00000-000";
            this.txtMskCEPCliente.Name = "txtMskCEPCliente";
            this.txtMskCEPCliente.ReadOnly = true;
            this.txtMskCEPCliente.Size = new System.Drawing.Size(70, 20);
            this.txtMskCEPCliente.TabIndex = 3;
            this.txtMskCEPCliente.Text = "3267007";
            this.txtMskCEPCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtMskCEPCliente.TextChanged += new System.EventHandler(this.txtMskCEPCliente_TextChanged);
            // 
            // dtGridClientes
            // 
            this.dtGridClientes.AllowUserToAddRows = false;
            this.dtGridClientes.AllowUserToDeleteRows = false;
            this.dtGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGridClientes.Location = new System.Drawing.Point(15, 299);
            this.dtGridClientes.Name = "dtGridClientes";
            this.dtGridClientes.ReadOnly = true;
            this.dtGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridClientes.Size = new System.Drawing.Size(424, 282);
            this.dtGridClientes.TabIndex = 3;
            // 
            // txtCodClientes
            // 
            this.txtCodClientes.Location = new System.Drawing.Point(6, 32);
            this.txtCodClientes.Name = "txtCodClientes";
            this.txtCodClientes.ReadOnly = true;
            this.txtCodClientes.Size = new System.Drawing.Size(100, 20);
            this.txtCodClientes.TabIndex = 0;
            this.txtCodClientes.TabStop = false;
            // 
            // txtNomeClientes
            // 
            this.txtNomeClientes.Location = new System.Drawing.Point(112, 32);
            this.txtNomeClientes.Name = "txtNomeClientes";
            this.txtNomeClientes.ReadOnly = true;
            this.txtNomeClientes.Size = new System.Drawing.Size(216, 20);
            this.txtNomeClientes.TabIndex = 1;
            // 
            // txtLogradouroCliente
            // 
            this.txtLogradouroCliente.Location = new System.Drawing.Point(6, 39);
            this.txtLogradouroCliente.Name = "txtLogradouroCliente";
            this.txtLogradouroCliente.ReadOnly = true;
            this.txtLogradouroCliente.Size = new System.Drawing.Size(320, 20);
            this.txtLogradouroCliente.TabIndex = 0;
            this.txtLogradouroCliente.TabStop = false;
            // 
            // txtComplementoCliente
            // 
            this.txtComplementoCliente.Location = new System.Drawing.Point(206, 86);
            this.txtComplementoCliente.Name = "txtComplementoCliente";
            this.txtComplementoCliente.ReadOnly = true;
            this.txtComplementoCliente.Size = new System.Drawing.Size(120, 20);
            this.txtComplementoCliente.TabIndex = 5;
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.Location = new System.Drawing.Point(6, 86);
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.ReadOnly = true;
            this.txtBairroCliente.Size = new System.Drawing.Size(190, 20);
            this.txtBairroCliente.TabIndex = 0;
            this.txtBairroCliente.TabStop = false;
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.Location = new System.Drawing.Point(6, 132);
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.ReadOnly = true;
            this.txtCidadeCliente.Size = new System.Drawing.Size(167, 20);
            this.txtCidadeCliente.TabIndex = 0;
            this.txtCidadeCliente.TabStop = false;
            // 
            // txtIBGECliente
            // 
            this.txtIBGECliente.Location = new System.Drawing.Point(332, 133);
            this.txtIBGECliente.Name = "txtIBGECliente";
            this.txtIBGECliente.ReadOnly = true;
            this.txtIBGECliente.Size = new System.Drawing.Size(70, 20);
            this.txtIBGECliente.TabIndex = 0;
            this.txtIBGECliente.TabStop = false;
            // 
            // grpEnderecoCliente
            // 
            this.grpEnderecoCliente.Controls.Add(this.lblIBGECliente);
            this.grpEnderecoCliente.Controls.Add(this.lblCEPCliente);
            this.grpEnderecoCliente.Controls.Add(this.txtIBGECliente);
            this.grpEnderecoCliente.Controls.Add(this.cmbUFCliente);
            this.grpEnderecoCliente.Controls.Add(this.lblUFCliente);
            this.grpEnderecoCliente.Controls.Add(this.lblCidadeCliente);
            this.grpEnderecoCliente.Controls.Add(this.lblComplementoCliente);
            this.grpEnderecoCliente.Controls.Add(this.lblBairroCliente);
            this.grpEnderecoCliente.Controls.Add(this.txtCidadeCliente);
            this.grpEnderecoCliente.Controls.Add(this.lblNumeroLogCliente);
            this.grpEnderecoCliente.Controls.Add(this.txtMskCEPCliente);
            this.grpEnderecoCliente.Controls.Add(this.txtNumeroLogCliente);
            this.grpEnderecoCliente.Controls.Add(this.lblLogradouro);
            this.grpEnderecoCliente.Controls.Add(this.txtBairroCliente);
            this.grpEnderecoCliente.Controls.Add(this.txtLogradouroCliente);
            this.grpEnderecoCliente.Controls.Add(this.txtComplementoCliente);
            this.grpEnderecoCliente.Location = new System.Drawing.Point(6, 64);
            this.grpEnderecoCliente.Name = "grpEnderecoCliente";
            this.grpEnderecoCliente.Size = new System.Drawing.Size(408, 167);
            this.grpEnderecoCliente.TabIndex = 13;
            this.grpEnderecoCliente.TabStop = false;
            this.grpEnderecoCliente.Text = "Endereço";
            // 
            // lblIBGECliente
            // 
            this.lblIBGECliente.AutoSize = true;
            this.lblIBGECliente.Location = new System.Drawing.Point(329, 117);
            this.lblIBGECliente.Name = "lblIBGECliente";
            this.lblIBGECliente.Size = new System.Drawing.Size(35, 13);
            this.lblIBGECliente.TabIndex = 22;
            this.lblIBGECliente.Text = "IBGE:";
            // 
            // lblCEPCliente
            // 
            this.lblCEPCliente.AutoSize = true;
            this.lblCEPCliente.Location = new System.Drawing.Point(332, 69);
            this.lblCEPCliente.Name = "lblCEPCliente";
            this.lblCEPCliente.Size = new System.Drawing.Size(31, 13);
            this.lblCEPCliente.TabIndex = 21;
            this.lblCEPCliente.Text = "CEP:";
            // 
            // cmbUFCliente
            // 
            this.cmbUFCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUFCliente.Enabled = false;
            this.cmbUFCliente.FormattingEnabled = true;
            this.cmbUFCliente.Items.AddRange(new object[] {
            "Roraima\t- RR",
            "Amapá - AP",
            "Amazonas - AM",
            "Pará - PA",
            "Acre - AC",
            "Rondônia - RO",
            "Tocantins - TO",
            "Maranhão - MA",
            "Piauí - PI",
            "Ceará - CE",
            "Rio Grande do Norte - RN",
            "Paraíba - PB",
            "Pernambuco - PE",
            "Alagoas - AL",
            "Sergipe - SE",
            "Bahia - BA",
            "Mato Grosso - MT",
            "Distrito Federal - DF",
            "Goiás - GO",
            "Mato Grosso do Sul - MS",
            "Minas Gerais - MG",
            "Espírito Santo - ES",
            "Rio de Janeiro - RJ",
            "São Paulo - SP",
            "Paraná - PR",
            "Santa Catarina - SC",
            "Rio Grande do Sul - RS"});
            this.cmbUFCliente.Location = new System.Drawing.Point(179, 132);
            this.cmbUFCliente.Name = "cmbUFCliente";
            this.cmbUFCliente.Size = new System.Drawing.Size(147, 21);
            this.cmbUFCliente.TabIndex = 0;
            this.cmbUFCliente.TabStop = false;
            // 
            // lblUFCliente
            // 
            this.lblUFCliente.AutoSize = true;
            this.lblUFCliente.Location = new System.Drawing.Point(176, 116);
            this.lblUFCliente.Name = "lblUFCliente";
            this.lblUFCliente.Size = new System.Drawing.Size(24, 13);
            this.lblUFCliente.TabIndex = 19;
            this.lblUFCliente.Text = "UF:";
            // 
            // lblCidadeCliente
            // 
            this.lblCidadeCliente.AutoSize = true;
            this.lblCidadeCliente.Location = new System.Drawing.Point(6, 116);
            this.lblCidadeCliente.Name = "lblCidadeCliente";
            this.lblCidadeCliente.Size = new System.Drawing.Size(43, 13);
            this.lblCidadeCliente.TabIndex = 18;
            this.lblCidadeCliente.Text = "Cidade:";
            // 
            // lblComplementoCliente
            // 
            this.lblComplementoCliente.AutoSize = true;
            this.lblComplementoCliente.Location = new System.Drawing.Point(203, 69);
            this.lblComplementoCliente.Name = "lblComplementoCliente";
            this.lblComplementoCliente.Size = new System.Drawing.Size(74, 13);
            this.lblComplementoCliente.TabIndex = 17;
            this.lblComplementoCliente.Text = "Complemento:";
            // 
            // lblBairroCliente
            // 
            this.lblBairroCliente.AutoSize = true;
            this.lblBairroCliente.Location = new System.Drawing.Point(6, 69);
            this.lblBairroCliente.Name = "lblBairroCliente";
            this.lblBairroCliente.Size = new System.Drawing.Size(37, 13);
            this.lblBairroCliente.TabIndex = 16;
            this.lblBairroCliente.Text = "Bairro:";
            // 
            // lblNumeroLogCliente
            // 
            this.lblNumeroLogCliente.AutoSize = true;
            this.lblNumeroLogCliente.Location = new System.Drawing.Point(325, 23);
            this.lblNumeroLogCliente.Name = "lblNumeroLogCliente";
            this.lblNumeroLogCliente.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroLogCliente.TabIndex = 15;
            this.lblNumeroLogCliente.Text = "Número:";
            // 
            // txtNumeroLogCliente
            // 
            this.txtNumeroLogCliente.Location = new System.Drawing.Point(328, 39);
            this.txtNumeroLogCliente.Name = "txtNumeroLogCliente";
            this.txtNumeroLogCliente.ReadOnly = true;
            this.txtNumeroLogCliente.Size = new System.Drawing.Size(74, 20);
            this.txtNumeroLogCliente.TabIndex = 4;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(6, 23);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 8;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(114, 16);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCliente.TabIndex = 22;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // lblCodRegistroCliente
            // 
            this.lblCodRegistroCliente.AutoSize = true;
            this.lblCodRegistroCliente.Location = new System.Drawing.Point(6, 16);
            this.lblCodRegistroCliente.Name = "lblCodRegistroCliente";
            this.lblCodRegistroCliente.Size = new System.Drawing.Size(43, 13);
            this.lblCodRegistroCliente.TabIndex = 23;
            this.lblCodRegistroCliente.Text = "Código:";
            // 
            // grpInformacoesClientes
            // 
            this.grpInformacoesClientes.Controls.Add(this.lblTelefoneCliente);
            this.grpInformacoesClientes.Controls.Add(this.lblCodRegistroCliente);
            this.grpInformacoesClientes.Controls.Add(this.txtMskTelefoneCliente);
            this.grpInformacoesClientes.Controls.Add(this.grpEnderecoCliente);
            this.grpInformacoesClientes.Controls.Add(this.txtCodClientes);
            this.grpInformacoesClientes.Controls.Add(this.lblNomeCliente);
            this.grpInformacoesClientes.Controls.Add(this.txtNomeClientes);
            this.grpInformacoesClientes.Location = new System.Drawing.Point(15, 28);
            this.grpInformacoesClientes.Name = "grpInformacoesClientes";
            this.grpInformacoesClientes.Size = new System.Drawing.Size(424, 239);
            this.grpInformacoesClientes.TabIndex = 25;
            this.grpInformacoesClientes.TabStop = false;
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.Location = new System.Drawing.Point(329, 16);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(52, 13);
            this.lblTelefoneCliente.TabIndex = 24;
            this.lblTelefoneCliente.Text = "Telefone:";
            // 
            // txtMskTelefoneCliente
            // 
            this.txtMskTelefoneCliente.Location = new System.Drawing.Point(332, 32);
            this.txtMskTelefoneCliente.Mask = "(00)00000-0000";
            this.txtMskTelefoneCliente.Name = "txtMskTelefoneCliente";
            this.txtMskTelefoneCliente.ReadOnly = true;
            this.txtMskTelefoneCliente.Size = new System.Drawing.Size(82, 20);
            this.txtMskTelefoneCliente.TabIndex = 2;
            this.txtMskTelefoneCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mnuCadClientes
            // 
            this.mnuCadClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrarCliente,
            this.btnEditar,
            this.btnDeletar,
            this.btnSalvar,
            this.btnCancel});
            this.mnuCadClientes.Location = new System.Drawing.Point(0, 0);
            this.mnuCadClientes.Name = "mnuCadClientes";
            this.mnuCadClientes.Size = new System.Drawing.Size(456, 24);
            this.mnuCadClientes.TabIndex = 28;
            this.mnuCadClientes.Text = "menuStrip1";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(297, 273);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(142, 20);
            this.txtPesquisa.TabIndex = 29;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Image = global::Agrotis.Properties.Resources.Add;
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(64, 20);
            this.btnCadastrarCliente.Text = "Novo";
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::Agrotis.Properties.Resources.Edit;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(65, 20);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Image = global::Agrotis.Properties.Resources.Delete;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(72, 20);
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Agrotis.Properties.Resources.Acc;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(66, 20);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Agrotis.Properties.Resources.Delete;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 20);
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picIconFind
            // 
            this.picIconFind.Image = global::Agrotis.Properties.Resources.Find;
            this.picIconFind.Location = new System.Drawing.Point(264, 269);
            this.picIconFind.Name = "picIconFind";
            this.picIconFind.Size = new System.Drawing.Size(27, 27);
            this.picIconFind.TabIndex = 23;
            this.picIconFind.TabStop = false;
            // 
            // frmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 588);
            this.Controls.Add(this.picIconFind);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.grpInformacoesClientes);
            this.Controls.Add(this.dtGridClientes);
            this.Controls.Add(this.mnuCadClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuCadClientes;
            this.MaximizeBox = false;
            this.Name = "frmCadClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrotis - Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCadClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridClientes)).EndInit();
            this.grpEnderecoCliente.ResumeLayout(false);
            this.grpEnderecoCliente.PerformLayout();
            this.grpInformacoesClientes.ResumeLayout(false);
            this.grpInformacoesClientes.PerformLayout();
            this.mnuCadClientes.ResumeLayout(false);
            this.mnuCadClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtMskCEPCliente;
        private System.Windows.Forms.DataGridView dtGridClientes;
        private System.Windows.Forms.TextBox txtCodClientes;
        private System.Windows.Forms.TextBox txtNomeClientes;
        private System.Windows.Forms.TextBox txtLogradouroCliente;
        private System.Windows.Forms.TextBox txtComplementoCliente;
        private System.Windows.Forms.TextBox txtBairroCliente;
        private System.Windows.Forms.TextBox txtCidadeCliente;
        private System.Windows.Forms.TextBox txtIBGECliente;
        private System.Windows.Forms.GroupBox grpEnderecoCliente;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.ComboBox cmbUFCliente;
        private System.Windows.Forms.Label lblUFCliente;
        private System.Windows.Forms.Label lblCidadeCliente;
        private System.Windows.Forms.Label lblComplementoCliente;
        private System.Windows.Forms.Label lblBairroCliente;
        private System.Windows.Forms.Label lblNumeroLogCliente;
        private System.Windows.Forms.TextBox txtNumeroLogCliente;
        private System.Windows.Forms.Label lblCEPCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblIBGECliente;
        private System.Windows.Forms.Label lblCodRegistroCliente;
        private System.Windows.Forms.GroupBox grpInformacoesClientes;
        private System.Windows.Forms.MenuStrip mnuCadClientes;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrarCliente;
        private System.Windows.Forms.ToolStripMenuItem btnEditar;
        private System.Windows.Forms.ToolStripMenuItem btnDeletar;
        private System.Windows.Forms.ToolStripMenuItem btnSalvar;
        private System.Windows.Forms.ToolStripMenuItem btnCancel;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.MaskedTextBox txtMskTelefoneCliente;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.PictureBox picIconFind;
    }
}

