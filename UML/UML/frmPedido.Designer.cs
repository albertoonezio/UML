namespace UML
{
    partial class frmPedido
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
            this.btnCadastroPedidoDeletar = new System.Windows.Forms.Button();
            this.btnCadastroPedidoEditar = new System.Windows.Forms.Button();
            this.btnCadastroPedidoSalvar = new System.Windows.Forms.Button();
            this.lblPedidoID = new System.Windows.Forms.Label();
            this.nudPedidoID = new System.Windows.Forms.NumericUpDown();
            this.lblPedidoNomeCliente = new System.Windows.Forms.Label();
            this.txtPedidoNomeCliente = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblPedidoNomeProduto = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblPedidoQuantidade = new System.Windows.Forms.Label();
            this.nudPedidoQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblPedidoDataElaboracao = new System.Windows.Forms.Label();
            this.lblPedidoStatusPedido = new System.Windows.Forms.Label();
            this.lblPedidoStatusProduto = new System.Windows.Forms.Label();
            this.lblPedidoStatusCliente = new System.Windows.Forms.Label();
            this.txtPedidoStatusCliente = new System.Windows.Forms.TextBox();
            this.txtPedidoStatusProduto = new System.Windows.Forms.TextBox();
            this.txtPedidoStatusPedido = new System.Windows.Forms.TextBox();
            this.lblPedidoValorUnidade = new System.Windows.Forms.Label();
            this.lblPedidoValorTotal = new System.Windows.Forms.Label();
            this.btnPedidoValidarCliente = new System.Windows.Forms.Button();
            this.btnPedidoValidarProduto = new System.Windows.Forms.Button();
            this.txtPedidoValorUnidade = new System.Windows.Forms.TextBox();
            this.txtPedidoValorTotal = new System.Windows.Forms.TextBox();
            this.btnCadastroPedidoCriar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPedidoBancoSituacao = new System.Windows.Forms.Label();
            this.lblPedidoBanco = new System.Windows.Forms.Label();
            this.btnCadastroPedidoIncluir = new System.Windows.Forms.Button();
            this.btnCadastroPedidoRemover = new System.Windows.Forms.Button();
            this.lbPedidoListaProdutos = new System.Windows.Forms.ListBox();
            this.cboPedidoNomeProduto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPedidoID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPedidoQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastroPedidoDeletar
            // 
            this.btnCadastroPedidoDeletar.Location = new System.Drawing.Point(718, 450);
            this.btnCadastroPedidoDeletar.Name = "btnCadastroPedidoDeletar";
            this.btnCadastroPedidoDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroPedidoDeletar.TabIndex = 71;
            this.btnCadastroPedidoDeletar.Text = "DELETAR";
            this.btnCadastroPedidoDeletar.UseVisualStyleBackColor = true;
            // 
            // btnCadastroPedidoEditar
            // 
            this.btnCadastroPedidoEditar.Location = new System.Drawing.Point(638, 450);
            this.btnCadastroPedidoEditar.Name = "btnCadastroPedidoEditar";
            this.btnCadastroPedidoEditar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroPedidoEditar.TabIndex = 70;
            this.btnCadastroPedidoEditar.Text = "EDITAR";
            this.btnCadastroPedidoEditar.UseVisualStyleBackColor = true;
            // 
            // btnCadastroPedidoSalvar
            // 
            this.btnCadastroPedidoSalvar.Location = new System.Drawing.Point(558, 450);
            this.btnCadastroPedidoSalvar.Name = "btnCadastroPedidoSalvar";
            this.btnCadastroPedidoSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroPedidoSalvar.TabIndex = 69;
            this.btnCadastroPedidoSalvar.Text = "SALVAR";
            this.btnCadastroPedidoSalvar.UseVisualStyleBackColor = true;
            // 
            // lblPedidoID
            // 
            this.lblPedidoID.AutoSize = true;
            this.lblPedidoID.Location = new System.Drawing.Point(48, 95);
            this.lblPedidoID.Name = "lblPedidoID";
            this.lblPedidoID.Size = new System.Drawing.Size(21, 13);
            this.lblPedidoID.TabIndex = 68;
            this.lblPedidoID.Text = "ID:";
            // 
            // nudPedidoID
            // 
            this.nudPedidoID.Location = new System.Drawing.Point(71, 88);
            this.nudPedidoID.Name = "nudPedidoID";
            this.nudPedidoID.ReadOnly = true;
            this.nudPedidoID.Size = new System.Drawing.Size(75, 20);
            this.nudPedidoID.TabIndex = 67;
            // 
            // lblPedidoNomeCliente
            // 
            this.lblPedidoNomeCliente.AutoSize = true;
            this.lblPedidoNomeCliente.Location = new System.Drawing.Point(48, 126);
            this.lblPedidoNomeCliente.Name = "lblPedidoNomeCliente";
            this.lblPedidoNomeCliente.Size = new System.Drawing.Size(90, 13);
            this.lblPedidoNomeCliente.TabIndex = 66;
            this.lblPedidoNomeCliente.Text = "NOME CLIENTE:";
            // 
            // txtPedidoNomeCliente
            // 
            this.txtPedidoNomeCliente.Location = new System.Drawing.Point(141, 120);
            this.txtPedidoNomeCliente.Name = "txtPedidoNomeCliente";
            this.txtPedidoNomeCliente.Size = new System.Drawing.Size(431, 20);
            this.txtPedidoNomeCliente.TabIndex = 65;
            // 
            // lblPedido
            // 
            this.lblPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(45, 27);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(710, 40);
            this.lblPedido.TabIndex = 64;
            this.lblPedido.Text = "Cadastro Pedido";
            this.lblPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPedidoNomeProduto
            // 
            this.lblPedidoNomeProduto.AutoSize = true;
            this.lblPedidoNomeProduto.Location = new System.Drawing.Point(48, 190);
            this.lblPedidoNomeProduto.Name = "lblPedidoNomeProduto";
            this.lblPedidoNomeProduto.Size = new System.Drawing.Size(99, 13);
            this.lblPedidoNomeProduto.TabIndex = 73;
            this.lblPedidoNomeProduto.Text = "NOME PRODUTO:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(687, 83);
            this.maskedTextBox1.Mask = "00/00/0000 90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 74;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // lblPedidoQuantidade
            // 
            this.lblPedidoQuantidade.AutoSize = true;
            this.lblPedidoQuantidade.Location = new System.Drawing.Point(12, 462);
            this.lblPedidoQuantidade.Name = "lblPedidoQuantidade";
            this.lblPedidoQuantidade.Size = new System.Drawing.Size(81, 13);
            this.lblPedidoQuantidade.TabIndex = 75;
            this.lblPedidoQuantidade.Text = "QUANTIDADE:";
            // 
            // nudPedidoQuantidade
            // 
            this.nudPedidoQuantidade.Location = new System.Drawing.Point(95, 455);
            this.nudPedidoQuantidade.Name = "nudPedidoQuantidade";
            this.nudPedidoQuantidade.Size = new System.Drawing.Size(84, 20);
            this.nudPedidoQuantidade.TabIndex = 76;
            // 
            // lblPedidoDataElaboracao
            // 
            this.lblPedidoDataElaboracao.AutoSize = true;
            this.lblPedidoDataElaboracao.Location = new System.Drawing.Point(565, 90);
            this.lblPedidoDataElaboracao.Name = "lblPedidoDataElaboracao";
            this.lblPedidoDataElaboracao.Size = new System.Drawing.Size(114, 13);
            this.lblPedidoDataElaboracao.TabIndex = 77;
            this.lblPedidoDataElaboracao.Text = "DATA ELABORAÇÃO:";
            // 
            // lblPedidoStatusPedido
            // 
            this.lblPedidoStatusPedido.AutoSize = true;
            this.lblPedidoStatusPedido.Location = new System.Drawing.Point(12, 428);
            this.lblPedidoStatusPedido.Name = "lblPedidoStatusPedido";
            this.lblPedidoStatusPedido.Size = new System.Drawing.Size(97, 13);
            this.lblPedidoStatusPedido.TabIndex = 79;
            this.lblPedidoStatusPedido.Text = "STATUS PEDIDO:";
            // 
            // lblPedidoStatusProduto
            // 
            this.lblPedidoStatusProduto.AutoSize = true;
            this.lblPedidoStatusProduto.Location = new System.Drawing.Point(574, 187);
            this.lblPedidoStatusProduto.Name = "lblPedidoStatusProduto";
            this.lblPedidoStatusProduto.Size = new System.Drawing.Size(110, 13);
            this.lblPedidoStatusProduto.TabIndex = 80;
            this.lblPedidoStatusProduto.Text = "STATUS PRODUTO:";
            // 
            // lblPedidoStatusCliente
            // 
            this.lblPedidoStatusCliente.AutoSize = true;
            this.lblPedidoStatusCliente.Location = new System.Drawing.Point(582, 123);
            this.lblPedidoStatusCliente.Name = "lblPedidoStatusCliente";
            this.lblPedidoStatusCliente.Size = new System.Drawing.Size(101, 13);
            this.lblPedidoStatusCliente.TabIndex = 81;
            this.lblPedidoStatusCliente.Text = "STATUS CLIENTE:";
            // 
            // txtPedidoStatusCliente
            // 
            this.txtPedidoStatusCliente.Location = new System.Drawing.Point(682, 119);
            this.txtPedidoStatusCliente.Name = "txtPedidoStatusCliente";
            this.txtPedidoStatusCliente.ReadOnly = true;
            this.txtPedidoStatusCliente.Size = new System.Drawing.Size(107, 20);
            this.txtPedidoStatusCliente.TabIndex = 82;
            this.txtPedidoStatusCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPedidoStatusProduto
            // 
            this.txtPedidoStatusProduto.Location = new System.Drawing.Point(682, 182);
            this.txtPedidoStatusProduto.Name = "txtPedidoStatusProduto";
            this.txtPedidoStatusProduto.ReadOnly = true;
            this.txtPedidoStatusProduto.Size = new System.Drawing.Size(107, 20);
            this.txtPedidoStatusProduto.TabIndex = 83;
            this.txtPedidoStatusProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPedidoStatusPedido
            // 
            this.txtPedidoStatusPedido.Location = new System.Drawing.Point(111, 421);
            this.txtPedidoStatusPedido.Name = "txtPedidoStatusPedido";
            this.txtPedidoStatusPedido.ReadOnly = true;
            this.txtPedidoStatusPedido.Size = new System.Drawing.Size(140, 20);
            this.txtPedidoStatusPedido.TabIndex = 84;
            this.txtPedidoStatusPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPedidoValorUnidade
            // 
            this.lblPedidoValorUnidade.AutoSize = true;
            this.lblPedidoValorUnidade.Location = new System.Drawing.Point(359, 424);
            this.lblPedidoValorUnidade.Name = "lblPedidoValorUnidade";
            this.lblPedidoValorUnidade.Size = new System.Drawing.Size(124, 13);
            this.lblPedidoValorUnidade.TabIndex = 85;
            this.lblPedidoValorUnidade.Text = "VALOR POR UNIDADE:";
            // 
            // lblPedidoValorTotal
            // 
            this.lblPedidoValorTotal.AutoSize = true;
            this.lblPedidoValorTotal.Location = new System.Drawing.Point(596, 424);
            this.lblPedidoValorTotal.Name = "lblPedidoValorTotal";
            this.lblPedidoValorTotal.Size = new System.Drawing.Size(84, 13);
            this.lblPedidoValorTotal.TabIndex = 86;
            this.lblPedidoValorTotal.Text = "VALOR TOTAL:";
            // 
            // btnPedidoValidarCliente
            // 
            this.btnPedidoValidarCliente.Location = new System.Drawing.Point(641, 146);
            this.btnPedidoValidarCliente.Name = "btnPedidoValidarCliente";
            this.btnPedidoValidarCliente.Size = new System.Drawing.Size(150, 25);
            this.btnPedidoValidarCliente.TabIndex = 87;
            this.btnPedidoValidarCliente.Text = "VALIDAR CLIENTE";
            this.btnPedidoValidarCliente.UseVisualStyleBackColor = true;
            // 
            // btnPedidoValidarProduto
            // 
            this.btnPedidoValidarProduto.Location = new System.Drawing.Point(641, 208);
            this.btnPedidoValidarProduto.Name = "btnPedidoValidarProduto";
            this.btnPedidoValidarProduto.Size = new System.Drawing.Size(150, 25);
            this.btnPedidoValidarProduto.TabIndex = 88;
            this.btnPedidoValidarProduto.Text = "VALIDAR PRODUTO";
            this.btnPedidoValidarProduto.UseVisualStyleBackColor = true;
            // 
            // txtPedidoValorUnidade
            // 
            this.txtPedidoValorUnidade.Location = new System.Drawing.Point(484, 417);
            this.txtPedidoValorUnidade.Name = "txtPedidoValorUnidade";
            this.txtPedidoValorUnidade.ReadOnly = true;
            this.txtPedidoValorUnidade.Size = new System.Drawing.Size(107, 20);
            this.txtPedidoValorUnidade.TabIndex = 89;
            this.txtPedidoValorUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPedidoValorTotal
            // 
            this.txtPedidoValorTotal.Location = new System.Drawing.Point(681, 417);
            this.txtPedidoValorTotal.Name = "txtPedidoValorTotal";
            this.txtPedidoValorTotal.ReadOnly = true;
            this.txtPedidoValorTotal.Size = new System.Drawing.Size(107, 20);
            this.txtPedidoValorTotal.TabIndex = 90;
            this.txtPedidoValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCadastroPedidoCriar
            // 
            this.btnCadastroPedidoCriar.Location = new System.Drawing.Point(477, 450);
            this.btnCadastroPedidoCriar.Name = "btnCadastroPedidoCriar";
            this.btnCadastroPedidoCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroPedidoCriar.TabIndex = 91;
            this.btnCadastroPedidoCriar.Text = "CRIAR";
            this.btnCadastroPedidoCriar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME_CLIENTE,
            this.NOME_PRODUTO,
            this.QUANTIDADE,
            this.VALOR_TOTAL,
            this.STATUS_PEDIDO});
            this.dataGridView1.Location = new System.Drawing.Point(226, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 172);
            this.dataGridView1.TabIndex = 92;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 30;
            // 
            // NOME_CLIENTE
            // 
            this.NOME_CLIENTE.HeaderText = "NOME CLIENTE";
            this.NOME_CLIENTE.Name = "NOME_CLIENTE";
            this.NOME_CLIENTE.Width = 250;
            // 
            // NOME_PRODUTO
            // 
            this.NOME_PRODUTO.HeaderText = "NOME PRODUTO";
            this.NOME_PRODUTO.Name = "NOME_PRODUTO";
            this.NOME_PRODUTO.Width = 250;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.Width = 50;
            // 
            // VALOR_TOTAL
            // 
            this.VALOR_TOTAL.HeaderText = "VALOR TOTAL";
            this.VALOR_TOTAL.Name = "VALOR_TOTAL";
            this.VALOR_TOTAL.Width = 60;
            // 
            // STATUS_PEDIDO
            // 
            this.STATUS_PEDIDO.HeaderText = "STATUS PEDIDO";
            this.STATUS_PEDIDO.Name = "STATUS_PEDIDO";
            this.STATUS_PEDIDO.Width = 80;
            // 
            // lblPedidoBancoSituacao
            // 
            this.lblPedidoBancoSituacao.AutoSize = true;
            this.lblPedidoBancoSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoBancoSituacao.ForeColor = System.Drawing.Color.Red;
            this.lblPedidoBancoSituacao.Location = new System.Drawing.Point(735, 7);
            this.lblPedidoBancoSituacao.Name = "lblPedidoBancoSituacao";
            this.lblPedidoBancoSituacao.Size = new System.Drawing.Size(58, 13);
            this.lblPedidoBancoSituacao.TabIndex = 102;
            this.lblPedidoBancoSituacao.Text = "OFFLINE";
            // 
            // lblPedidoBanco
            // 
            this.lblPedidoBanco.AutoSize = true;
            this.lblPedidoBanco.Location = new System.Drawing.Point(686, 7);
            this.lblPedidoBanco.Name = "lblPedidoBanco";
            this.lblPedidoBanco.Size = new System.Drawing.Size(47, 13);
            this.lblPedidoBanco.TabIndex = 101;
            this.lblPedidoBanco.Text = "BANCO:";
            // 
            // btnCadastroPedidoIncluir
            // 
            this.btnCadastroPedidoIncluir.Location = new System.Drawing.Point(240, 450);
            this.btnCadastroPedidoIncluir.Name = "btnCadastroPedidoIncluir";
            this.btnCadastroPedidoIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroPedidoIncluir.TabIndex = 103;
            this.btnCadastroPedidoIncluir.Text = "INCLUIR";
            this.btnCadastroPedidoIncluir.UseVisualStyleBackColor = true;
            // 
            // btnCadastroPedidoRemover
            // 
            this.btnCadastroPedidoRemover.Location = new System.Drawing.Point(321, 450);
            this.btnCadastroPedidoRemover.Name = "btnCadastroPedidoRemover";
            this.btnCadastroPedidoRemover.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroPedidoRemover.TabIndex = 104;
            this.btnCadastroPedidoRemover.Text = "REMOVER";
            this.btnCadastroPedidoRemover.UseVisualStyleBackColor = true;
            // 
            // lbPedidoListaProdutos
            // 
            this.lbPedidoListaProdutos.FormattingEnabled = true;
            this.lbPedidoListaProdutos.Location = new System.Drawing.Point(12, 239);
            this.lbPedidoListaProdutos.Name = "lbPedidoListaProdutos";
            this.lbPedidoListaProdutos.Size = new System.Drawing.Size(208, 173);
            this.lbPedidoListaProdutos.TabIndex = 105;
            // 
            // cboPedidoNomeProduto
            // 
            this.cboPedidoNomeProduto.FormattingEnabled = true;
            this.cboPedidoNomeProduto.Location = new System.Drawing.Point(148, 184);
            this.cboPedidoNomeProduto.Name = "cboPedidoNomeProduto";
            this.cboPedidoNomeProduto.Size = new System.Drawing.Size(421, 21);
            this.cboPedidoNomeProduto.TabIndex = 106;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 482);
            this.Controls.Add(this.cboPedidoNomeProduto);
            this.Controls.Add(this.lbPedidoListaProdutos);
            this.Controls.Add(this.btnCadastroPedidoRemover);
            this.Controls.Add(this.btnCadastroPedidoIncluir);
            this.Controls.Add(this.lblPedidoBancoSituacao);
            this.Controls.Add(this.lblPedidoBanco);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadastroPedidoCriar);
            this.Controls.Add(this.txtPedidoValorTotal);
            this.Controls.Add(this.txtPedidoValorUnidade);
            this.Controls.Add(this.btnPedidoValidarProduto);
            this.Controls.Add(this.btnPedidoValidarCliente);
            this.Controls.Add(this.lblPedidoValorTotal);
            this.Controls.Add(this.lblPedidoValorUnidade);
            this.Controls.Add(this.txtPedidoStatusPedido);
            this.Controls.Add(this.txtPedidoStatusProduto);
            this.Controls.Add(this.txtPedidoStatusCliente);
            this.Controls.Add(this.lblPedidoStatusCliente);
            this.Controls.Add(this.lblPedidoStatusProduto);
            this.Controls.Add(this.lblPedidoStatusPedido);
            this.Controls.Add(this.lblPedidoDataElaboracao);
            this.Controls.Add(this.nudPedidoQuantidade);
            this.Controls.Add(this.lblPedidoQuantidade);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblPedidoNomeProduto);
            this.Controls.Add(this.btnCadastroPedidoDeletar);
            this.Controls.Add(this.btnCadastroPedidoEditar);
            this.Controls.Add(this.btnCadastroPedidoSalvar);
            this.Controls.Add(this.lblPedidoID);
            this.Controls.Add(this.nudPedidoID);
            this.Controls.Add(this.lblPedidoNomeCliente);
            this.Controls.Add(this.txtPedidoNomeCliente);
            this.Controls.Add(this.lblPedido);
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.nudPedidoID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPedidoQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastroPedidoDeletar;
        private System.Windows.Forms.Button btnCadastroPedidoEditar;
        private System.Windows.Forms.Button btnCadastroPedidoSalvar;
        private System.Windows.Forms.Label lblPedidoID;
        private System.Windows.Forms.NumericUpDown nudPedidoID;
        private System.Windows.Forms.Label lblPedidoNomeCliente;
        private System.Windows.Forms.TextBox txtPedidoNomeCliente;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblPedidoNomeProduto;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblPedidoQuantidade;
        private System.Windows.Forms.NumericUpDown nudPedidoQuantidade;
        private System.Windows.Forms.Label lblPedidoDataElaboracao;
        private System.Windows.Forms.Label lblPedidoStatusPedido;
        private System.Windows.Forms.Label lblPedidoStatusProduto;
        private System.Windows.Forms.Label lblPedidoStatusCliente;
        private System.Windows.Forms.TextBox txtPedidoStatusCliente;
        private System.Windows.Forms.TextBox txtPedidoStatusProduto;
        private System.Windows.Forms.TextBox txtPedidoStatusPedido;
        private System.Windows.Forms.Label lblPedidoValorUnidade;
        private System.Windows.Forms.Label lblPedidoValorTotal;
        private System.Windows.Forms.Button btnPedidoValidarCliente;
        private System.Windows.Forms.Button btnPedidoValidarProduto;
        private System.Windows.Forms.TextBox txtPedidoValorUnidade;
        private System.Windows.Forms.TextBox txtPedidoValorTotal;
        private System.Windows.Forms.Button btnCadastroPedidoCriar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS_PEDIDO;
        private System.Windows.Forms.Label lblPedidoBancoSituacao;
        private System.Windows.Forms.Label lblPedidoBanco;
        private System.Windows.Forms.Button btnCadastroPedidoIncluir;
        private System.Windows.Forms.Button btnCadastroPedidoRemover;
        private System.Windows.Forms.ListBox lbPedidoListaProdutos;
        private System.Windows.Forms.ComboBox cboPedidoNomeProduto;
    }
}