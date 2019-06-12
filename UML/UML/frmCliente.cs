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
using UML.Entidade;

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
            mtbCadastroClienteRg.Enabled = false;
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

            preencherDataGrid();
        }

        private void btnCadastroClienteCriar_Click(object sender, EventArgs e)
        {
            mtbCadastroClienteCpf.Enabled = true;
            mtbCadastroClienteRg.Enabled = true;
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
            ManipuladorCliente manipular = new ManipuladorCliente();
            Cliente cliente = new Cliente()
            {
                Nome = txtCadastroClienteNome.Text,
                Lougradouro = cboCadastroClienteLogadouro.Text,
                Endereco = txtCadastroClienteEndereco.Text,
                Numero = txtCadastroClienteNumero.Text,
                Complemento = txtCadastroClienteComplemento.Text,
                Bairro = txtCadastroClienteBairro.Text,
                Cep = mtbCadastroClienteCep.Text,
                Estado = cboCadastroClienteEstado.Text,
                Telefone = mtbCadastroClienteTelefone.Text,
                Celular = mtbCadastroClienteCelular.Text,
                Filiacao = txtCadastroClienteFiliacao.Text,
                Status_Cliente = cboCadastroClienteStatus.Text,
                Limite_De_Credito = txtCadastroClienteLimiteCredito.Text,
                Cpf = mtbCadastroClienteCpf.Text,
                Rg = mtbCadastroClienteRg.Text,
                Cidade = txtClienteCidade.Text
            };

            manipular.Salvar(cliente);

            preencherDataGrid();
        }

        private void btnCadastroClienteEditar_Click(object sender, EventArgs e)
        {
            nudCadastroClienteID.ReadOnly = false;
            mtbCadastroClienteCpf.Enabled = true;
            mtbCadastroClienteRg.Enabled = true;
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

        private void btnCadastroClienteDeletar_Click(object sender, EventArgs e)
        {
            EntidadesContext contexto = new EntidadesContext();
            ManipuladorCliente manipulador = new ManipuladorCliente();

            int buscaId = Convert.ToInt32(nudCadastroClienteID.Value);

            var busca = from b in contexto.Cliente
                        where b.ID == buscaId
                        select b;

            foreach (var item in busca)
            {
                manipulador.Remover(item);
            }

            preencherDataGrid();
        }

        private void nudCadastroClienteID_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                EntidadesContext contexto = new EntidadesContext();
                int buscaId = Convert.ToInt32(nudCadastroClienteID.Value);

                var busca = from b in contexto.Cliente
                            where b.ID == buscaId
                            select new
                            {
                                b.ID,
                                b.Nome,
                                b.Lougradouro,
                                b.Endereco,
                                b.Numero,
                                b.Complemento,
                                b.Bairro,
                                b.Cidade,
                                b.Estado,
                                b.Cep,
                                b.Telefone,
                                b.Celular,
                                b.Filiacao,
                                b.Status_Cliente,
                                b.Cpf,
                                b.Rg,
                                b.Limite_De_Credito
                            };

                foreach (var cliente in busca)
                {
                    nudCadastroClienteID.Value = cliente.ID;
                    txtCadastroClienteNome.Text = cliente.Nome;
                    cboCadastroClienteLogadouro.Text = cliente.Lougradouro;
                    txtCadastroClienteEndereco.Text = cliente.Endereco;
                    txtCadastroClienteNumero.Text = cliente.Numero;
                    txtCadastroClienteComplemento.Text = cliente.Complemento;
                    txtCadastroClienteBairro.Text = cliente.Bairro;
                    txtClienteCidade.Text = cliente.Cidade;
                    cboCadastroClienteEstado.Text = cliente.Estado;
                    mtbCadastroClienteCep.Text = cliente.Cep;
                    mtbCadastroClienteTelefone.Text = cliente.Telefone;
                    mtbCadastroClienteCelular.Text = cliente.Celular;
                    txtCadastroClienteFiliacao.Text = cliente.Filiacao;
                    cboCadastroClienteStatus.Text = cliente.Status_Cliente;
                    txtCadastroClienteLimiteCredito.Text = cliente.Limite_De_Credito;
                    mtbCadastroClienteCpf.Text = cliente.Cpf;
                    mtbCadastroClienteRg.Text = cliente.Rg;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Dados não carregados");
            }
        }

        public void validarDados()
        {
            DataSet dts = new DataSet();
            dgvCadastroCliente.DataSource = dts.Tables["Cliente"];
        }

        public void preencherDataGrid()
        {
            try
            {
                EntidadesContext contexto = new EntidadesContext();
                int i = 0;
                var retornarDados = from d in contexto.Cliente
                                    select d;

                int total = retornarDados.Count();
                nudCadastroClienteID.Maximum = total;

                foreach (var item in retornarDados)
                {
                    dgvCadastroCliente.Rows.Add(new object[]
                    {
                    dgvCadastroCliente.Rows[i].Cells["ID"].Value = item.ID,
                    dgvCadastroCliente.Rows[i].Cells["NOME"].Value = item.Nome,
                    dgvCadastroCliente.Rows[i].Cells["FILIACAO"].Value = item.Filiacao,
                    dgvCadastroCliente.Rows[i].Cells["CPF"].Value = item.Cpf,
                    dgvCadastroCliente.Rows[i].Cells["RG"].Value = item.Rg,
                    dgvCadastroCliente.Rows[i].Cells["LOUGRADOURO"].Value = item.Lougradouro,
                    dgvCadastroCliente.Rows[i].Cells["ENDERECO"].Value = item.Endereco,
                    dgvCadastroCliente.Rows[i].Cells["NUMERO"].Value = item.Numero,
                    dgvCadastroCliente.Rows[i].Cells["COMPLEMENTO"].Value = item.Complemento,
                    dgvCadastroCliente.Rows[i].Cells["BAIRRO"].Value = item.Bairro,
                    dgvCadastroCliente.Rows[i].Cells["CIDADE"].Value = item.Cidade,
                    dgvCadastroCliente.Rows[i].Cells["ESTADO"].Value = item.Estado,
                    dgvCadastroCliente.Rows[i].Cells["CEP"].Value = item.Cep,
                    dgvCadastroCliente.Rows[i].Cells["TELEFONE"].Value = item.Telefone,
                    dgvCadastroCliente.Rows[i].Cells["CELULAR"].Value = item.Celular,
                    dgvCadastroCliente.Rows[i].Cells["LIMITE_DE_CREDITO"].Value = item.Limite_De_Credito,
                    dgvCadastroCliente.Rows[i].Cells["STATUS_CLIENTE"].Value = item.Status_Cliente
                    });
                    i++;
                }

                dgvCadastroCliente.RowCount = total;
                dgvCadastroCliente.Refresh();

                lblClienteBancoSituacao.Text = "ONLINE";
                lblClienteBancoSituacao.ForeColor = Color.ForestGreen;
            }
            catch (Exception)
            {

                MessageBox.Show("Banco de Dados não conectado");
                lblClienteBancoSituacao.Text = "OFFLINE";
                lblClienteBancoSituacao.ForeColor = Color.Red;
            }
        }
    }
}