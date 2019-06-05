using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            mtbCadastroClienteCpf.Enabled = false;
            txtCadastroClienteRg.Enabled = false;
            cboCadastroClienteStatus.Enabled = false;
            txtCadastroClienteNome.Enabled = false;
            txtCadastroClienteFiliacao.Enabled = false;
            cboCadastroClienteLogadouro.Enabled = false;
            txtCadastroClienteEndereco.Enabled = false;
            cboCadastroClienteEstado.Enabled = false;
            txtCadastroClienteNumero.Enabled = false;
            txtCadastroClienteComplemento.Enabled = false;
            txtCadastroClienteBairro.Enabled = false;
            txtClienteCidade.Enabled = false;
            mtbCadastroClienteCep.Enabled = false;
            mtbCadastroClienteTelefone.Enabled = false;
            mtbCadastroClienteCelular.Enabled = false;
            txtCadastroClienteLimiteCredito.Enabled = false;

            try
            {
                string connectionString = "Provider=SQLNCLI11;Data Source=SQEST112\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CONTROLE_GERAL";
                SqlConnection sqlConn = new SqlConnection(connectionString); 

                sqlConn.Open();

                //criando o select e o objeto de consulta
                string sql = "select * from clientes";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Connection = sqlConn;
                cmd.CommandText = sql;

                // cria o dataadapter...
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                // preenche o dataset...
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                dgvCadastroCliente.DataSource = dataSet;
                dgvCadastroCliente.DataMember = dataSet.Tables[0].TableName;
                sqlConn.Close();

                lblClienteBancoSituacao.Text = "ONLINE";
                lblClienteBancoSituacao.ForeColor = Color.ForestGreen;
            }
            catch (Exception ex)
            {

                lblClienteBancoSituacao.Text = "OFFLINE";
                lblClienteBancoSituacao.ForeColor = Color.Red;
                MessageBox.Show("Banco Não Conectado" + ex.Message);
            }
        }

        private void btnCadastroClienteCriar_Click(object sender, EventArgs e)
        {
            mtbCadastroClienteCpf.Enabled = true;
            txtCadastroClienteRg.Enabled = true;
            cboCadastroClienteStatus.Enabled = true;
            txtCadastroClienteNome.Enabled = true;
            txtCadastroClienteFiliacao.Enabled = true;
            cboCadastroClienteLogadouro.Enabled = true;
            txtCadastroClienteEndereco.Enabled = true;
            cboCadastroClienteEstado.Enabled = true;
            txtCadastroClienteNumero.Enabled = true;
            txtCadastroClienteComplemento.Enabled = true;
            txtCadastroClienteBairro.Enabled = true;
            txtClienteCidade.Enabled = true;
            mtbCadastroClienteCep.Enabled = true;
            mtbCadastroClienteTelefone.Enabled = true;
            mtbCadastroClienteCelular.Enabled = true;
            txtCadastroClienteLimiteCredito.Enabled = true;
        }

        private void btnCadastroClienteSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtCadastroClienteNome.Text;
            string lougradouro = cboCadastroClienteLogadouro.Text;
            string endereco = txtCadastroClienteEndereco.Text;
            string numero = txtCadastroClienteNumero.Text;
            string complemento = txtCadastroClienteComplemento.Text;
            string bairro = txtCadastroClienteBairro.Text;
            string cep = mtbCadastroClienteCep.Text;
            string estado = cboCadastroClienteEstado.Text;
            string telefone = mtbCadastroClienteTelefone.Text;
            string celular = mtbCadastroClienteCelular.Text;
            string filiacao = txtCadastroClienteFiliacao.Text;
            string status = cboCadastroClienteStatus.Text;
            string limiteDeCredito = txtCadastroClienteLimiteCredito.Text;
            string cpf = mtbCadastroClienteCpf.Text;
            string rg = txtCadastroClienteRg.Text;
            string cidade = txtClienteCidade.Text;

            Cliente cliente = new Cliente();
            cliente.Cadastrar(nome, lougradouro, endereco, numero, complemento, bairro, cep, estado, telefone, celular, filiacao, status, limiteDeCredito, cpf, rg, cidade);
        }

        private void btnCadastroClienteEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastroClienteDeletar_Click(object sender, EventArgs e)
        {

        }
    }
}
