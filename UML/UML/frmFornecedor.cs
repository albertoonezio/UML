using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML.Entidade;

namespace UML
{
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            mtbFornecedorCnpj.Enabled = false;
            cboFornecedorStatus.Enabled = false;
            txtFornecedorNome.Enabled = false;
            cboFornecedorLogadouro.Enabled = false;
            txtFornecedorEndereco.Enabled = false;
            cboFornecedorEstado.Enabled = false;
            txtFornecedorNumero.Enabled = false;
            txtFornecedorComplemento.Enabled = false;
            txtFornecedorBairro.Enabled = false;
            txtFornecedorCidade.Enabled = false;
            mtbFornecedorCep.Enabled = false;
            mtbFornecedorTelefone.Enabled = false;
            mtbFornecedorCelular.Enabled = false;
        }

        private void btnFornecedorCriar_Click(object sender, EventArgs e)
        {
            mtbFornecedorCnpj.Enabled = true;
            cboFornecedorStatus.Enabled = true;
            txtFornecedorNome.Enabled = true;
            cboFornecedorLogadouro.Enabled = true;
            txtFornecedorEndereco.Enabled = true;
            cboFornecedorEstado.Enabled = true;
            txtFornecedorNumero.Enabled = true;
            txtFornecedorComplemento.Enabled = true;
            txtFornecedorBairro.Enabled = true;
            txtFornecedorCidade.Enabled = true;
            mtbFornecedorCep.Enabled = true;
            mtbFornecedorTelefone.Enabled = true;
            mtbFornecedorCelular.Enabled = true;
        }

        private void btnFornecedorSalvar_Click(object sender, EventArgs e)
        {
            ManipuladorFornecedor manipular = new ManipuladorFornecedor();
            Fornecedor fornecedor = new Fornecedor()
            {
                Nome = txtFornecedorNome.Text,
                Lougradouro = cboFornecedorLogadouro.Text,
                Endereco = txtFornecedorEndereco.Text,
                Numero = txtFornecedorNumero.Text,
                Complemento = txtFornecedorComplemento.Text,
                Bairro = txtFornecedorBairro.Text,
                Cep = mtbFornecedorCep.Text,
                Estado = cboFornecedorEstado.Text,
                Telefone = mtbFornecedorTelefone.Text,
                Celular = mtbFornecedorCelular.Text,
                Status_Fornecedor = cboFornecedorStatus.Text,
                Cnpj = mtbFornecedorCnpj.Text,
                Cidade = txtFornecedorCidade.Text
            };

            manipular.Salvar(fornecedor);
        }
    }
}
