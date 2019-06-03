namespace UML
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblControleGeral = new System.Windows.Forms.Label();
            this.btnControleGeralCliente = new System.Windows.Forms.Button();
            this.btnControleGeralPedido = new System.Windows.Forms.Button();
            this.btnControleGeralFornecedor = new System.Windows.Forms.Button();
            this.btnControleGeralProduto = new System.Windows.Forms.Button();
            this.picControleGeralCliente = new System.Windows.Forms.PictureBox();
            this.picControleGeralFornecedor = new System.Windows.Forms.PictureBox();
            this.picControleGeralProduto = new System.Windows.Forms.PictureBox();
            this.picControleGeralPedido = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picControleGeralCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picControleGeralFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picControleGeralProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picControleGeralPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblControleGeral
            // 
            this.lblControleGeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControleGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControleGeral.Location = new System.Drawing.Point(47, 13);
            this.lblControleGeral.Name = "lblControleGeral";
            this.lblControleGeral.Size = new System.Drawing.Size(710, 40);
            this.lblControleGeral.TabIndex = 74;
            this.lblControleGeral.Text = "Controle Geral";
            this.lblControleGeral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnControleGeralCliente
            // 
            this.btnControleGeralCliente.Location = new System.Drawing.Point(33, 186);
            this.btnControleGeralCliente.Name = "btnControleGeralCliente";
            this.btnControleGeralCliente.Size = new System.Drawing.Size(180, 23);
            this.btnControleGeralCliente.TabIndex = 75;
            this.btnControleGeralCliente.Text = "CADASTRAR CLIENTES";
            this.btnControleGeralCliente.UseVisualStyleBackColor = true;
            this.btnControleGeralCliente.Click += new System.EventHandler(this.btnControleGeralCliente_Click);
            // 
            // btnControleGeralPedido
            // 
            this.btnControleGeralPedido.Location = new System.Drawing.Point(591, 186);
            this.btnControleGeralPedido.Name = "btnControleGeralPedido";
            this.btnControleGeralPedido.Size = new System.Drawing.Size(180, 23);
            this.btnControleGeralPedido.TabIndex = 76;
            this.btnControleGeralPedido.Text = "CADASTRAR PEDIDOS";
            this.btnControleGeralPedido.UseVisualStyleBackColor = true;
            this.btnControleGeralPedido.Click += new System.EventHandler(this.btnControleGeralPedido_Click);
            // 
            // btnControleGeralFornecedor
            // 
            this.btnControleGeralFornecedor.Location = new System.Drawing.Point(219, 186);
            this.btnControleGeralFornecedor.Name = "btnControleGeralFornecedor";
            this.btnControleGeralFornecedor.Size = new System.Drawing.Size(180, 23);
            this.btnControleGeralFornecedor.TabIndex = 77;
            this.btnControleGeralFornecedor.Text = "CADASTRAR FORNECEDOR";
            this.btnControleGeralFornecedor.UseVisualStyleBackColor = true;
            this.btnControleGeralFornecedor.Click += new System.EventHandler(this.btnControleGeralFornecedor_Click);
            // 
            // btnControleGeralProduto
            // 
            this.btnControleGeralProduto.Location = new System.Drawing.Point(405, 186);
            this.btnControleGeralProduto.Name = "btnControleGeralProduto";
            this.btnControleGeralProduto.Size = new System.Drawing.Size(180, 23);
            this.btnControleGeralProduto.TabIndex = 78;
            this.btnControleGeralProduto.Text = "CADASTRAR PRODUTOS";
            this.btnControleGeralProduto.UseVisualStyleBackColor = true;
            this.btnControleGeralProduto.Click += new System.EventHandler(this.btnControleGeralProduto_Click);
            // 
            // picControleGeralCliente
            // 
            this.picControleGeralCliente.Image = global::UML.Properties.Resources.cliente;
            this.picControleGeralCliente.Location = new System.Drawing.Point(77, 80);
            this.picControleGeralCliente.Name = "picControleGeralCliente";
            this.picControleGeralCliente.Size = new System.Drawing.Size(100, 100);
            this.picControleGeralCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picControleGeralCliente.TabIndex = 79;
            this.picControleGeralCliente.TabStop = false;
            // 
            // picControleGeralFornecedor
            // 
            this.picControleGeralFornecedor.Image = global::UML.Properties.Resources.fornecedor;
            this.picControleGeralFornecedor.Location = new System.Drawing.Point(259, 80);
            this.picControleGeralFornecedor.Name = "picControleGeralFornecedor";
            this.picControleGeralFornecedor.Size = new System.Drawing.Size(100, 100);
            this.picControleGeralFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picControleGeralFornecedor.TabIndex = 80;
            this.picControleGeralFornecedor.TabStop = false;
            // 
            // picControleGeralProduto
            // 
            this.picControleGeralProduto.Image = global::UML.Properties.Resources.produto;
            this.picControleGeralProduto.Location = new System.Drawing.Point(440, 80);
            this.picControleGeralProduto.Name = "picControleGeralProduto";
            this.picControleGeralProduto.Size = new System.Drawing.Size(100, 100);
            this.picControleGeralProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picControleGeralProduto.TabIndex = 81;
            this.picControleGeralProduto.TabStop = false;
            // 
            // picControleGeralPedido
            // 
            this.picControleGeralPedido.Image = global::UML.Properties.Resources.pedido;
            this.picControleGeralPedido.Location = new System.Drawing.Point(629, 80);
            this.picControleGeralPedido.Name = "picControleGeralPedido";
            this.picControleGeralPedido.Size = new System.Drawing.Size(100, 100);
            this.picControleGeralPedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picControleGeralPedido.TabIndex = 82;
            this.picControleGeralPedido.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 482);
            this.Controls.Add(this.picControleGeralPedido);
            this.Controls.Add(this.picControleGeralProduto);
            this.Controls.Add(this.picControleGeralFornecedor);
            this.Controls.Add(this.picControleGeralCliente);
            this.Controls.Add(this.btnControleGeralProduto);
            this.Controls.Add(this.btnControleGeralFornecedor);
            this.Controls.Add(this.btnControleGeralPedido);
            this.Controls.Add(this.btnControleGeralCliente);
            this.Controls.Add(this.lblControleGeral);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picControleGeralCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picControleGeralFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picControleGeralProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picControleGeralPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblControleGeral;
        private System.Windows.Forms.Button btnControleGeralCliente;
        private System.Windows.Forms.Button btnControleGeralPedido;
        private System.Windows.Forms.Button btnControleGeralFornecedor;
        private System.Windows.Forms.Button btnControleGeralProduto;
        private System.Windows.Forms.PictureBox picControleGeralCliente;
        private System.Windows.Forms.PictureBox picControleGeralFornecedor;
        private System.Windows.Forms.PictureBox picControleGeralProduto;
        private System.Windows.Forms.PictureBox picControleGeralPedido;
    }
}

