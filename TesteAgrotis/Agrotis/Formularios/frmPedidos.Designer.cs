namespace Agrotis
{
    partial class frmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidos));
            this.dtGridPedidos = new System.Windows.Forms.DataGridView();
            this.mnuCadProdutos = new System.Windows.Forms.MenuStrip();
            this.btnCadastrarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeletarPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPedidos)).BeginInit();
            this.mnuCadProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridPedidos
            // 
            this.dtGridPedidos.AllowUserToAddRows = false;
            this.dtGridPedidos.AllowUserToDeleteRows = false;
            this.dtGridPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridPedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGridPedidos.Location = new System.Drawing.Point(15, 49);
            this.dtGridPedidos.Name = "dtGridPedidos";
            this.dtGridPedidos.ReadOnly = true;
            this.dtGridPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridPedidos.Size = new System.Drawing.Size(658, 527);
            this.dtGridPedidos.TabIndex = 3;
            this.dtGridPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridPedidos_CellDoubleClick);
            // 
            // mnuCadProdutos
            // 
            this.mnuCadProdutos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrarPedido,
            this.btnEditarPedido,
            this.btnDeletarPedidos});
            this.mnuCadProdutos.Location = new System.Drawing.Point(0, 0);
            this.mnuCadProdutos.Name = "mnuCadProdutos";
            this.mnuCadProdutos.Size = new System.Drawing.Size(685, 24);
            this.mnuCadProdutos.TabIndex = 28;
            this.mnuCadProdutos.Text = "menuStrip1";
            // 
            // btnCadastrarPedido
            // 
            this.btnCadastrarPedido.Image = global::Agrotis.Properties.Resources.Add;
            this.btnCadastrarPedido.Name = "btnCadastrarPedido";
            this.btnCadastrarPedido.Size = new System.Drawing.Size(64, 20);
            this.btnCadastrarPedido.Text = "Novo";
            this.btnCadastrarPedido.Click += new System.EventHandler(this.btnCadastrarPedido_Click);
            // 
            // btnEditarPedido
            // 
            this.btnEditarPedido.Image = global::Agrotis.Properties.Resources.Edit;
            this.btnEditarPedido.Name = "btnEditarPedido";
            this.btnEditarPedido.Size = new System.Drawing.Size(65, 20);
            this.btnEditarPedido.Text = "Editar";
            this.btnEditarPedido.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletarPedidos
            // 
            this.btnDeletarPedidos.Image = global::Agrotis.Properties.Resources.Delete;
            this.btnDeletarPedidos.Name = "btnDeletarPedidos";
            this.btnDeletarPedidos.Size = new System.Drawing.Size(72, 20);
            this.btnDeletarPedidos.Text = "Deletar";
            this.btnDeletarPedidos.Click += new System.EventHandler(this.btnDeletarPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Clique duas vezes sobre o item para ver o pedido detalhado.";
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridPedidos);
            this.Controls.Add(this.mnuCadProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuCadProdutos;
            this.MaximizeBox = false;
            this.Name = "frmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrotis - Cadastro de Pedidos";
            this.Load += new System.EventHandler(this.frmCadPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPedidos)).EndInit();
            this.mnuCadProdutos.ResumeLayout(false);
            this.mnuCadProdutos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridPedidos;
        private System.Windows.Forms.MenuStrip mnuCadProdutos;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrarPedido;
        private System.Windows.Forms.ToolStripMenuItem btnDeletarPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem btnEditarPedido;
    }
}

