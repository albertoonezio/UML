namespace UML
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.btnProdutoCriar = new System.Windows.Forms.Button();
            this.btnProdutoDeletar = new System.Windows.Forms.Button();
            this.btnProdutoEditar = new System.Windows.Forms.Button();
            this.btnProdutoSalvar = new System.Windows.Forms.Button();
            this.lblProdutoID = new System.Windows.Forms.Label();
            this.nudProdutoID = new System.Windows.Forms.NumericUpDown();
            this.lblProdutoNome = new System.Windows.Forms.Label();
            this.txtProdutoNome = new System.Windows.Forms.TextBox();
            this.lblCadastroProduto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPedidoValorUnidade = new System.Windows.Forms.TextBox();
            this.lblPedidoValorUnidade = new System.Windows.Forms.Label();
            this.txtPedidoStatusPedido = new System.Windows.Forms.TextBox();
            this.lblPedidoStatusPedido = new System.Windows.Forms.Label();
            this.lblPedidoDataElaboracao = new System.Windows.Forms.Label();
            this.nudPedidoQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblPedidoQuantidade = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblProdutoBanco = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORNECEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_UNIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_ADICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS_ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProdutoBancoSituacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdutoID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPedidoQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProdutoCriar
            // 
            this.btnProdutoCriar.Location = new System.Drawing.Point(475, 451);
            this.btnProdutoCriar.Name = "btnProdutoCriar";
            this.btnProdutoCriar.Size = new System.Drawing.Size(75, 23);
            this.btnProdutoCriar.TabIndex = 81;
            this.btnProdutoCriar.Text = "CRIAR";
            this.btnProdutoCriar.UseVisualStyleBackColor = true;
            // 
            // btnProdutoDeletar
            // 
            this.btnProdutoDeletar.Location = new System.Drawing.Point(716, 451);
            this.btnProdutoDeletar.Name = "btnProdutoDeletar";
            this.btnProdutoDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnProdutoDeletar.TabIndex = 80;
            this.btnProdutoDeletar.Text = "DELETAR";
            this.btnProdutoDeletar.UseVisualStyleBackColor = true;
            // 
            // btnProdutoEditar
            // 
            this.btnProdutoEditar.Location = new System.Drawing.Point(636, 451);
            this.btnProdutoEditar.Name = "btnProdutoEditar";
            this.btnProdutoEditar.Size = new System.Drawing.Size(75, 23);
            this.btnProdutoEditar.TabIndex = 79;
            this.btnProdutoEditar.Text = "EDITAR";
            this.btnProdutoEditar.UseVisualStyleBackColor = true;
            // 
            // btnProdutoSalvar
            // 
            this.btnProdutoSalvar.Location = new System.Drawing.Point(556, 451);
            this.btnProdutoSalvar.Name = "btnProdutoSalvar";
            this.btnProdutoSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnProdutoSalvar.TabIndex = 78;
            this.btnProdutoSalvar.Text = "SALVAR";
            this.btnProdutoSalvar.UseVisualStyleBackColor = true;
            // 
            // lblProdutoID
            // 
            this.lblProdutoID.AutoSize = true;
            this.lblProdutoID.Location = new System.Drawing.Point(48, 94);
            this.lblProdutoID.Name = "lblProdutoID";
            this.lblProdutoID.Size = new System.Drawing.Size(21, 13);
            this.lblProdutoID.TabIndex = 77;
            this.lblProdutoID.Text = "ID:";
            // 
            // nudProdutoID
            // 
            this.nudProdutoID.Location = new System.Drawing.Point(71, 87);
            this.nudProdutoID.Name = "nudProdutoID";
            this.nudProdutoID.ReadOnly = true;
            this.nudProdutoID.Size = new System.Drawing.Size(75, 20);
            this.nudProdutoID.TabIndex = 76;
            // 
            // lblProdutoNome
            // 
            this.lblProdutoNome.AutoSize = true;
            this.lblProdutoNome.Location = new System.Drawing.Point(45, 126);
            this.lblProdutoNome.Name = "lblProdutoNome";
            this.lblProdutoNome.Size = new System.Drawing.Size(42, 13);
            this.lblProdutoNome.TabIndex = 75;
            this.lblProdutoNome.Text = "NOME:";
            // 
            // txtProdutoNome
            // 
            this.txtProdutoNome.Location = new System.Drawing.Point(88, 120);
            this.txtProdutoNome.Name = "txtProdutoNome";
            this.txtProdutoNome.Size = new System.Drawing.Size(460, 20);
            this.txtProdutoNome.TabIndex = 74;
            // 
            // lblCadastroProduto
            // 
            this.lblCadastroProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroProduto.Location = new System.Drawing.Point(45, 28);
            this.lblCadastroProduto.Name = "lblCadastroProduto";
            this.lblCadastroProduto.Size = new System.Drawing.Size(710, 40);
            this.lblCadastroProduto.TabIndex = 73;
            this.lblCadastroProduto.Text = "Cadastro Produto";
            this.lblCadastroProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "FORNECEDOR:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 20);
            this.textBox1.TabIndex = 82;
            // 
            // txtPedidoValorUnidade
            // 
            this.txtPedidoValorUnidade.Location = new System.Drawing.Point(686, 218);
            this.txtPedidoValorUnidade.Name = "txtPedidoValorUnidade";
            this.txtPedidoValorUnidade.Size = new System.Drawing.Size(107, 20);
            this.txtPedidoValorUnidade.TabIndex = 97;
            this.txtPedidoValorUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPedidoValorUnidade
            // 
            this.lblPedidoValorUnidade.AutoSize = true;
            this.lblPedidoValorUnidade.Location = new System.Drawing.Point(561, 225);
            this.lblPedidoValorUnidade.Name = "lblPedidoValorUnidade";
            this.lblPedidoValorUnidade.Size = new System.Drawing.Size(124, 13);
            this.lblPedidoValorUnidade.TabIndex = 96;
            this.lblPedidoValorUnidade.Text = "VALOR POR UNIDADE:";
            // 
            // txtPedidoStatusPedido
            // 
            this.txtPedidoStatusPedido.Location = new System.Drawing.Point(300, 454);
            this.txtPedidoStatusPedido.Name = "txtPedidoStatusPedido";
            this.txtPedidoStatusPedido.ReadOnly = true;
            this.txtPedidoStatusPedido.Size = new System.Drawing.Size(140, 20);
            this.txtPedidoStatusPedido.TabIndex = 95;
            this.txtPedidoStatusPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPedidoStatusPedido
            // 
            this.lblPedidoStatusPedido.AutoSize = true;
            this.lblPedidoStatusPedido.Location = new System.Drawing.Point(191, 461);
            this.lblPedidoStatusPedido.Name = "lblPedidoStatusPedido";
            this.lblPedidoStatusPedido.Size = new System.Drawing.Size(108, 13);
            this.lblPedidoStatusPedido.TabIndex = 94;
            this.lblPedidoStatusPedido.Text = "STATUS ESTOQUE:";
            // 
            // lblPedidoDataElaboracao
            // 
            this.lblPedidoDataElaboracao.AutoSize = true;
            this.lblPedidoDataElaboracao.Location = new System.Drawing.Point(603, 94);
            this.lblPedidoDataElaboracao.Name = "lblPedidoDataElaboracao";
            this.lblPedidoDataElaboracao.Size = new System.Drawing.Size(82, 13);
            this.lblPedidoDataElaboracao.TabIndex = 93;
            this.lblPedidoDataElaboracao.Text = "DATA ADIÇÃO:";
            // 
            // nudPedidoQuantidade
            // 
            this.nudPedidoQuantidade.Location = new System.Drawing.Point(97, 454);
            this.nudPedidoQuantidade.Name = "nudPedidoQuantidade";
            this.nudPedidoQuantidade.Size = new System.Drawing.Size(84, 20);
            this.nudPedidoQuantidade.TabIndex = 92;
            // 
            // lblPedidoQuantidade
            // 
            this.lblPedidoQuantidade.AutoSize = true;
            this.lblPedidoQuantidade.Location = new System.Drawing.Point(14, 461);
            this.lblPedidoQuantidade.Name = "lblPedidoQuantidade";
            this.lblPedidoQuantidade.Size = new System.Drawing.Size(81, 13);
            this.lblPedidoQuantidade.TabIndex = 91;
            this.lblPedidoQuantidade.Text = "QUANTIDADE:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(688, 87);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(72, 20);
            this.maskedTextBox1.TabIndex = 90;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // lblProdutoBanco
            // 
            this.lblProdutoBanco.AutoSize = true;
            this.lblProdutoBanco.Location = new System.Drawing.Point(676, 8);
            this.lblProdutoBanco.Name = "lblProdutoBanco";
            this.lblProdutoBanco.Size = new System.Drawing.Size(47, 13);
            this.lblProdutoBanco.TabIndex = 98;
            this.lblProdutoBanco.Text = "BANCO:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.FORNECEDOR,
            this.QUANTIDADE,
            this.VALOR_UNIDADE,
            this.DATA_ADICAO,
            this.STATUS_ESTOQUE});
            this.dataGridView1.Location = new System.Drawing.Point(17, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 201);
            this.dataGridView1.TabIndex = 99;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 30;
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.Width = 200;
            // 
            // FORNECEDOR
            // 
            this.FORNECEDOR.HeaderText = "FORNECEDOR";
            this.FORNECEDOR.Name = "FORNECEDOR";
            this.FORNECEDOR.Width = 200;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.Width = 50;
            // 
            // VALOR_UNIDADE
            // 
            this.VALOR_UNIDADE.HeaderText = "VALOR UNIDADE";
            this.VALOR_UNIDADE.Name = "VALOR_UNIDADE";
            this.VALOR_UNIDADE.Width = 70;
            // 
            // DATA_ADICAO
            // 
            this.DATA_ADICAO.HeaderText = "DATA ADIÇÃO";
            this.DATA_ADICAO.Name = "DATA_ADICAO";
            this.DATA_ADICAO.Width = 50;
            // 
            // STATUS_ESTOQUE
            // 
            this.STATUS_ESTOQUE.HeaderText = "STATUS ESTOQUE";
            this.STATUS_ESTOQUE.Name = "STATUS_ESTOQUE";
            this.STATUS_ESTOQUE.Width = 80;
            // 
            // lblProdutoBancoSituacao
            // 
            this.lblProdutoBancoSituacao.AutoSize = true;
            this.lblProdutoBancoSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoBancoSituacao.ForeColor = System.Drawing.Color.Red;
            this.lblProdutoBancoSituacao.Location = new System.Drawing.Point(725, 8);
            this.lblProdutoBancoSituacao.Name = "lblProdutoBancoSituacao";
            this.lblProdutoBancoSituacao.Size = new System.Drawing.Size(58, 13);
            this.lblProdutoBancoSituacao.TabIndex = 100;
            this.lblProdutoBancoSituacao.Text = "OFFLINE";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 482);
            this.Controls.Add(this.lblProdutoBancoSituacao);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblProdutoBanco);
            this.Controls.Add(this.txtPedidoValorUnidade);
            this.Controls.Add(this.lblPedidoValorUnidade);
            this.Controls.Add(this.txtPedidoStatusPedido);
            this.Controls.Add(this.lblPedidoStatusPedido);
            this.Controls.Add(this.lblPedidoDataElaboracao);
            this.Controls.Add(this.nudPedidoQuantidade);
            this.Controls.Add(this.lblPedidoQuantidade);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnProdutoCriar);
            this.Controls.Add(this.btnProdutoDeletar);
            this.Controls.Add(this.btnProdutoEditar);
            this.Controls.Add(this.btnProdutoSalvar);
            this.Controls.Add(this.lblProdutoID);
            this.Controls.Add(this.nudProdutoID);
            this.Controls.Add(this.lblProdutoNome);
            this.Controls.Add(this.txtProdutoNome);
            this.Controls.Add(this.lblCadastroProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduto";
            ((System.ComponentModel.ISupportInitialize)(this.nudProdutoID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPedidoQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProdutoCriar;
        private System.Windows.Forms.Button btnProdutoDeletar;
        private System.Windows.Forms.Button btnProdutoEditar;
        private System.Windows.Forms.Button btnProdutoSalvar;
        private System.Windows.Forms.Label lblProdutoID;
        private System.Windows.Forms.NumericUpDown nudProdutoID;
        private System.Windows.Forms.Label lblProdutoNome;
        private System.Windows.Forms.TextBox txtProdutoNome;
        private System.Windows.Forms.Label lblCadastroProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPedidoValorUnidade;
        private System.Windows.Forms.Label lblPedidoValorUnidade;
        private System.Windows.Forms.TextBox txtPedidoStatusPedido;
        private System.Windows.Forms.Label lblPedidoStatusPedido;
        private System.Windows.Forms.Label lblPedidoDataElaboracao;
        private System.Windows.Forms.NumericUpDown nudPedidoQuantidade;
        private System.Windows.Forms.Label lblPedidoQuantidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblProdutoBanco;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORNECEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_UNIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_ADICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS_ESTOQUE;
        private System.Windows.Forms.Label lblProdutoBancoSituacao;
    }
}