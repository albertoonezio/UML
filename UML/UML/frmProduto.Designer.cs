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
            this.lblProdutoFornecedor = new System.Windows.Forms.Label();
            this.txtProdutoFornecedor = new System.Windows.Forms.TextBox();
            this.txtProdutoValorUnidade = new System.Windows.Forms.TextBox();
            this.lblProdutoValorUnidade = new System.Windows.Forms.Label();
            this.lblProdutoStatusPedido = new System.Windows.Forms.Label();
            this.lblProdutoDataFabricacao = new System.Windows.Forms.Label();
            this.nudProdutoQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblProdutoQuantidade = new System.Windows.Forms.Label();
            this.mtbProdutoDataFabricacao = new System.Windows.Forms.MaskedTextBox();
            this.lblProdutoBanco = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORNECEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_UNIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_ADICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS_ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProdutoBancoSituacao = new System.Windows.Forms.Label();
            this.lblProdutoDataVencimento = new System.Windows.Forms.Label();
            this.mtbProdutoDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.lblProdutoDataAdicao = new System.Windows.Forms.Label();
            this.mtbProdutoDataAdicao = new System.Windows.Forms.MaskedTextBox();
            this.cboProdutoStatus = new System.Windows.Forms.ComboBox();
            this.lblProdutoCategoria = new System.Windows.Forms.Label();
            this.cboProdutoCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdutoID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdutoQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
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
            this.btnProdutoCriar.Click += new System.EventHandler(this.btnProdutoCriar_Click);
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
            this.btnProdutoSalvar.Click += new System.EventHandler(this.btnProdutoSalvar_Click);
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
            // lblProdutoFornecedor
            // 
            this.lblProdutoFornecedor.AutoSize = true;
            this.lblProdutoFornecedor.Location = new System.Drawing.Point(45, 159);
            this.lblProdutoFornecedor.Name = "lblProdutoFornecedor";
            this.lblProdutoFornecedor.Size = new System.Drawing.Size(85, 13);
            this.lblProdutoFornecedor.TabIndex = 83;
            this.lblProdutoFornecedor.Text = "FORNECEDOR:";
            // 
            // txtProdutoFornecedor
            // 
            this.txtProdutoFornecedor.Location = new System.Drawing.Point(134, 152);
            this.txtProdutoFornecedor.Name = "txtProdutoFornecedor";
            this.txtProdutoFornecedor.Size = new System.Drawing.Size(460, 20);
            this.txtProdutoFornecedor.TabIndex = 82;
            // 
            // txtProdutoValorUnidade
            // 
            this.txtProdutoValorUnidade.Location = new System.Drawing.Point(686, 218);
            this.txtProdutoValorUnidade.Name = "txtProdutoValorUnidade";
            this.txtProdutoValorUnidade.Size = new System.Drawing.Size(107, 20);
            this.txtProdutoValorUnidade.TabIndex = 97;
            this.txtProdutoValorUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProdutoValorUnidade
            // 
            this.lblProdutoValorUnidade.AutoSize = true;
            this.lblProdutoValorUnidade.Location = new System.Drawing.Point(561, 225);
            this.lblProdutoValorUnidade.Name = "lblProdutoValorUnidade";
            this.lblProdutoValorUnidade.Size = new System.Drawing.Size(124, 13);
            this.lblProdutoValorUnidade.TabIndex = 96;
            this.lblProdutoValorUnidade.Text = "VALOR POR UNIDADE:";
            // 
            // lblProdutoStatusPedido
            // 
            this.lblProdutoStatusPedido.AutoSize = true;
            this.lblProdutoStatusPedido.Location = new System.Drawing.Point(191, 461);
            this.lblProdutoStatusPedido.Name = "lblProdutoStatusPedido";
            this.lblProdutoStatusPedido.Size = new System.Drawing.Size(108, 13);
            this.lblProdutoStatusPedido.TabIndex = 94;
            this.lblProdutoStatusPedido.Text = "STATUS ESTOQUE:";
            // 
            // lblProdutoDataFabricacao
            // 
            this.lblProdutoDataFabricacao.AutoSize = true;
            this.lblProdutoDataFabricacao.Location = new System.Drawing.Point(576, 94);
            this.lblProdutoDataFabricacao.Name = "lblProdutoDataFabricacao";
            this.lblProdutoDataFabricacao.Size = new System.Drawing.Size(109, 13);
            this.lblProdutoDataFabricacao.TabIndex = 93;
            this.lblProdutoDataFabricacao.Text = "DATA FABRICAÇÃO:";
            // 
            // nudProdutoQuantidade
            // 
            this.nudProdutoQuantidade.Location = new System.Drawing.Point(97, 454);
            this.nudProdutoQuantidade.Name = "nudProdutoQuantidade";
            this.nudProdutoQuantidade.Size = new System.Drawing.Size(84, 20);
            this.nudProdutoQuantidade.TabIndex = 92;
            // 
            // lblProdutoQuantidade
            // 
            this.lblProdutoQuantidade.AutoSize = true;
            this.lblProdutoQuantidade.Location = new System.Drawing.Point(14, 461);
            this.lblProdutoQuantidade.Name = "lblProdutoQuantidade";
            this.lblProdutoQuantidade.Size = new System.Drawing.Size(81, 13);
            this.lblProdutoQuantidade.TabIndex = 91;
            this.lblProdutoQuantidade.Text = "QUANTIDADE:";
            // 
            // mtbProdutoDataFabricacao
            // 
            this.mtbProdutoDataFabricacao.Location = new System.Drawing.Point(688, 87);
            this.mtbProdutoDataFabricacao.Mask = "00/00/0000";
            this.mtbProdutoDataFabricacao.Name = "mtbProdutoDataFabricacao";
            this.mtbProdutoDataFabricacao.Size = new System.Drawing.Size(72, 20);
            this.mtbProdutoDataFabricacao.TabIndex = 90;
            this.mtbProdutoDataFabricacao.ValidatingType = typeof(System.DateTime);
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
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.FORNECEDOR,
            this.QUANTIDADE,
            this.VALOR_UNIDADE,
            this.DATA_ADICAO,
            this.STATUS_ESTOQUE});
            this.dgvProdutos.Location = new System.Drawing.Point(17, 247);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(778, 201);
            this.dgvProdutos.TabIndex = 99;
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
            // lblProdutoDataVencimento
            // 
            this.lblProdutoDataVencimento.AutoSize = true;
            this.lblProdutoDataVencimento.Location = new System.Drawing.Point(572, 126);
            this.lblProdutoDataVencimento.Name = "lblProdutoDataVencimento";
            this.lblProdutoDataVencimento.Size = new System.Drawing.Size(113, 13);
            this.lblProdutoDataVencimento.TabIndex = 102;
            this.lblProdutoDataVencimento.Text = "DATA VENCIMENTO:";
            // 
            // mtbProdutoDataVencimento
            // 
            this.mtbProdutoDataVencimento.Location = new System.Drawing.Point(688, 119);
            this.mtbProdutoDataVencimento.Mask = "00/00/0000";
            this.mtbProdutoDataVencimento.Name = "mtbProdutoDataVencimento";
            this.mtbProdutoDataVencimento.Size = new System.Drawing.Size(72, 20);
            this.mtbProdutoDataVencimento.TabIndex = 101;
            this.mtbProdutoDataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblProdutoDataAdicao
            // 
            this.lblProdutoDataAdicao.AutoSize = true;
            this.lblProdutoDataAdicao.Location = new System.Drawing.Point(603, 157);
            this.lblProdutoDataAdicao.Name = "lblProdutoDataAdicao";
            this.lblProdutoDataAdicao.Size = new System.Drawing.Size(82, 13);
            this.lblProdutoDataAdicao.TabIndex = 104;
            this.lblProdutoDataAdicao.Text = "DATA ADIÇÃO:";
            // 
            // mtbProdutoDataAdicao
            // 
            this.mtbProdutoDataAdicao.Location = new System.Drawing.Point(688, 150);
            this.mtbProdutoDataAdicao.Mask = "00/00/0000";
            this.mtbProdutoDataAdicao.Name = "mtbProdutoDataAdicao";
            this.mtbProdutoDataAdicao.Size = new System.Drawing.Size(72, 20);
            this.mtbProdutoDataAdicao.TabIndex = 103;
            this.mtbProdutoDataAdicao.ValidatingType = typeof(System.DateTime);
            // 
            // cboProdutoStatus
            // 
            this.cboProdutoStatus.FormattingEnabled = true;
            this.cboProdutoStatus.Location = new System.Drawing.Point(300, 454);
            this.cboProdutoStatus.Name = "cboProdutoStatus";
            this.cboProdutoStatus.Size = new System.Drawing.Size(151, 21);
            this.cboProdutoStatus.TabIndex = 105;
            // 
            // lblProdutoCategoria
            // 
            this.lblProdutoCategoria.AutoSize = true;
            this.lblProdutoCategoria.Location = new System.Drawing.Point(22, 227);
            this.lblProdutoCategoria.Name = "lblProdutoCategoria";
            this.lblProdutoCategoria.Size = new System.Drawing.Size(72, 13);
            this.lblProdutoCategoria.TabIndex = 106;
            this.lblProdutoCategoria.Text = "CATEGORIA:";
            // 
            // cboProdutoCategoria
            // 
            this.cboProdutoCategoria.FormattingEnabled = true;
            this.cboProdutoCategoria.Location = new System.Drawing.Point(95, 222);
            this.cboProdutoCategoria.Name = "cboProdutoCategoria";
            this.cboProdutoCategoria.Size = new System.Drawing.Size(238, 21);
            this.cboProdutoCategoria.TabIndex = 107;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 482);
            this.Controls.Add(this.cboProdutoCategoria);
            this.Controls.Add(this.lblProdutoCategoria);
            this.Controls.Add(this.cboProdutoStatus);
            this.Controls.Add(this.lblProdutoDataAdicao);
            this.Controls.Add(this.mtbProdutoDataAdicao);
            this.Controls.Add(this.lblProdutoDataVencimento);
            this.Controls.Add(this.mtbProdutoDataVencimento);
            this.Controls.Add(this.lblProdutoBancoSituacao);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblProdutoBanco);
            this.Controls.Add(this.txtProdutoValorUnidade);
            this.Controls.Add(this.lblProdutoValorUnidade);
            this.Controls.Add(this.lblProdutoStatusPedido);
            this.Controls.Add(this.lblProdutoDataFabricacao);
            this.Controls.Add(this.nudProdutoQuantidade);
            this.Controls.Add(this.lblProdutoQuantidade);
            this.Controls.Add(this.mtbProdutoDataFabricacao);
            this.Controls.Add(this.lblProdutoFornecedor);
            this.Controls.Add(this.txtProdutoFornecedor);
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
            this.Load += new System.EventHandler(this.frmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProdutoID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdutoQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProdutoCriar;
        private System.Windows.Forms.Button btnProdutoDeletar;
        private System.Windows.Forms.Button btnProdutoEditar;
        private System.Windows.Forms.Button btnProdutoSalvar;
        private System.Windows.Forms.Label lblProdutoID;
        private System.Windows.Forms.Label lblProdutoNome;
        private System.Windows.Forms.Label lblCadastroProduto;
        private System.Windows.Forms.Label lblProdutoFornecedor;
        private System.Windows.Forms.Label lblProdutoValorUnidade;
        private System.Windows.Forms.Label lblProdutoStatusPedido;
        private System.Windows.Forms.Label lblProdutoDataFabricacao;
        private System.Windows.Forms.Label lblProdutoQuantidade;
        private System.Windows.Forms.Label lblProdutoBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORNECEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_UNIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_ADICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS_ESTOQUE;
        public System.Windows.Forms.NumericUpDown nudProdutoID;
        public System.Windows.Forms.TextBox txtProdutoNome;
        public System.Windows.Forms.TextBox txtProdutoFornecedor;
        public System.Windows.Forms.TextBox txtProdutoValorUnidade;
        public System.Windows.Forms.NumericUpDown nudProdutoQuantidade;
        public System.Windows.Forms.MaskedTextBox mtbProdutoDataFabricacao;
        public System.Windows.Forms.DataGridView dgvProdutos;
        public System.Windows.Forms.Label lblProdutoBancoSituacao;
        private System.Windows.Forms.Label lblProdutoDataVencimento;
        public System.Windows.Forms.MaskedTextBox mtbProdutoDataVencimento;
        private System.Windows.Forms.Label lblProdutoDataAdicao;
        public System.Windows.Forms.MaskedTextBox mtbProdutoDataAdicao;
        public System.Windows.Forms.ComboBox cboProdutoStatus;
        private System.Windows.Forms.Label lblProdutoCategoria;
        private System.Windows.Forms.ComboBox cboProdutoCategoria;
    }
}