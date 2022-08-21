namespace Agrotis
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnCadProdutos = new System.Windows.Forms.Button();
            this.btnCadClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPedidos
            // 
            this.btnPedidos.Image = global::Agrotis.Properties.Resources.Caixa;
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Location = new System.Drawing.Point(68, 224);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(170, 59);
            this.btnPedidos.TabIndex = 2;
            this.btnPedidos.Text = "          Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnCadProdutos
            // 
            this.btnCadProdutos.Image = global::Agrotis.Properties.Resources.Produto;
            this.btnCadProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadProdutos.Location = new System.Drawing.Point(68, 133);
            this.btnCadProdutos.Name = "btnCadProdutos";
            this.btnCadProdutos.Size = new System.Drawing.Size(170, 59);
            this.btnCadProdutos.TabIndex = 1;
            this.btnCadProdutos.Text = "Cadastrar Produtos";
            this.btnCadProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadProdutos.UseVisualStyleBackColor = true;
            this.btnCadProdutos.Click += new System.EventHandler(this.btnCadProdutos_Click);
            // 
            // btnCadClientes
            // 
            this.btnCadClientes.Image = global::Agrotis.Properties.Resources.NovoUser;
            this.btnCadClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadClientes.Location = new System.Drawing.Point(68, 41);
            this.btnCadClientes.Name = "btnCadClientes";
            this.btnCadClientes.Size = new System.Drawing.Size(170, 59);
            this.btnCadClientes.TabIndex = 0;
            this.btnCadClientes.Text = "Cadastrar Clientes";
            this.btnCadClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadClientes.UseVisualStyleBackColor = true;
            this.btnCadClientes.Click += new System.EventHandler(this.btnCadClientes_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 309);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnCadProdutos);
            this.Controls.Add(this.btnCadClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrotis - Sistema de Controle de Vendas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadClientes;
        private System.Windows.Forms.Button btnCadProdutos;
        private System.Windows.Forms.Button btnPedidos;
    }
}