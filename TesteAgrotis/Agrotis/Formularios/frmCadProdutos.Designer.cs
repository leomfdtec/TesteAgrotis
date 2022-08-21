namespace Agrotis
{
    partial class frmCadProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProdutos));
            this.dtGridProdutos = new System.Windows.Forms.DataGridView();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.grpInformacoesProdutos = new System.Windows.Forms.GroupBox();
            this.txtMskPesoProduto = new System.Windows.Forms.MaskedTextBox();
            this.txtMskPrecoProduto = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecoProduto = new System.Windows.Forms.Label();
            this.lblPesoProduto = new System.Windows.Forms.Label();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.lblNomeProdutos = new System.Windows.Forms.Label();
            this.lblCodRegistroCliente = new System.Windows.Forms.Label();
            this.grpInformacoesClientes = new System.Windows.Forms.GroupBox();
            this.mnuCadProdutos = new System.Windows.Forms.MenuStrip();
            this.btnCadastrarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeletarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalvarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.picIconFind = new System.Windows.Forms.PictureBox();
            this.lblKg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdutos)).BeginInit();
            this.grpInformacoesProdutos.SuspendLayout();
            this.grpInformacoesClientes.SuspendLayout();
            this.mnuCadProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconFind)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridProdutos
            // 
            this.dtGridProdutos.AllowUserToAddRows = false;
            this.dtGridProdutos.AllowUserToDeleteRows = false;
            this.dtGridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGridProdutos.Location = new System.Drawing.Point(15, 301);
            this.dtGridProdutos.Name = "dtGridProdutos";
            this.dtGridProdutos.ReadOnly = true;
            this.dtGridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridProdutos.Size = new System.Drawing.Size(424, 280);
            this.dtGridProdutos.TabIndex = 3;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(6, 32);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.ReadOnly = true;
            this.txtCodProduto.Size = new System.Drawing.Size(100, 20);
            this.txtCodProduto.TabIndex = 0;
            this.txtCodProduto.TabStop = false;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(112, 32);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(302, 20);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(6, 39);
            this.txtDescricaoProduto.Multiline = true;
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.ReadOnly = true;
            this.txtDescricaoProduto.Size = new System.Drawing.Size(396, 75);
            this.txtDescricaoProduto.TabIndex = 2;
            // 
            // grpInformacoesProdutos
            // 
            this.grpInformacoesProdutos.Controls.Add(this.lblKg);
            this.grpInformacoesProdutos.Controls.Add(this.txtMskPesoProduto);
            this.grpInformacoesProdutos.Controls.Add(this.txtMskPrecoProduto);
            this.grpInformacoesProdutos.Controls.Add(this.lblPrecoProduto);
            this.grpInformacoesProdutos.Controls.Add(this.lblPesoProduto);
            this.grpInformacoesProdutos.Controls.Add(this.lblDescricaoProduto);
            this.grpInformacoesProdutos.Controls.Add(this.txtDescricaoProduto);
            this.grpInformacoesProdutos.Location = new System.Drawing.Point(6, 64);
            this.grpInformacoesProdutos.Name = "grpInformacoesProdutos";
            this.grpInformacoesProdutos.Size = new System.Drawing.Size(408, 167);
            this.grpInformacoesProdutos.TabIndex = 13;
            this.grpInformacoesProdutos.TabStop = false;
            this.grpInformacoesProdutos.Text = "Informações";
            // 
            // txtMskPesoProduto
            // 
            this.txtMskPesoProduto.Location = new System.Drawing.Point(6, 141);
            this.txtMskPesoProduto.Mask = "###,##";
            this.txtMskPesoProduto.Name = "txtMskPesoProduto";
            this.txtMskPesoProduto.Size = new System.Drawing.Size(72, 20);
            this.txtMskPesoProduto.TabIndex = 30;
            this.txtMskPesoProduto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtMskPrecoProduto
            // 
            this.txtMskPrecoProduto.Location = new System.Drawing.Point(111, 141);
            this.txtMskPrecoProduto.Mask = "$###,##";
            this.txtMskPrecoProduto.Name = "txtMskPrecoProduto";
            this.txtMskPrecoProduto.Size = new System.Drawing.Size(100, 20);
            this.txtMskPrecoProduto.TabIndex = 29;
            this.txtMskPrecoProduto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblPrecoProduto
            // 
            this.lblPrecoProduto.AutoSize = true;
            this.lblPrecoProduto.Location = new System.Drawing.Point(108, 125);
            this.lblPrecoProduto.Name = "lblPrecoProduto";
            this.lblPrecoProduto.Size = new System.Drawing.Size(77, 13);
            this.lblPrecoProduto.TabIndex = 28;
            this.lblPrecoProduto.Text = "Preço Unitário:";
            // 
            // lblPesoProduto
            // 
            this.lblPesoProduto.AutoSize = true;
            this.lblPesoProduto.Location = new System.Drawing.Point(5, 125);
            this.lblPesoProduto.Name = "lblPesoProduto";
            this.lblPesoProduto.Size = new System.Drawing.Size(73, 13);
            this.lblPesoProduto.TabIndex = 25;
            this.lblPesoProduto.Text = "Peso Líquido:";
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(4, 23);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(98, 13);
            this.lblDescricaoProduto.TabIndex = 8;
            this.lblDescricaoProduto.Text = "Descrição Produto:";
            // 
            // lblNomeProdutos
            // 
            this.lblNomeProdutos.AutoSize = true;
            this.lblNomeProdutos.Location = new System.Drawing.Point(114, 16);
            this.lblNomeProdutos.Name = "lblNomeProdutos";
            this.lblNomeProdutos.Size = new System.Drawing.Size(38, 13);
            this.lblNomeProdutos.TabIndex = 22;
            this.lblNomeProdutos.Text = "Nome:";
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
            this.grpInformacoesClientes.Controls.Add(this.lblCodRegistroCliente);
            this.grpInformacoesClientes.Controls.Add(this.grpInformacoesProdutos);
            this.grpInformacoesClientes.Controls.Add(this.txtCodProduto);
            this.grpInformacoesClientes.Controls.Add(this.lblNomeProdutos);
            this.grpInformacoesClientes.Controls.Add(this.txtNomeProduto);
            this.grpInformacoesClientes.Location = new System.Drawing.Point(15, 28);
            this.grpInformacoesClientes.Name = "grpInformacoesClientes";
            this.grpInformacoesClientes.Size = new System.Drawing.Size(424, 239);
            this.grpInformacoesClientes.TabIndex = 25;
            this.grpInformacoesClientes.TabStop = false;
            // 
            // mnuCadProdutos
            // 
            this.mnuCadProdutos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrarProdutos,
            this.btnEditarProdutos,
            this.btnDeletarProdutos,
            this.btnSalvarProdutos,
            this.btnCancelar});
            this.mnuCadProdutos.Location = new System.Drawing.Point(0, 0);
            this.mnuCadProdutos.Name = "mnuCadProdutos";
            this.mnuCadProdutos.Size = new System.Drawing.Size(456, 24);
            this.mnuCadProdutos.TabIndex = 28;
            this.mnuCadProdutos.Text = "menuStrip1";
            // 
            // btnCadastrarProdutos
            // 
            this.btnCadastrarProdutos.Image = global::Agrotis.Properties.Resources.Add;
            this.btnCadastrarProdutos.Name = "btnCadastrarProdutos";
            this.btnCadastrarProdutos.Size = new System.Drawing.Size(64, 20);
            this.btnCadastrarProdutos.Text = "Novo";
            this.btnCadastrarProdutos.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnEditarProdutos
            // 
            this.btnEditarProdutos.Enabled = false;
            this.btnEditarProdutos.Image = global::Agrotis.Properties.Resources.Edit;
            this.btnEditarProdutos.Name = "btnEditarProdutos";
            this.btnEditarProdutos.Size = new System.Drawing.Size(65, 20);
            this.btnEditarProdutos.Text = "Editar";
            this.btnEditarProdutos.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletarProdutos
            // 
            this.btnDeletarProdutos.Enabled = false;
            this.btnDeletarProdutos.Image = global::Agrotis.Properties.Resources.Delete;
            this.btnDeletarProdutos.Name = "btnDeletarProdutos";
            this.btnDeletarProdutos.Size = new System.Drawing.Size(72, 20);
            this.btnDeletarProdutos.Text = "Deletar";
            this.btnDeletarProdutos.Click += new System.EventHandler(this.btnDeletarProdutos_Click);
            // 
            // btnSalvarProdutos
            // 
            this.btnSalvarProdutos.Image = global::Agrotis.Properties.Resources.Acc;
            this.btnSalvarProdutos.Name = "btnSalvarProdutos";
            this.btnSalvarProdutos.Size = new System.Drawing.Size(66, 20);
            this.btnSalvarProdutos.Text = "Salvar";
            this.btnSalvarProdutos.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Agrotis.Properties.Resources.Delete;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 20);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(297, 275);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(142, 20);
            this.txtPesquisa.TabIndex = 31;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // picIconFind
            // 
            this.picIconFind.Image = global::Agrotis.Properties.Resources.Find;
            this.picIconFind.Location = new System.Drawing.Point(264, 271);
            this.picIconFind.Name = "picIconFind";
            this.picIconFind.Size = new System.Drawing.Size(27, 27);
            this.picIconFind.TabIndex = 32;
            this.picIconFind.TabStop = false;
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(80, 144);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(20, 13);
            this.lblKg.TabIndex = 31;
            this.lblKg.Text = "Kg";
            // 
            // frmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 588);
            this.Controls.Add(this.picIconFind);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.grpInformacoesClientes);
            this.Controls.Add(this.dtGridProdutos);
            this.Controls.Add(this.mnuCadProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuCadProdutos;
            this.MaximizeBox = false;
            this.Name = "frmCadProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrotis - Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmCadProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdutos)).EndInit();
            this.grpInformacoesProdutos.ResumeLayout(false);
            this.grpInformacoesProdutos.PerformLayout();
            this.grpInformacoesClientes.ResumeLayout(false);
            this.grpInformacoesClientes.PerformLayout();
            this.mnuCadProdutos.ResumeLayout(false);
            this.mnuCadProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridProdutos;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.GroupBox grpInformacoesProdutos;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.Label lblNomeProdutos;
        private System.Windows.Forms.Label lblCodRegistroCliente;
        private System.Windows.Forms.GroupBox grpInformacoesClientes;
        private System.Windows.Forms.MenuStrip mnuCadProdutos;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrarProdutos;
        private System.Windows.Forms.ToolStripMenuItem btnEditarProdutos;
        private System.Windows.Forms.ToolStripMenuItem btnDeletarProdutos;
        private System.Windows.Forms.ToolStripMenuItem btnSalvarProdutos;
        private System.Windows.Forms.ToolStripMenuItem btnCancelar;
        private System.Windows.Forms.Label lblPrecoProduto;
        private System.Windows.Forms.Label lblPesoProduto;
        private System.Windows.Forms.MaskedTextBox txtMskPrecoProduto;
        private System.Windows.Forms.MaskedTextBox txtMskPesoProduto;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.PictureBox picIconFind;
        private System.Windows.Forms.Label lblKg;
    }
}

