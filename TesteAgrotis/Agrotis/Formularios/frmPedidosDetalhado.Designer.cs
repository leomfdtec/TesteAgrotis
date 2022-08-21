namespace Agrotis
{
    partial class frmPedidosDetalhado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidosDetalhado));
            this.dtGridProdutos = new System.Windows.Forms.DataGridView();
            this.txtCodPedido = new System.Windows.Forms.TextBox();
            this.lblDatEmissao = new System.Windows.Forms.Label();
            this.lblCodRegistroCliente = new System.Windows.Forms.Label();
            this.grpInformacoesClientes = new System.Windows.Forms.GroupBox();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.lblPesoTotalPedido = new System.Windows.Forms.Label();
            this.txtPesoTotalPedido = new System.Windows.Forms.TextBox();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.txtPrecoTotalPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtMskDatEmissao = new System.Windows.Forms.MaskedTextBox();
            this.mnuCadProdutos = new System.Windows.Forms.MenuStrip();
            this.btnCadastrarPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditarPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalvarPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscarProdutos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdutos)).BeginInit();
            this.grpInformacoesClientes.SuspendLayout();
            this.mnuCadProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridProdutos
            // 
            this.dtGridProdutos.AllowUserToAddRows = false;
            this.dtGridProdutos.AllowUserToDeleteRows = false;
            this.dtGridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGridProdutos.Location = new System.Drawing.Point(15, 201);
            this.dtGridProdutos.Name = "dtGridProdutos";
            this.dtGridProdutos.ReadOnly = true;
            this.dtGridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridProdutos.Size = new System.Drawing.Size(785, 375);
            this.dtGridProdutos.TabIndex = 3;
            this.dtGridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProdutos_CellClick);
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.Location = new System.Drawing.Point(9, 32);
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.ReadOnly = true;
            this.txtCodPedido.Size = new System.Drawing.Size(79, 20);
            this.txtCodPedido.TabIndex = 0;
            this.txtCodPedido.TabStop = false;
            // 
            // lblDatEmissao
            // 
            this.lblDatEmissao.AutoSize = true;
            this.lblDatEmissao.Location = new System.Drawing.Point(91, 15);
            this.lblDatEmissao.Name = "lblDatEmissao";
            this.lblDatEmissao.Size = new System.Drawing.Size(90, 13);
            this.lblDatEmissao.TabIndex = 22;
            this.lblDatEmissao.Text = "Data de Emissão:";
            // 
            // lblCodRegistroCliente
            // 
            this.lblCodRegistroCliente.AutoSize = true;
            this.lblCodRegistroCliente.Location = new System.Drawing.Point(9, 16);
            this.lblCodRegistroCliente.Name = "lblCodRegistroCliente";
            this.lblCodRegistroCliente.Size = new System.Drawing.Size(79, 13);
            this.lblCodRegistroCliente.TabIndex = 23;
            this.lblCodRegistroCliente.Text = "Código Pedido:";
            // 
            // grpInformacoesClientes
            // 
            this.grpInformacoesClientes.Controls.Add(this.lblDescricaoProduto);
            this.grpInformacoesClientes.Controls.Add(this.txtDescricaoProduto);
            this.grpInformacoesClientes.Controls.Add(this.lblPesoTotalPedido);
            this.grpInformacoesClientes.Controls.Add(this.txtPesoTotalPedido);
            this.grpInformacoesClientes.Controls.Add(this.lblPrecoTotal);
            this.grpInformacoesClientes.Controls.Add(this.txtPrecoTotalPedido);
            this.grpInformacoesClientes.Controls.Add(this.label1);
            this.grpInformacoesClientes.Controls.Add(this.txtNomeCliente);
            this.grpInformacoesClientes.Controls.Add(this.lblCodCliente);
            this.grpInformacoesClientes.Controls.Add(this.txtCodCliente);
            this.grpInformacoesClientes.Controls.Add(this.txtMskDatEmissao);
            this.grpInformacoesClientes.Controls.Add(this.lblCodRegistroCliente);
            this.grpInformacoesClientes.Controls.Add(this.txtCodPedido);
            this.grpInformacoesClientes.Controls.Add(this.lblDatEmissao);
            this.grpInformacoesClientes.Location = new System.Drawing.Point(15, 28);
            this.grpInformacoesClientes.Name = "grpInformacoesClientes";
            this.grpInformacoesClientes.Size = new System.Drawing.Size(785, 147);
            this.grpInformacoesClientes.TabIndex = 25;
            this.grpInformacoesClientes.TabStop = false;
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(9, 59);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoProduto.TabIndex = 37;
            this.lblDescricaoProduto.Text = "Descrição:";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(9, 75);
            this.txtDescricaoProduto.Multiline = true;
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.ReadOnly = true;
            this.txtDescricaoProduto.Size = new System.Drawing.Size(762, 66);
            this.txtDescricaoProduto.TabIndex = 36;
            this.txtDescricaoProduto.TabStop = false;
            // 
            // lblPesoTotalPedido
            // 
            this.lblPesoTotalPedido.AutoSize = true;
            this.lblPesoTotalPedido.Location = new System.Drawing.Point(689, 15);
            this.lblPesoTotalPedido.Name = "lblPesoTotalPedido";
            this.lblPesoTotalPedido.Size = new System.Drawing.Size(61, 13);
            this.lblPesoTotalPedido.TabIndex = 35;
            this.lblPesoTotalPedido.Text = "Peso Total:";
            // 
            // txtPesoTotalPedido
            // 
            this.txtPesoTotalPedido.Location = new System.Drawing.Point(692, 32);
            this.txtPesoTotalPedido.Name = "txtPesoTotalPedido";
            this.txtPesoTotalPedido.ReadOnly = true;
            this.txtPesoTotalPedido.Size = new System.Drawing.Size(79, 20);
            this.txtPesoTotalPedido.TabIndex = 34;
            this.txtPesoTotalPedido.TabStop = false;
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Location = new System.Drawing.Point(607, 16);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(65, 13);
            this.lblPrecoTotal.TabIndex = 33;
            this.lblPrecoTotal.Text = "Preço Total:";
            // 
            // txtPrecoTotalPedido
            // 
            this.txtPrecoTotalPedido.Location = new System.Drawing.Point(607, 32);
            this.txtPrecoTotalPedido.Name = "txtPrecoTotalPedido";
            this.txtPrecoTotalPedido.ReadOnly = true;
            this.txtPrecoTotalPedido.Size = new System.Drawing.Size(79, 20);
            this.txtPrecoTotalPedido.TabIndex = 32;
            this.txtPrecoTotalPedido.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nome Cliente:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(273, 32);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(324, 20);
            this.txtNomeCliente.TabIndex = 30;
            this.txtNomeCliente.TabStop = false;
            this.txtNomeCliente.DoubleClick += new System.EventHandler(this.txtBuscarCliente_DoubleClick);
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(188, 16);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(78, 13);
            this.lblCodCliente.TabIndex = 28;
            this.lblCodCliente.Text = "Código Cliente:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(188, 32);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.ReadOnly = true;
            this.txtCodCliente.Size = new System.Drawing.Size(79, 20);
            this.txtCodCliente.TabIndex = 26;
            this.txtCodCliente.TabStop = false;
            this.txtCodCliente.DoubleClick += new System.EventHandler(this.txtBuscarCliente_DoubleClick);
            // 
            // txtMskDatEmissao
            // 
            this.txtMskDatEmissao.Location = new System.Drawing.Point(94, 32);
            this.txtMskDatEmissao.Mask = "00/00/0000";
            this.txtMskDatEmissao.Name = "txtMskDatEmissao";
            this.txtMskDatEmissao.ReadOnly = true;
            this.txtMskDatEmissao.Size = new System.Drawing.Size(87, 20);
            this.txtMskDatEmissao.TabIndex = 24;
            this.txtMskDatEmissao.ValidatingType = typeof(System.DateTime);
            // 
            // mnuCadProdutos
            // 
            this.mnuCadProdutos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrarPedidos,
            this.btnEditarPedidos,
            this.btnSalvarPedidos,
            this.btnCancelar});
            this.mnuCadProdutos.Location = new System.Drawing.Point(0, 0);
            this.mnuCadProdutos.Name = "mnuCadProdutos";
            this.mnuCadProdutos.Size = new System.Drawing.Size(813, 24);
            this.mnuCadProdutos.TabIndex = 28;
            this.mnuCadProdutos.Text = "menuStrip1";
            // 
            // btnCadastrarPedidos
            // 
            this.btnCadastrarPedidos.Image = global::Agrotis.Properties.Resources.Add;
            this.btnCadastrarPedidos.Name = "btnCadastrarPedidos";
            this.btnCadastrarPedidos.Size = new System.Drawing.Size(64, 20);
            this.btnCadastrarPedidos.Text = "Novo";
            this.btnCadastrarPedidos.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnEditarPedidos
            // 
            this.btnEditarPedidos.Image = global::Agrotis.Properties.Resources.Edit;
            this.btnEditarPedidos.Name = "btnEditarPedidos";
            this.btnEditarPedidos.Size = new System.Drawing.Size(65, 20);
            this.btnEditarPedidos.Text = "Editar";
            this.btnEditarPedidos.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvarPedidos
            // 
            this.btnSalvarPedidos.Image = global::Agrotis.Properties.Resources.Acc;
            this.btnSalvarPedidos.Name = "btnSalvarPedidos";
            this.btnSalvarPedidos.Size = new System.Drawing.Size(66, 20);
            this.btnSalvarPedidos.Text = "Salvar";
            this.btnSalvarPedidos.Visible = false;
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
            // btnBuscarProdutos
            // 
            this.btnBuscarProdutos.Image = global::Agrotis.Properties.Resources.Add;
            this.btnBuscarProdutos.Location = new System.Drawing.Point(14, 176);
            this.btnBuscarProdutos.Name = "btnBuscarProdutos";
            this.btnBuscarProdutos.Size = new System.Drawing.Size(24, 24);
            this.btnBuscarProdutos.TabIndex = 29;
            this.btnBuscarProdutos.UseVisualStyleBackColor = true;
            this.btnBuscarProdutos.Visible = false;
            this.btnBuscarProdutos.Click += new System.EventHandler(this.btnBuscarProdutos_Click);
            // 
            // frmPedidosDetalhado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 588);
            this.Controls.Add(this.btnBuscarProdutos);
            this.Controls.Add(this.grpInformacoesClientes);
            this.Controls.Add(this.dtGridProdutos);
            this.Controls.Add(this.mnuCadProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuCadProdutos;
            this.MaximizeBox = false;
            this.Name = "frmPedidosDetalhado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrotis - Cadastro de Pedidos Detalhado";
            this.Load += new System.EventHandler(this.frmCadProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdutos)).EndInit();
            this.grpInformacoesClientes.ResumeLayout(false);
            this.grpInformacoesClientes.PerformLayout();
            this.mnuCadProdutos.ResumeLayout(false);
            this.mnuCadProdutos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridProdutos;
        private System.Windows.Forms.TextBox txtCodPedido;
        private System.Windows.Forms.Label lblDatEmissao;
        private System.Windows.Forms.Label lblCodRegistroCliente;
        private System.Windows.Forms.GroupBox grpInformacoesClientes;
        private System.Windows.Forms.MenuStrip mnuCadProdutos;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrarPedidos;
        private System.Windows.Forms.ToolStripMenuItem btnEditarPedidos;
        private System.Windows.Forms.ToolStripMenuItem btnSalvarPedidos;
        private System.Windows.Forms.ToolStripMenuItem btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.MaskedTextBox txtMskDatEmissao;
        private System.Windows.Forms.Label lblPesoTotalPedido;
        private System.Windows.Forms.TextBox txtPesoTotalPedido;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.TextBox txtPrecoTotalPedido;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Button btnBuscarProdutos;
    }
}

