namespace UML
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.btnCadastroClienteCriar = new System.Windows.Forms.Button();
            this.cboCadastroClienteStatus = new System.Windows.Forms.ComboBox();
            this.txtCadastroClienteLimiteCredito = new System.Windows.Forms.TextBox();
            this.mtbCadastroClienteCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCadastroClienteCelular = new System.Windows.Forms.Label();
            this.txtCadastroClienteBairro = new System.Windows.Forms.TextBox();
            this.lblCadastroClienteCep = new System.Windows.Forms.Label();
            this.lblCadastroClienteEstado = new System.Windows.Forms.Label();
            this.mtbCadastroClienteCep = new System.Windows.Forms.MaskedTextBox();
            this.txtCadastroClienteComplemento = new System.Windows.Forms.TextBox();
            this.txtCadastroClienteNumero = new System.Windows.Forms.TextBox();
            this.lblCadastroClienteBairro = new System.Windows.Forms.Label();
            this.lblCadastroClienteComplemento = new System.Windows.Forms.Label();
            this.lblCadastroClienteNumero = new System.Windows.Forms.Label();
            this.cboCadastroClienteLogadouro = new System.Windows.Forms.ComboBox();
            this.btnCadastroClienteDeletar = new System.Windows.Forms.Button();
            this.btnCadastroClienteEditar = new System.Windows.Forms.Button();
            this.btnCadastroClienteSalvar = new System.Windows.Forms.Button();
            this.lblCadastroClienteLimiteCredito = new System.Windows.Forms.Label();
            this.mtbCadastroClienteTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCadastroClienteTelefone = new System.Windows.Forms.Label();
            this.lblCadastroClienteStatus = new System.Windows.Forms.Label();
            this.lblCadastroClienteFiliacao = new System.Windows.Forms.Label();
            this.txtCadastroClienteFiliacao = new System.Windows.Forms.TextBox();
            this.lblCadastroClienteEndereco = new System.Windows.Forms.Label();
            this.txtCadastroClienteEndereco = new System.Windows.Forms.TextBox();
            this.lblCadastroClienteID = new System.Windows.Forms.Label();
            this.nudCadastroClienteID = new System.Windows.Forms.NumericUpDown();
            this.lblCadastroClienteNome = new System.Windows.Forms.Label();
            this.txtCadastroClienteNome = new System.Windows.Forms.TextBox();
            this.lblCadastroCliente = new System.Windows.Forms.Label();
            this.cboCadastroClienteEstado = new System.Windows.Forms.ComboBox();
            this.lblCadastroClienteCpf = new System.Windows.Forms.Label();
            this.mtbCadastroClienteCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCadastroClienteRg = new System.Windows.Forms.Label();
            this.txtCadastroClienteRg = new System.Windows.Forms.TextBox();
            this.dgvCadastroCliente = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FILIACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.LIMITE_DE_CREDITO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtClienteCidade = new System.Windows.Forms.TextBox();
            this.lblClienteCidade = new System.Windows.Forms.Label();
            this.lblClienteBancoSituacao = new System.Windows.Forms.Label();
            this.lblClienteBanco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCadastroClienteID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastroClienteCriar
            // 
            this.btnCadastroClienteCriar.Location = new System.Drawing.Point(446, 449);
            this.btnCadastroClienteCriar.Name = "btnCadastroClienteCriar";
            this.btnCadastroClienteCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroClienteCriar.TabIndex = 63;
            this.btnCadastroClienteCriar.Text = "CRIAR";
            this.btnCadastroClienteCriar.UseVisualStyleBackColor = true;
            this.btnCadastroClienteCriar.Click += new System.EventHandler(this.btnCadastroClienteCriar_Click);
            // 
            // cboCadastroClienteStatus
            // 
            this.cboCadastroClienteStatus.FormattingEnabled = true;
            this.cboCadastroClienteStatus.Location = new System.Drawing.Point(633, 81);
            this.cboCadastroClienteStatus.Name = "cboCadastroClienteStatus";
            this.cboCadastroClienteStatus.Size = new System.Drawing.Size(129, 21);
            this.cboCadastroClienteStatus.TabIndex = 62;
            // 
            // txtCadastroClienteLimiteCredito
            // 
            this.txtCadastroClienteLimiteCredito.Location = new System.Drawing.Point(162, 453);
            this.txtCadastroClienteLimiteCredito.Name = "txtCadastroClienteLimiteCredito";
            this.txtCadastroClienteLimiteCredito.Size = new System.Drawing.Size(134, 20);
            this.txtCadastroClienteLimiteCredito.TabIndex = 61;
            // 
            // mtbCadastroClienteCelular
            // 
            this.mtbCadastroClienteCelular.Location = new System.Drawing.Point(672, 226);
            this.mtbCadastroClienteCelular.Mask = "(99) 9 0000-0000";
            this.mtbCadastroClienteCelular.Name = "mtbCadastroClienteCelular";
            this.mtbCadastroClienteCelular.Size = new System.Drawing.Size(88, 20);
            this.mtbCadastroClienteCelular.TabIndex = 60;
            // 
            // lblCadastroClienteCelular
            // 
            this.lblCadastroClienteCelular.AutoSize = true;
            this.lblCadastroClienteCelular.Location = new System.Drawing.Point(609, 229);
            this.lblCadastroClienteCelular.Name = "lblCadastroClienteCelular";
            this.lblCadastroClienteCelular.Size = new System.Drawing.Size(59, 13);
            this.lblCadastroClienteCelular.TabIndex = 59;
            this.lblCadastroClienteCelular.Text = "CELULAR:";
            // 
            // txtCadastroClienteBairro
            // 
            this.txtCadastroClienteBairro.Location = new System.Drawing.Point(580, 189);
            this.txtCadastroClienteBairro.Name = "txtCadastroClienteBairro";
            this.txtCadastroClienteBairro.Size = new System.Drawing.Size(182, 20);
            this.txtCadastroClienteBairro.TabIndex = 58;
            // 
            // lblCadastroClienteCep
            // 
            this.lblCadastroClienteCep.AutoSize = true;
            this.lblCadastroClienteCep.Location = new System.Drawing.Point(357, 231);
            this.lblCadastroClienteCep.Name = "lblCadastroClienteCep";
            this.lblCadastroClienteCep.Size = new System.Drawing.Size(31, 13);
            this.lblCadastroClienteCep.TabIndex = 57;
            this.lblCadastroClienteCep.Text = "CEP:";
            // 
            // lblCadastroClienteEstado
            // 
            this.lblCadastroClienteEstado.AutoSize = true;
            this.lblCadastroClienteEstado.Location = new System.Drawing.Point(658, 157);
            this.lblCadastroClienteEstado.Name = "lblCadastroClienteEstado";
            this.lblCadastroClienteEstado.Size = new System.Drawing.Size(54, 13);
            this.lblCadastroClienteEstado.TabIndex = 56;
            this.lblCadastroClienteEstado.Text = "ESTADO:";
            // 
            // mtbCadastroClienteCep
            // 
            this.mtbCadastroClienteCep.Location = new System.Drawing.Point(390, 226);
            this.mtbCadastroClienteCep.Mask = "00000-999";
            this.mtbCadastroClienteCep.Name = "mtbCadastroClienteCep";
            this.mtbCadastroClienteCep.Size = new System.Drawing.Size(59, 20);
            this.mtbCadastroClienteCep.TabIndex = 55;
            // 
            // txtCadastroClienteComplemento
            // 
            this.txtCadastroClienteComplemento.Location = new System.Drawing.Point(310, 189);
            this.txtCadastroClienteComplemento.Name = "txtCadastroClienteComplemento";
            this.txtCadastroClienteComplemento.Size = new System.Drawing.Size(218, 20);
            this.txtCadastroClienteComplemento.TabIndex = 54;
            // 
            // txtCadastroClienteNumero
            // 
            this.txtCadastroClienteNumero.Location = new System.Drawing.Point(110, 189);
            this.txtCadastroClienteNumero.Name = "txtCadastroClienteNumero";
            this.txtCadastroClienteNumero.Size = new System.Drawing.Size(100, 20);
            this.txtCadastroClienteNumero.TabIndex = 53;
            // 
            // lblCadastroClienteBairro
            // 
            this.lblCadastroClienteBairro.AutoSize = true;
            this.lblCadastroClienteBairro.Location = new System.Drawing.Point(530, 194);
            this.lblCadastroClienteBairro.Name = "lblCadastroClienteBairro";
            this.lblCadastroClienteBairro.Size = new System.Drawing.Size(51, 13);
            this.lblCadastroClienteBairro.TabIndex = 52;
            this.lblCadastroClienteBairro.Text = "BAIRRO:";
            // 
            // lblCadastroClienteComplemento
            // 
            this.lblCadastroClienteComplemento.AutoSize = true;
            this.lblCadastroClienteComplemento.Location = new System.Drawing.Point(215, 194);
            this.lblCadastroClienteComplemento.Name = "lblCadastroClienteComplemento";
            this.lblCadastroClienteComplemento.Size = new System.Drawing.Size(93, 13);
            this.lblCadastroClienteComplemento.TabIndex = 51;
            this.lblCadastroClienteComplemento.Text = "COMPLEMENTO:";
            // 
            // lblCadastroClienteNumero
            // 
            this.lblCadastroClienteNumero.AutoSize = true;
            this.lblCadastroClienteNumero.Location = new System.Drawing.Point(50, 194);
            this.lblCadastroClienteNumero.Name = "lblCadastroClienteNumero";
            this.lblCadastroClienteNumero.Size = new System.Drawing.Size(58, 13);
            this.lblCadastroClienteNumero.TabIndex = 50;
            this.lblCadastroClienteNumero.Text = "NÚMERO:";
            // 
            // cboCadastroClienteLogadouro
            // 
            this.cboCadastroClienteLogadouro.FormattingEnabled = true;
            this.cboCadastroClienteLogadouro.Items.AddRange(new object[] {
            "Avenida",
            "Vila",
            "Travessa",
            "Rua"});
            this.cboCadastroClienteLogadouro.Location = new System.Drawing.Point(119, 154);
            this.cboCadastroClienteLogadouro.Name = "cboCadastroClienteLogadouro";
            this.cboCadastroClienteLogadouro.Size = new System.Drawing.Size(91, 21);
            this.cboCadastroClienteLogadouro.TabIndex = 49;
            // 
            // btnCadastroClienteDeletar
            // 
            this.btnCadastroClienteDeletar.Location = new System.Drawing.Point(687, 449);
            this.btnCadastroClienteDeletar.Name = "btnCadastroClienteDeletar";
            this.btnCadastroClienteDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroClienteDeletar.TabIndex = 48;
            this.btnCadastroClienteDeletar.Text = "DELETAR";
            this.btnCadastroClienteDeletar.UseVisualStyleBackColor = true;
            this.btnCadastroClienteDeletar.Click += new System.EventHandler(this.btnCadastroClienteDeletar_Click);
            // 
            // btnCadastroClienteEditar
            // 
            this.btnCadastroClienteEditar.Location = new System.Drawing.Point(607, 449);
            this.btnCadastroClienteEditar.Name = "btnCadastroClienteEditar";
            this.btnCadastroClienteEditar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroClienteEditar.TabIndex = 47;
            this.btnCadastroClienteEditar.Text = "EDITAR";
            this.btnCadastroClienteEditar.UseVisualStyleBackColor = true;
            this.btnCadastroClienteEditar.Click += new System.EventHandler(this.btnCadastroClienteEditar_Click);
            // 
            // btnCadastroClienteSalvar
            // 
            this.btnCadastroClienteSalvar.Location = new System.Drawing.Point(527, 449);
            this.btnCadastroClienteSalvar.Name = "btnCadastroClienteSalvar";
            this.btnCadastroClienteSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroClienteSalvar.TabIndex = 46;
            this.btnCadastroClienteSalvar.Text = "SALVAR";
            this.btnCadastroClienteSalvar.UseVisualStyleBackColor = true;
            this.btnCadastroClienteSalvar.Click += new System.EventHandler(this.btnCadastroClienteSalvar_Click);
            // 
            // lblCadastroClienteLimiteCredito
            // 
            this.lblCadastroClienteLimiteCredito.AutoSize = true;
            this.lblCadastroClienteLimiteCredito.Location = new System.Drawing.Point(47, 456);
            this.lblCadastroClienteLimiteCredito.Name = "lblCadastroClienteLimiteCredito";
            this.lblCadastroClienteLimiteCredito.Size = new System.Drawing.Size(114, 13);
            this.lblCadastroClienteLimiteCredito.TabIndex = 45;
            this.lblCadastroClienteLimiteCredito.Text = "LIMITE DE CRÉDITO:";
            // 
            // mtbCadastroClienteTelefone
            // 
            this.mtbCadastroClienteTelefone.Location = new System.Drawing.Point(520, 226);
            this.mtbCadastroClienteTelefone.Mask = "(99) 0000-0000";
            this.mtbCadastroClienteTelefone.Name = "mtbCadastroClienteTelefone";
            this.mtbCadastroClienteTelefone.Size = new System.Drawing.Size(83, 20);
            this.mtbCadastroClienteTelefone.TabIndex = 44;
            // 
            // lblCadastroClienteTelefone
            // 
            this.lblCadastroClienteTelefone.AutoSize = true;
            this.lblCadastroClienteTelefone.Location = new System.Drawing.Point(452, 229);
            this.lblCadastroClienteTelefone.Name = "lblCadastroClienteTelefone";
            this.lblCadastroClienteTelefone.Size = new System.Drawing.Size(66, 13);
            this.lblCadastroClienteTelefone.TabIndex = 43;
            this.lblCadastroClienteTelefone.Text = "TELEFONE:";
            // 
            // lblCadastroClienteStatus
            // 
            this.lblCadastroClienteStatus.AutoSize = true;
            this.lblCadastroClienteStatus.Location = new System.Drawing.Point(576, 89);
            this.lblCadastroClienteStatus.Name = "lblCadastroClienteStatus";
            this.lblCadastroClienteStatus.Size = new System.Drawing.Size(53, 13);
            this.lblCadastroClienteStatus.TabIndex = 42;
            this.lblCadastroClienteStatus.Text = "STATUS:";
            // 
            // lblCadastroClienteFiliacao
            // 
            this.lblCadastroClienteFiliacao.AutoSize = true;
            this.lblCadastroClienteFiliacao.Location = new System.Drawing.Point(549, 126);
            this.lblCadastroClienteFiliacao.Name = "lblCadastroClienteFiliacao";
            this.lblCadastroClienteFiliacao.Size = new System.Drawing.Size(57, 13);
            this.lblCadastroClienteFiliacao.TabIndex = 41;
            this.lblCadastroClienteFiliacao.Text = "FILIAÇÃO:";
            // 
            // txtCadastroClienteFiliacao
            // 
            this.txtCadastroClienteFiliacao.Location = new System.Drawing.Point(604, 118);
            this.txtCadastroClienteFiliacao.Name = "txtCadastroClienteFiliacao";
            this.txtCadastroClienteFiliacao.Size = new System.Drawing.Size(158, 20);
            this.txtCadastroClienteFiliacao.TabIndex = 40;
            // 
            // lblCadastroClienteEndereco
            // 
            this.lblCadastroClienteEndereco.AutoSize = true;
            this.lblCadastroClienteEndereco.Location = new System.Drawing.Point(47, 160);
            this.lblCadastroClienteEndereco.Name = "lblCadastroClienteEndereco";
            this.lblCadastroClienteEndereco.Size = new System.Drawing.Size(70, 13);
            this.lblCadastroClienteEndereco.TabIndex = 39;
            this.lblCadastroClienteEndereco.Text = "ENDEREÇO:";
            // 
            // txtCadastroClienteEndereco
            // 
            this.txtCadastroClienteEndereco.Location = new System.Drawing.Point(215, 154);
            this.txtCadastroClienteEndereco.Name = "txtCadastroClienteEndereco";
            this.txtCadastroClienteEndereco.Size = new System.Drawing.Size(443, 20);
            this.txtCadastroClienteEndereco.TabIndex = 38;
            // 
            // lblCadastroClienteID
            // 
            this.lblCadastroClienteID.AutoSize = true;
            this.lblCadastroClienteID.Location = new System.Drawing.Point(50, 89);
            this.lblCadastroClienteID.Name = "lblCadastroClienteID";
            this.lblCadastroClienteID.Size = new System.Drawing.Size(21, 13);
            this.lblCadastroClienteID.TabIndex = 37;
            this.lblCadastroClienteID.Text = "ID:";
            // 
            // nudCadastroClienteID
            // 
            this.nudCadastroClienteID.Location = new System.Drawing.Point(73, 82);
            this.nudCadastroClienteID.Name = "nudCadastroClienteID";
            this.nudCadastroClienteID.ReadOnly = true;
            this.nudCadastroClienteID.Size = new System.Drawing.Size(75, 20);
            this.nudCadastroClienteID.TabIndex = 36;
            // 
            // lblCadastroClienteNome
            // 
            this.lblCadastroClienteNome.AutoSize = true;
            this.lblCadastroClienteNome.Location = new System.Drawing.Point(47, 126);
            this.lblCadastroClienteNome.Name = "lblCadastroClienteNome";
            this.lblCadastroClienteNome.Size = new System.Drawing.Size(42, 13);
            this.lblCadastroClienteNome.TabIndex = 35;
            this.lblCadastroClienteNome.Text = "NOME:";
            // 
            // txtCadastroClienteNome
            // 
            this.txtCadastroClienteNome.Location = new System.Drawing.Point(90, 120);
            this.txtCadastroClienteNome.Name = "txtCadastroClienteNome";
            this.txtCadastroClienteNome.Size = new System.Drawing.Size(460, 20);
            this.txtCadastroClienteNome.TabIndex = 34;
            // 
            // lblCadastroCliente
            // 
            this.lblCadastroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroCliente.Location = new System.Drawing.Point(47, 27);
            this.lblCadastroCliente.Name = "lblCadastroCliente";
            this.lblCadastroCliente.Size = new System.Drawing.Size(710, 40);
            this.lblCadastroCliente.TabIndex = 33;
            this.lblCadastroCliente.Text = "Cadastro Clientes";
            this.lblCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCadastroClienteEstado
            // 
            this.cboCadastroClienteEstado.FormattingEnabled = true;
            this.cboCadastroClienteEstado.Location = new System.Drawing.Point(712, 151);
            this.cboCadastroClienteEstado.Name = "cboCadastroClienteEstado";
            this.cboCadastroClienteEstado.Size = new System.Drawing.Size(48, 21);
            this.cboCadastroClienteEstado.TabIndex = 64;
            // 
            // lblCadastroClienteCpf
            // 
            this.lblCadastroClienteCpf.AutoSize = true;
            this.lblCadastroClienteCpf.Location = new System.Drawing.Point(314, 89);
            this.lblCadastroClienteCpf.Name = "lblCadastroClienteCpf";
            this.lblCadastroClienteCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCadastroClienteCpf.TabIndex = 65;
            this.lblCadastroClienteCpf.Text = "CPF:";
            // 
            // mtbCadastroClienteCpf
            // 
            this.mtbCadastroClienteCpf.Location = new System.Drawing.Point(347, 82);
            this.mtbCadastroClienteCpf.Mask = "999.999.999-99";
            this.mtbCadastroClienteCpf.Name = "mtbCadastroClienteCpf";
            this.mtbCadastroClienteCpf.Size = new System.Drawing.Size(82, 20);
            this.mtbCadastroClienteCpf.TabIndex = 66;
            // 
            // lblCadastroClienteRg
            // 
            this.lblCadastroClienteRg.AutoSize = true;
            this.lblCadastroClienteRg.Location = new System.Drawing.Point(439, 89);
            this.lblCadastroClienteRg.Name = "lblCadastroClienteRg";
            this.lblCadastroClienteRg.Size = new System.Drawing.Size(26, 13);
            this.lblCadastroClienteRg.TabIndex = 67;
            this.lblCadastroClienteRg.Text = "RG:";
            // 
            // txtCadastroClienteRg
            // 
            this.txtCadastroClienteRg.Location = new System.Drawing.Point(468, 82);
            this.txtCadastroClienteRg.Name = "txtCadastroClienteRg";
            this.txtCadastroClienteRg.Size = new System.Drawing.Size(100, 20);
            this.txtCadastroClienteRg.TabIndex = 68;
            // 
            // dgvCadastroCliente
            // 
            this.dgvCadastroCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCadastroCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NOME,
            this.CPF,
            this.RG,
            this.FILIACAO,
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
            this.LIMITE_DE_CREDITO,
            this.STATUS});
            this.dgvCadastroCliente.Location = new System.Drawing.Point(12, 252);
            this.dgvCadastroCliente.Name = "dgvCadastroCliente";
            this.dgvCadastroCliente.Size = new System.Drawing.Size(780, 191);
            this.dgvCadastroCliente.TabIndex = 69;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 43;
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.Width = 64;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.Width = 52;
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.Width = 48;
            // 
            // FILIACAO
            // 
            this.FILIACAO.HeaderText = "FILIAÇÃO";
            this.FILIACAO.Name = "FILIACAO";
            this.FILIACAO.Width = 79;
            // 
            // LOUGRADOURO
            // 
            this.LOUGRADOURO.HeaderText = "LOUGRADOURO";
            this.LOUGRADOURO.Name = "LOUGRADOURO";
            this.LOUGRADOURO.Width = 117;
            // 
            // ENDERECO
            // 
            this.ENDERECO.HeaderText = "ENDEREÇO";
            this.ENDERECO.Name = "ENDERECO";
            this.ENDERECO.Width = 92;
            // 
            // NUMERO
            // 
            this.NUMERO.HeaderText = "NÚMERO";
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.Width = 80;
            // 
            // COMPLEMENTO
            // 
            this.COMPLEMENTO.HeaderText = "COMPLEMENTO";
            this.COMPLEMENTO.Name = "COMPLEMENTO";
            this.COMPLEMENTO.Width = 115;
            // 
            // BAIRRO
            // 
            this.BAIRRO.HeaderText = "BAIRRO";
            this.BAIRRO.Name = "BAIRRO";
            this.BAIRRO.Width = 73;
            // 
            // CIDADE
            // 
            this.CIDADE.HeaderText = "CIDADE";
            this.CIDADE.Name = "CIDADE";
            this.CIDADE.Width = 72;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.Width = 76;
            // 
            // CEP
            // 
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.Width = 53;
            // 
            // TELEFONE
            // 
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.Width = 88;
            // 
            // CELULAR
            // 
            this.CELULAR.HeaderText = "CELULAR";
            this.CELULAR.Name = "CELULAR";
            this.CELULAR.Width = 81;
            // 
            // LIMITE_DE_CREDITO
            // 
            this.LIMITE_DE_CREDITO.HeaderText = "LIMITE DE CRÉDITO";
            this.LIMITE_DE_CREDITO.Name = "LIMITE_DE_CREDITO";
            this.LIMITE_DE_CREDITO.Width = 124;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.Width = 75;
            // 
            // txtClienteCidade
            // 
            this.txtClienteCidade.Location = new System.Drawing.Point(102, 226);
            this.txtClienteCidade.Name = "txtClienteCidade";
            this.txtClienteCidade.Size = new System.Drawing.Size(249, 20);
            this.txtClienteCidade.TabIndex = 109;
            // 
            // lblClienteCidade
            // 
            this.lblClienteCidade.AutoSize = true;
            this.lblClienteCidade.Location = new System.Drawing.Point(49, 231);
            this.lblClienteCidade.Name = "lblClienteCidade";
            this.lblClienteCidade.Size = new System.Drawing.Size(50, 13);
            this.lblClienteCidade.TabIndex = 108;
            this.lblClienteCidade.Text = "CIDADE:";
            // 
            // lblClienteBancoSituacao
            // 
            this.lblClienteBancoSituacao.AutoSize = true;
            this.lblClienteBancoSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteBancoSituacao.ForeColor = System.Drawing.Color.Red;
            this.lblClienteBancoSituacao.Location = new System.Drawing.Point(734, 7);
            this.lblClienteBancoSituacao.Name = "lblClienteBancoSituacao";
            this.lblClienteBancoSituacao.Size = new System.Drawing.Size(58, 13);
            this.lblClienteBancoSituacao.TabIndex = 111;
            this.lblClienteBancoSituacao.Text = "OFFLINE";
            // 
            // lblClienteBanco
            // 
            this.lblClienteBanco.AutoSize = true;
            this.lblClienteBanco.Location = new System.Drawing.Point(685, 7);
            this.lblClienteBanco.Name = "lblClienteBanco";
            this.lblClienteBanco.Size = new System.Drawing.Size(47, 13);
            this.lblClienteBanco.TabIndex = 110;
            this.lblClienteBanco.Text = "BANCO:";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 482);
            this.Controls.Add(this.lblClienteBancoSituacao);
            this.Controls.Add(this.lblClienteBanco);
            this.Controls.Add(this.txtClienteCidade);
            this.Controls.Add(this.lblClienteCidade);
            this.Controls.Add(this.dgvCadastroCliente);
            this.Controls.Add(this.txtCadastroClienteRg);
            this.Controls.Add(this.lblCadastroClienteRg);
            this.Controls.Add(this.mtbCadastroClienteCpf);
            this.Controls.Add(this.lblCadastroClienteCpf);
            this.Controls.Add(this.cboCadastroClienteEstado);
            this.Controls.Add(this.btnCadastroClienteCriar);
            this.Controls.Add(this.cboCadastroClienteStatus);
            this.Controls.Add(this.txtCadastroClienteLimiteCredito);
            this.Controls.Add(this.mtbCadastroClienteCelular);
            this.Controls.Add(this.lblCadastroClienteCelular);
            this.Controls.Add(this.txtCadastroClienteBairro);
            this.Controls.Add(this.lblCadastroClienteCep);
            this.Controls.Add(this.lblCadastroClienteEstado);
            this.Controls.Add(this.mtbCadastroClienteCep);
            this.Controls.Add(this.txtCadastroClienteComplemento);
            this.Controls.Add(this.txtCadastroClienteNumero);
            this.Controls.Add(this.lblCadastroClienteBairro);
            this.Controls.Add(this.lblCadastroClienteComplemento);
            this.Controls.Add(this.lblCadastroClienteNumero);
            this.Controls.Add(this.cboCadastroClienteLogadouro);
            this.Controls.Add(this.btnCadastroClienteDeletar);
            this.Controls.Add(this.btnCadastroClienteEditar);
            this.Controls.Add(this.btnCadastroClienteSalvar);
            this.Controls.Add(this.lblCadastroClienteLimiteCredito);
            this.Controls.Add(this.mtbCadastroClienteTelefone);
            this.Controls.Add(this.lblCadastroClienteTelefone);
            this.Controls.Add(this.lblCadastroClienteStatus);
            this.Controls.Add(this.lblCadastroClienteFiliacao);
            this.Controls.Add(this.txtCadastroClienteFiliacao);
            this.Controls.Add(this.lblCadastroClienteEndereco);
            this.Controls.Add(this.txtCadastroClienteEndereco);
            this.Controls.Add(this.lblCadastroClienteID);
            this.Controls.Add(this.nudCadastroClienteID);
            this.Controls.Add(this.lblCadastroClienteNome);
            this.Controls.Add(this.txtCadastroClienteNome);
            this.Controls.Add(this.lblCadastroCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCadastroClienteID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroClienteCriar;
        private System.Windows.Forms.Label lblCadastroClienteCelular;
        private System.Windows.Forms.Label lblCadastroClienteCep;
        private System.Windows.Forms.Label lblCadastroClienteEstado;
        private System.Windows.Forms.Label lblCadastroClienteBairro;
        private System.Windows.Forms.Label lblCadastroClienteComplemento;
        private System.Windows.Forms.Label lblCadastroClienteNumero;
        private System.Windows.Forms.Button btnCadastroClienteDeletar;
        private System.Windows.Forms.Button btnCadastroClienteEditar;
        private System.Windows.Forms.Button btnCadastroClienteSalvar;
        private System.Windows.Forms.Label lblCadastroClienteLimiteCredito;
        private System.Windows.Forms.Label lblCadastroClienteTelefone;
        private System.Windows.Forms.Label lblCadastroClienteStatus;
        private System.Windows.Forms.Label lblCadastroClienteFiliacao;
        private System.Windows.Forms.Label lblCadastroClienteEndereco;
        private System.Windows.Forms.Label lblCadastroClienteID;
        private System.Windows.Forms.Label lblCadastroClienteNome;
        private System.Windows.Forms.Label lblCadastroCliente;
        private System.Windows.Forms.Label lblCadastroClienteCpf;
        private System.Windows.Forms.Label lblCadastroClienteRg;
        private System.Windows.Forms.Label lblClienteCidade;
        private System.Windows.Forms.Label lblClienteBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn FILIACAO;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn LIMITE_DE_CREDITO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        public System.Windows.Forms.DataGridView dgvCadastroCliente;
        public System.Windows.Forms.ComboBox cboCadastroClienteStatus;
        public System.Windows.Forms.TextBox txtCadastroClienteLimiteCredito;
        public System.Windows.Forms.MaskedTextBox mtbCadastroClienteCelular;
        public System.Windows.Forms.TextBox txtCadastroClienteBairro;
        public System.Windows.Forms.MaskedTextBox mtbCadastroClienteCep;
        public System.Windows.Forms.TextBox txtCadastroClienteComplemento;
        public System.Windows.Forms.TextBox txtCadastroClienteNumero;
        public System.Windows.Forms.ComboBox cboCadastroClienteLogadouro;
        public System.Windows.Forms.MaskedTextBox mtbCadastroClienteTelefone;
        public System.Windows.Forms.TextBox txtCadastroClienteFiliacao;
        public System.Windows.Forms.TextBox txtCadastroClienteEndereco;
        public System.Windows.Forms.TextBox txtCadastroClienteNome;
        public System.Windows.Forms.ComboBox cboCadastroClienteEstado;
        public System.Windows.Forms.MaskedTextBox mtbCadastroClienteCpf;
        public System.Windows.Forms.TextBox txtCadastroClienteRg;
        public System.Windows.Forms.TextBox txtClienteCidade;
        public System.Windows.Forms.Label lblClienteBancoSituacao;
        public System.Windows.Forms.NumericUpDown nudCadastroClienteID;
    }
}