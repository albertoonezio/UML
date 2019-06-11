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
            this.components = new System.ComponentModel.Container();
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
            this.dgvCadastroCliente = new System.Windows.Forms.DataGridView();
            this.txtClienteCidade = new System.Windows.Forms.TextBox();
            this.lblClienteCidade = new System.Windows.Forms.Label();
            this.lblClienteBancoSituacao = new System.Windows.Forms.Label();
            this.lblClienteBanco = new System.Windows.Forms.Label();
            this.mtbCadastroClienteRg = new System.Windows.Forms.MaskedTextBox();
            this.controle_GeralDataSet = new UML.Controle_GeralDataSet();
            this.controleGeralDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filiacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lougradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite_De_Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudCadastroClienteID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_GeralDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleGeralDataSetBindingSource)).BeginInit();
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
            this.cboCadastroClienteStatus.TabIndex = 2;
            // 
            // txtCadastroClienteLimiteCredito
            // 
            this.txtCadastroClienteLimiteCredito.Location = new System.Drawing.Point(162, 453);
            this.txtCadastroClienteLimiteCredito.Name = "txtCadastroClienteLimiteCredito";
            this.txtCadastroClienteLimiteCredito.Size = new System.Drawing.Size(134, 20);
            this.txtCadastroClienteLimiteCredito.TabIndex = 15;
            // 
            // mtbCadastroClienteCelular
            // 
            this.mtbCadastroClienteCelular.Location = new System.Drawing.Point(672, 226);
            this.mtbCadastroClienteCelular.Mask = "(99) 9 0000-0000";
            this.mtbCadastroClienteCelular.Name = "mtbCadastroClienteCelular";
            this.mtbCadastroClienteCelular.Size = new System.Drawing.Size(88, 20);
            this.mtbCadastroClienteCelular.TabIndex = 14;
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
            this.txtCadastroClienteBairro.TabIndex = 9;
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
            this.mtbCadastroClienteCep.TabIndex = 12;
            // 
            // txtCadastroClienteComplemento
            // 
            this.txtCadastroClienteComplemento.Location = new System.Drawing.Point(310, 189);
            this.txtCadastroClienteComplemento.Name = "txtCadastroClienteComplemento";
            this.txtCadastroClienteComplemento.Size = new System.Drawing.Size(218, 20);
            this.txtCadastroClienteComplemento.TabIndex = 8;
            // 
            // txtCadastroClienteNumero
            // 
            this.txtCadastroClienteNumero.Location = new System.Drawing.Point(110, 189);
            this.txtCadastroClienteNumero.Name = "txtCadastroClienteNumero";
            this.txtCadastroClienteNumero.Size = new System.Drawing.Size(100, 20);
            this.txtCadastroClienteNumero.TabIndex = 7;
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
            this.cboCadastroClienteLogadouro.TabIndex = 5;
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
            this.btnCadastroClienteSalvar.TabIndex = 16;
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
            this.mtbCadastroClienteTelefone.TabIndex = 13;
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
            this.txtCadastroClienteFiliacao.TabIndex = 4;
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
            this.txtCadastroClienteEndereco.TabIndex = 6;
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
            this.nudCadastroClienteID.ValueChanged += new System.EventHandler(this.nudCadastroClienteID_ValueChanged);
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
            this.txtCadastroClienteNome.TabIndex = 3;
            // 
            // lblCadastroCliente
            // 
            this.lblCadastroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroCliente.Location = new System.Drawing.Point(47, 27);
            this.lblCadastroCliente.Name = "lblCadastroCliente";
            this.lblCadastroCliente.Size = new System.Drawing.Size(710, 40);
            this.lblCadastroCliente.TabIndex = 0;
            this.lblCadastroCliente.Text = "Cadastro Clientes";
            this.lblCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCadastroClienteEstado
            // 
            this.cboCadastroClienteEstado.FormattingEnabled = true;
            this.cboCadastroClienteEstado.Location = new System.Drawing.Point(712, 151);
            this.cboCadastroClienteEstado.Name = "cboCadastroClienteEstado";
            this.cboCadastroClienteEstado.Size = new System.Drawing.Size(48, 21);
            this.cboCadastroClienteEstado.TabIndex = 11;
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
            this.mtbCadastroClienteCpf.TabIndex = 0;
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
            // dgvCadastroCliente
            // 
            this.dgvCadastroCliente.AllowUserToDeleteRows = false;
            this.dgvCadastroCliente.AllowUserToResizeColumns = false;
            this.dgvCadastroCliente.AllowUserToResizeRows = false;
            this.dgvCadastroCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCadastroCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvCadastroCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Filiacao,
            this.Cpf,
            this.Rg,
            this.Lougradouro,
            this.Endereco,
            this.Numero,
            this.Complemento,
            this.Bairro,
            this.Cidade,
            this.Estado,
            this.Cep,
            this.Telefone,
            this.Celular,
            this.Limite_De_Credito,
            this.Status_Cliente});
            this.dgvCadastroCliente.Location = new System.Drawing.Point(12, 252);
            this.dgvCadastroCliente.Name = "dgvCadastroCliente";
            this.dgvCadastroCliente.ReadOnly = true;
            this.dgvCadastroCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCadastroCliente.Size = new System.Drawing.Size(780, 191);
            this.dgvCadastroCliente.TabIndex = 69;
            // 
            // txtClienteCidade
            // 
            this.txtClienteCidade.Location = new System.Drawing.Point(102, 226);
            this.txtClienteCidade.Name = "txtClienteCidade";
            this.txtClienteCidade.Size = new System.Drawing.Size(249, 20);
            this.txtClienteCidade.TabIndex = 10;
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
            // mtbCadastroClienteRg
            // 
            this.mtbCadastroClienteRg.Location = new System.Drawing.Point(468, 82);
            this.mtbCadastroClienteRg.Mask = "000.000-000";
            this.mtbCadastroClienteRg.Name = "mtbCadastroClienteRg";
            this.mtbCadastroClienteRg.Size = new System.Drawing.Size(71, 20);
            this.mtbCadastroClienteRg.TabIndex = 112;
            // 
            // controle_GeralDataSet
            // 
            this.controle_GeralDataSet.DataSetName = "Controle_GeralDataSet";
            this.controle_GeralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controleGeralDataSetBindingSource
            // 
            this.controleGeralDataSetBindingSource.DataSource = this.controle_GeralDataSet;
            this.controleGeralDataSetBindingSource.Position = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "NOME";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 64;
            // 
            // Filiacao
            // 
            this.Filiacao.HeaderText = "FILIAÇÃO";
            this.Filiacao.Name = "Filiacao";
            this.Filiacao.ReadOnly = true;
            this.Filiacao.Width = 79;
            // 
            // Cpf
            // 
            this.Cpf.HeaderText = "CPF";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            this.Cpf.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cpf.Width = 52;
            // 
            // Rg
            // 
            this.Rg.HeaderText = "RG";
            this.Rg.Name = "Rg";
            this.Rg.ReadOnly = true;
            this.Rg.Width = 48;
            // 
            // Lougradouro
            // 
            this.Lougradouro.HeaderText = "LOUGRADOURO";
            this.Lougradouro.Name = "Lougradouro";
            this.Lougradouro.ReadOnly = true;
            this.Lougradouro.Width = 117;
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "ENDEREÇO";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Width = 92;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "NÚMERO";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 80;
            // 
            // Complemento
            // 
            this.Complemento.HeaderText = "COMPLEMENTO";
            this.Complemento.Name = "Complemento";
            this.Complemento.ReadOnly = true;
            this.Complemento.Width = 115;
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "BAIRRO";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Width = 73;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "CIDADE";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Width = 72;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "ESTADO";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 76;
            // 
            // Cep
            // 
            this.Cep.HeaderText = "CEP";
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            this.Cep.Width = 53;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "TELEFONE";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 88;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "CELULAR";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 81;
            // 
            // Limite_De_Credito
            // 
            this.Limite_De_Credito.HeaderText = "LIMITE DE CRÉDITO";
            this.Limite_De_Credito.Name = "Limite_De_Credito";
            this.Limite_De_Credito.ReadOnly = true;
            this.Limite_De_Credito.Width = 124;
            // 
            // Status_Cliente
            // 
            this.Status_Cliente.HeaderText = "STATUS";
            this.Status_Cliente.Name = "Status_Cliente";
            this.Status_Cliente.ReadOnly = true;
            this.Status_Cliente.Width = 75;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 482);
            this.Controls.Add(this.mtbCadastroClienteRg);
            this.Controls.Add(this.lblClienteBancoSituacao);
            this.Controls.Add(this.lblClienteBanco);
            this.Controls.Add(this.txtClienteCidade);
            this.Controls.Add(this.lblClienteCidade);
            this.Controls.Add(this.dgvCadastroCliente);
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
            this.Shown += new System.EventHandler(this.frmCliente_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudCadastroClienteID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_GeralDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleGeralDataSetBindingSource)).EndInit();
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
        public System.Windows.Forms.TextBox txtClienteCidade;
        public System.Windows.Forms.Label lblClienteBancoSituacao;
        public System.Windows.Forms.NumericUpDown nudCadastroClienteID;
        public System.Windows.Forms.MaskedTextBox mtbCadastroClienteRg;
        private System.Windows.Forms.BindingSource controleGeralDataSetBindingSource;
        private Controle_GeralDataSet controle_GeralDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filiacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lougradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite_De_Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Cliente;
    }
}