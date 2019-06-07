namespace UML
{
    partial class frmFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedor));
            this.btnFornecedorCriar = new System.Windows.Forms.Button();
            this.btnFornecedorDeletar = new System.Windows.Forms.Button();
            this.btnFornecedorEditar = new System.Windows.Forms.Button();
            this.btnFornecedorSalvar = new System.Windows.Forms.Button();
            this.lblFornecedorID = new System.Windows.Forms.Label();
            this.nudFornecedorID = new System.Windows.Forms.NumericUpDown();
            this.lblCadastroFornecedor = new System.Windows.Forms.Label();
            this.mtbFornecedorCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblFornecedorCnpj = new System.Windows.Forms.Label();
            this.cboFornecedorEstado = new System.Windows.Forms.ComboBox();
            this.mtbFornecedorCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblFornecedorCelular = new System.Windows.Forms.Label();
            this.txtFornecedorBairro = new System.Windows.Forms.TextBox();
            this.lblFornecedorCep = new System.Windows.Forms.Label();
            this.lblFornecedorEstado = new System.Windows.Forms.Label();
            this.mtbFornecedorCep = new System.Windows.Forms.MaskedTextBox();
            this.txtFornecedorComplemento = new System.Windows.Forms.TextBox();
            this.txtFornecedorNumero = new System.Windows.Forms.TextBox();
            this.lblFornecedorBairro = new System.Windows.Forms.Label();
            this.lblFornecedorComplemento = new System.Windows.Forms.Label();
            this.lblFornecedorNumero = new System.Windows.Forms.Label();
            this.cboFornecedorLogadouro = new System.Windows.Forms.ComboBox();
            this.mtbFornecedorTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblFornecedorTelefone = new System.Windows.Forms.Label();
            this.lblFornecedorEndereco = new System.Windows.Forms.Label();
            this.txtFornecedorEndereco = new System.Windows.Forms.TextBox();
            this.lblFornecedorNome = new System.Windows.Forms.Label();
            this.txtFornecedorNome = new System.Windows.Forms.TextBox();
            this.cboFornecedorStatus = new System.Windows.Forms.ComboBox();
            this.lblFornecedorStatus = new System.Windows.Forms.Label();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOUGRADOURO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPLEMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CELULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFornecedorCidade = new System.Windows.Forms.TextBox();
            this.lblFornecedorCidade = new System.Windows.Forms.Label();
            this.lblFornecedorBancoSituacao = new System.Windows.Forms.Label();
            this.lblFornecedorBanco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFornecedorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFornecedorCriar
            // 
            this.btnFornecedorCriar.Location = new System.Drawing.Point(470, 451);
            this.btnFornecedorCriar.Name = "btnFornecedorCriar";
            this.btnFornecedorCriar.Size = new System.Drawing.Size(75, 23);
            this.btnFornecedorCriar.TabIndex = 81;
            this.btnFornecedorCriar.Text = "CRIAR";
            this.btnFornecedorCriar.UseVisualStyleBackColor = true;
            this.btnFornecedorCriar.Click += new System.EventHandler(this.btnFornecedorCriar_Click);
            // 
            // btnFornecedorDeletar
            // 
            this.btnFornecedorDeletar.Location = new System.Drawing.Point(711, 451);
            this.btnFornecedorDeletar.Name = "btnFornecedorDeletar";
            this.btnFornecedorDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnFornecedorDeletar.TabIndex = 80;
            this.btnFornecedorDeletar.Text = "DELETAR";
            this.btnFornecedorDeletar.UseVisualStyleBackColor = true;
            // 
            // btnFornecedorEditar
            // 
            this.btnFornecedorEditar.Location = new System.Drawing.Point(631, 451);
            this.btnFornecedorEditar.Name = "btnFornecedorEditar";
            this.btnFornecedorEditar.Size = new System.Drawing.Size(75, 23);
            this.btnFornecedorEditar.TabIndex = 79;
            this.btnFornecedorEditar.Text = "EDITAR";
            this.btnFornecedorEditar.UseVisualStyleBackColor = true;
            // 
            // btnFornecedorSalvar
            // 
            this.btnFornecedorSalvar.Location = new System.Drawing.Point(551, 451);
            this.btnFornecedorSalvar.Name = "btnFornecedorSalvar";
            this.btnFornecedorSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnFornecedorSalvar.TabIndex = 78;
            this.btnFornecedorSalvar.Text = "SALVAR";
            this.btnFornecedorSalvar.UseVisualStyleBackColor = true;
            this.btnFornecedorSalvar.Click += new System.EventHandler(this.btnFornecedorSalvar_Click);
            // 
            // lblFornecedorID
            // 
            this.lblFornecedorID.AutoSize = true;
            this.lblFornecedorID.Location = new System.Drawing.Point(48, 107);
            this.lblFornecedorID.Name = "lblFornecedorID";
            this.lblFornecedorID.Size = new System.Drawing.Size(21, 13);
            this.lblFornecedorID.TabIndex = 77;
            this.lblFornecedorID.Text = "ID:";
            // 
            // nudFornecedorID
            // 
            this.nudFornecedorID.Location = new System.Drawing.Point(71, 100);
            this.nudFornecedorID.Name = "nudFornecedorID";
            this.nudFornecedorID.ReadOnly = true;
            this.nudFornecedorID.Size = new System.Drawing.Size(75, 20);
            this.nudFornecedorID.TabIndex = 76;
            // 
            // lblCadastroFornecedor
            // 
            this.lblCadastroFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCadastroFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroFornecedor.Location = new System.Drawing.Point(45, 28);
            this.lblCadastroFornecedor.Name = "lblCadastroFornecedor";
            this.lblCadastroFornecedor.Size = new System.Drawing.Size(710, 40);
            this.lblCadastroFornecedor.TabIndex = 73;
            this.lblCadastroFornecedor.Text = "Cadastro Fornecedor";
            this.lblCadastroFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbFornecedorCnpj
            // 
            this.mtbFornecedorCnpj.Location = new System.Drawing.Point(357, 100);
            this.mtbFornecedorCnpj.Mask = "99.999.999/9999-99";
            this.mtbFornecedorCnpj.Name = "mtbFornecedorCnpj";
            this.mtbFornecedorCnpj.Size = new System.Drawing.Size(112, 20);
            this.mtbFornecedorCnpj.TabIndex = 102;
            // 
            // lblFornecedorCnpj
            // 
            this.lblFornecedorCnpj.AutoSize = true;
            this.lblFornecedorCnpj.Location = new System.Drawing.Point(317, 107);
            this.lblFornecedorCnpj.Name = "lblFornecedorCnpj";
            this.lblFornecedorCnpj.Size = new System.Drawing.Size(37, 13);
            this.lblFornecedorCnpj.TabIndex = 101;
            this.lblFornecedorCnpj.Text = "CNPJ:";
            // 
            // cboFornecedorEstado
            // 
            this.cboFornecedorEstado.FormattingEnabled = true;
            this.cboFornecedorEstado.Location = new System.Drawing.Point(715, 166);
            this.cboFornecedorEstado.Name = "cboFornecedorEstado";
            this.cboFornecedorEstado.Size = new System.Drawing.Size(48, 21);
            this.cboFornecedorEstado.TabIndex = 100;
            // 
            // mtbFornecedorCelular
            // 
            this.mtbFornecedorCelular.Location = new System.Drawing.Point(676, 241);
            this.mtbFornecedorCelular.Mask = "(99) 9 0000-0000";
            this.mtbFornecedorCelular.Name = "mtbFornecedorCelular";
            this.mtbFornecedorCelular.Size = new System.Drawing.Size(88, 20);
            this.mtbFornecedorCelular.TabIndex = 99;
            // 
            // lblFornecedorCelular
            // 
            this.lblFornecedorCelular.AutoSize = true;
            this.lblFornecedorCelular.Location = new System.Drawing.Point(613, 244);
            this.lblFornecedorCelular.Name = "lblFornecedorCelular";
            this.lblFornecedorCelular.Size = new System.Drawing.Size(59, 13);
            this.lblFornecedorCelular.TabIndex = 98;
            this.lblFornecedorCelular.Text = "CELULAR:";
            // 
            // txtFornecedorBairro
            // 
            this.txtFornecedorBairro.Location = new System.Drawing.Point(583, 204);
            this.txtFornecedorBairro.Name = "txtFornecedorBairro";
            this.txtFornecedorBairro.Size = new System.Drawing.Size(182, 20);
            this.txtFornecedorBairro.TabIndex = 97;
            // 
            // lblFornecedorCep
            // 
            this.lblFornecedorCep.AutoSize = true;
            this.lblFornecedorCep.Location = new System.Drawing.Point(361, 246);
            this.lblFornecedorCep.Name = "lblFornecedorCep";
            this.lblFornecedorCep.Size = new System.Drawing.Size(31, 13);
            this.lblFornecedorCep.TabIndex = 96;
            this.lblFornecedorCep.Text = "CEP:";
            // 
            // lblFornecedorEstado
            // 
            this.lblFornecedorEstado.AutoSize = true;
            this.lblFornecedorEstado.Location = new System.Drawing.Point(661, 172);
            this.lblFornecedorEstado.Name = "lblFornecedorEstado";
            this.lblFornecedorEstado.Size = new System.Drawing.Size(54, 13);
            this.lblFornecedorEstado.TabIndex = 95;
            this.lblFornecedorEstado.Text = "ESTADO:";
            // 
            // mtbFornecedorCep
            // 
            this.mtbFornecedorCep.Location = new System.Drawing.Point(394, 241);
            this.mtbFornecedorCep.Mask = "00000-999";
            this.mtbFornecedorCep.Name = "mtbFornecedorCep";
            this.mtbFornecedorCep.Size = new System.Drawing.Size(59, 20);
            this.mtbFornecedorCep.TabIndex = 94;
            // 
            // txtFornecedorComplemento
            // 
            this.txtFornecedorComplemento.Location = new System.Drawing.Point(313, 204);
            this.txtFornecedorComplemento.Name = "txtFornecedorComplemento";
            this.txtFornecedorComplemento.Size = new System.Drawing.Size(218, 20);
            this.txtFornecedorComplemento.TabIndex = 93;
            // 
            // txtFornecedorNumero
            // 
            this.txtFornecedorNumero.Location = new System.Drawing.Point(113, 204);
            this.txtFornecedorNumero.Name = "txtFornecedorNumero";
            this.txtFornecedorNumero.Size = new System.Drawing.Size(100, 20);
            this.txtFornecedorNumero.TabIndex = 92;
            // 
            // lblFornecedorBairro
            // 
            this.lblFornecedorBairro.AutoSize = true;
            this.lblFornecedorBairro.Location = new System.Drawing.Point(533, 209);
            this.lblFornecedorBairro.Name = "lblFornecedorBairro";
            this.lblFornecedorBairro.Size = new System.Drawing.Size(51, 13);
            this.lblFornecedorBairro.TabIndex = 91;
            this.lblFornecedorBairro.Text = "BAIRRO:";
            // 
            // lblFornecedorComplemento
            // 
            this.lblFornecedorComplemento.AutoSize = true;
            this.lblFornecedorComplemento.Location = new System.Drawing.Point(218, 209);
            this.lblFornecedorComplemento.Name = "lblFornecedorComplemento";
            this.lblFornecedorComplemento.Size = new System.Drawing.Size(93, 13);
            this.lblFornecedorComplemento.TabIndex = 90;
            this.lblFornecedorComplemento.Text = "COMPLEMENTO:";
            // 
            // lblFornecedorNumero
            // 
            this.lblFornecedorNumero.AutoSize = true;
            this.lblFornecedorNumero.Location = new System.Drawing.Point(52, 209);
            this.lblFornecedorNumero.Name = "lblFornecedorNumero";
            this.lblFornecedorNumero.Size = new System.Drawing.Size(58, 13);
            this.lblFornecedorNumero.TabIndex = 89;
            this.lblFornecedorNumero.Text = "NÚMERO:";
            // 
            // cboFornecedorLogadouro
            // 
            this.cboFornecedorLogadouro.FormattingEnabled = true;
            this.cboFornecedorLogadouro.Items.AddRange(new object[] {
            "Avenida",
            "Vila",
            "Travessa",
            "Rua"});
            this.cboFornecedorLogadouro.Location = new System.Drawing.Point(122, 169);
            this.cboFornecedorLogadouro.Name = "cboFornecedorLogadouro";
            this.cboFornecedorLogadouro.Size = new System.Drawing.Size(91, 21);
            this.cboFornecedorLogadouro.TabIndex = 88;
            // 
            // mtbFornecedorTelefone
            // 
            this.mtbFornecedorTelefone.Location = new System.Drawing.Point(524, 241);
            this.mtbFornecedorTelefone.Mask = "(99) 0000-0000";
            this.mtbFornecedorTelefone.Name = "mtbFornecedorTelefone";
            this.mtbFornecedorTelefone.Size = new System.Drawing.Size(83, 20);
            this.mtbFornecedorTelefone.TabIndex = 87;
            // 
            // lblFornecedorTelefone
            // 
            this.lblFornecedorTelefone.AutoSize = true;
            this.lblFornecedorTelefone.Location = new System.Drawing.Point(456, 244);
            this.lblFornecedorTelefone.Name = "lblFornecedorTelefone";
            this.lblFornecedorTelefone.Size = new System.Drawing.Size(66, 13);
            this.lblFornecedorTelefone.TabIndex = 86;
            this.lblFornecedorTelefone.Text = "TELEFONE:";
            // 
            // lblFornecedorEndereco
            // 
            this.lblFornecedorEndereco.AutoSize = true;
            this.lblFornecedorEndereco.Location = new System.Drawing.Point(50, 175);
            this.lblFornecedorEndereco.Name = "lblFornecedorEndereco";
            this.lblFornecedorEndereco.Size = new System.Drawing.Size(70, 13);
            this.lblFornecedorEndereco.TabIndex = 85;
            this.lblFornecedorEndereco.Text = "ENDEREÇO:";
            // 
            // txtFornecedorEndereco
            // 
            this.txtFornecedorEndereco.Location = new System.Drawing.Point(218, 169);
            this.txtFornecedorEndereco.Name = "txtFornecedorEndereco";
            this.txtFornecedorEndereco.Size = new System.Drawing.Size(443, 20);
            this.txtFornecedorEndereco.TabIndex = 84;
            // 
            // lblFornecedorNome
            // 
            this.lblFornecedorNome.AutoSize = true;
            this.lblFornecedorNome.Location = new System.Drawing.Point(50, 141);
            this.lblFornecedorNome.Name = "lblFornecedorNome";
            this.lblFornecedorNome.Size = new System.Drawing.Size(42, 13);
            this.lblFornecedorNome.TabIndex = 83;
            this.lblFornecedorNome.Text = "NOME:";
            // 
            // txtFornecedorNome
            // 
            this.txtFornecedorNome.Location = new System.Drawing.Point(93, 135);
            this.txtFornecedorNome.Name = "txtFornecedorNome";
            this.txtFornecedorNome.Size = new System.Drawing.Size(460, 20);
            this.txtFornecedorNome.TabIndex = 82;
            // 
            // cboFornecedorStatus
            // 
            this.cboFornecedorStatus.FormattingEnabled = true;
            this.cboFornecedorStatus.Location = new System.Drawing.Point(634, 99);
            this.cboFornecedorStatus.Name = "cboFornecedorStatus";
            this.cboFornecedorStatus.Size = new System.Drawing.Size(129, 21);
            this.cboFornecedorStatus.TabIndex = 104;
            // 
            // lblFornecedorStatus
            // 
            this.lblFornecedorStatus.AutoSize = true;
            this.lblFornecedorStatus.Location = new System.Drawing.Point(577, 107);
            this.lblFornecedorStatus.Name = "lblFornecedorStatus";
            this.lblFornecedorStatus.Size = new System.Drawing.Size(53, 13);
            this.lblFornecedorStatus.TabIndex = 103;
            this.lblFornecedorStatus.Text = "STATUS:";
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.CNPJ,
            this.LOUGRADOURO,
            this.ENDERECO,
            this.NUMERO,
            this.COMPLEMENTO,
            this.BAIRRO,
            this.CIDADE,
            this.ESTADO,
            this.CEP,
            this.TELEFONE,
            this.CELULAR,
            this.STATUS});
            this.dgvFornecedor.Location = new System.Drawing.Point(12, 267);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.Size = new System.Drawing.Size(780, 178);
            this.dgvFornecedor.TabIndex = 105;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            // 
            // CNPJ
            // 
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            // 
            // LOUGRADOURO
            // 
            this.LOUGRADOURO.HeaderText = "LOUGRADOURO";
            this.LOUGRADOURO.Name = "LOUGRADOURO";
            // 
            // ENDERECO
            // 
            this.ENDERECO.HeaderText = "ENDEREÇO";
            this.ENDERECO.Name = "ENDERECO";
            // 
            // NUMERO
            // 
            this.NUMERO.HeaderText = "NÚMERO";
            this.NUMERO.Name = "NUMERO";
            // 
            // COMPLEMENTO
            // 
            this.COMPLEMENTO.HeaderText = "COMPLEMENTO";
            this.COMPLEMENTO.Name = "COMPLEMENTO";
            // 
            // BAIRRO
            // 
            this.BAIRRO.HeaderText = "BAIRRO";
            this.BAIRRO.Name = "BAIRRO";
            // 
            // CIDADE
            // 
            this.CIDADE.HeaderText = "CIDADE";
            this.CIDADE.Name = "CIDADE";
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            // 
            // CEP
            // 
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            // 
            // TELEFONE
            // 
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.Name = "TELEFONE";
            // 
            // CELULAR
            // 
            this.CELULAR.HeaderText = "CELULAR";
            this.CELULAR.Name = "CELULAR";
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            // 
            // txtFornecedorCidade
            // 
            this.txtFornecedorCidade.Location = new System.Drawing.Point(106, 241);
            this.txtFornecedorCidade.Name = "txtFornecedorCidade";
            this.txtFornecedorCidade.Size = new System.Drawing.Size(249, 20);
            this.txtFornecedorCidade.TabIndex = 107;
            // 
            // lblFornecedorCidade
            // 
            this.lblFornecedorCidade.AutoSize = true;
            this.lblFornecedorCidade.Location = new System.Drawing.Point(53, 246);
            this.lblFornecedorCidade.Name = "lblFornecedorCidade";
            this.lblFornecedorCidade.Size = new System.Drawing.Size(50, 13);
            this.lblFornecedorCidade.TabIndex = 106;
            this.lblFornecedorCidade.Text = "CIDADE:";
            // 
            // lblFornecedorBancoSituacao
            // 
            this.lblFornecedorBancoSituacao.AutoSize = true;
            this.lblFornecedorBancoSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedorBancoSituacao.ForeColor = System.Drawing.Color.Red;
            this.lblFornecedorBancoSituacao.Location = new System.Drawing.Point(730, 8);
            this.lblFornecedorBancoSituacao.Name = "lblFornecedorBancoSituacao";
            this.lblFornecedorBancoSituacao.Size = new System.Drawing.Size(58, 13);
            this.lblFornecedorBancoSituacao.TabIndex = 109;
            this.lblFornecedorBancoSituacao.Text = "OFFLINE";
            // 
            // lblFornecedorBanco
            // 
            this.lblFornecedorBanco.AutoSize = true;
            this.lblFornecedorBanco.Location = new System.Drawing.Point(681, 8);
            this.lblFornecedorBanco.Name = "lblFornecedorBanco";
            this.lblFornecedorBanco.Size = new System.Drawing.Size(47, 13);
            this.lblFornecedorBanco.TabIndex = 108;
            this.lblFornecedorBanco.Text = "BANCO:";
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 482);
            this.Controls.Add(this.lblFornecedorBancoSituacao);
            this.Controls.Add(this.lblFornecedorBanco);
            this.Controls.Add(this.txtFornecedorCidade);
            this.Controls.Add(this.lblFornecedorCidade);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.cboFornecedorStatus);
            this.Controls.Add(this.lblFornecedorStatus);
            this.Controls.Add(this.mtbFornecedorCnpj);
            this.Controls.Add(this.lblFornecedorCnpj);
            this.Controls.Add(this.cboFornecedorEstado);
            this.Controls.Add(this.mtbFornecedorCelular);
            this.Controls.Add(this.lblFornecedorCelular);
            this.Controls.Add(this.txtFornecedorBairro);
            this.Controls.Add(this.lblFornecedorCep);
            this.Controls.Add(this.lblFornecedorEstado);
            this.Controls.Add(this.mtbFornecedorCep);
            this.Controls.Add(this.txtFornecedorComplemento);
            this.Controls.Add(this.txtFornecedorNumero);
            this.Controls.Add(this.lblFornecedorBairro);
            this.Controls.Add(this.lblFornecedorComplemento);
            this.Controls.Add(this.lblFornecedorNumero);
            this.Controls.Add(this.cboFornecedorLogadouro);
            this.Controls.Add(this.mtbFornecedorTelefone);
            this.Controls.Add(this.lblFornecedorTelefone);
            this.Controls.Add(this.lblFornecedorEndereco);
            this.Controls.Add(this.txtFornecedorEndereco);
            this.Controls.Add(this.lblFornecedorNome);
            this.Controls.Add(this.txtFornecedorNome);
            this.Controls.Add(this.btnFornecedorCriar);
            this.Controls.Add(this.btnFornecedorDeletar);
            this.Controls.Add(this.btnFornecedorEditar);
            this.Controls.Add(this.btnFornecedorSalvar);
            this.Controls.Add(this.lblFornecedorID);
            this.Controls.Add(this.nudFornecedorID);
            this.Controls.Add(this.lblCadastroFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFornecedorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFornecedorCriar;
        private System.Windows.Forms.Button btnFornecedorDeletar;
        private System.Windows.Forms.Button btnFornecedorEditar;
        private System.Windows.Forms.Button btnFornecedorSalvar;
        private System.Windows.Forms.Label lblFornecedorID;
        private System.Windows.Forms.Label lblCadastroFornecedor;
        private System.Windows.Forms.Label lblFornecedorCnpj;
        private System.Windows.Forms.Label lblFornecedorCelular;
        private System.Windows.Forms.Label lblFornecedorCep;
        private System.Windows.Forms.Label lblFornecedorEstado;
        private System.Windows.Forms.Label lblFornecedorBairro;
        private System.Windows.Forms.Label lblFornecedorComplemento;
        private System.Windows.Forms.Label lblFornecedorNumero;
        private System.Windows.Forms.Label lblFornecedorTelefone;
        private System.Windows.Forms.Label lblFornecedorEndereco;
        private System.Windows.Forms.Label lblFornecedorNome;
        private System.Windows.Forms.Label lblFornecedorStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOUGRADOURO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPLEMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CELULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.Label lblFornecedorCidade;
        private System.Windows.Forms.Label lblFornecedorBanco;
        public System.Windows.Forms.NumericUpDown nudFornecedorID;
        public System.Windows.Forms.MaskedTextBox mtbFornecedorCnpj;
        public System.Windows.Forms.ComboBox cboFornecedorEstado;
        public System.Windows.Forms.MaskedTextBox mtbFornecedorCelular;
        public System.Windows.Forms.TextBox txtFornecedorBairro;
        public System.Windows.Forms.MaskedTextBox mtbFornecedorCep;
        public System.Windows.Forms.TextBox txtFornecedorComplemento;
        public System.Windows.Forms.TextBox txtFornecedorNumero;
        public System.Windows.Forms.ComboBox cboFornecedorLogadouro;
        public System.Windows.Forms.MaskedTextBox mtbFornecedorTelefone;
        public System.Windows.Forms.TextBox txtFornecedorEndereco;
        public System.Windows.Forms.TextBox txtFornecedorNome;
        public System.Windows.Forms.ComboBox cboFornecedorStatus;
        public System.Windows.Forms.DataGridView dgvFornecedor;
        public System.Windows.Forms.TextBox txtFornecedorCidade;
        public System.Windows.Forms.Label lblFornecedorBancoSituacao;
    }
}