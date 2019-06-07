﻿using System;
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
            ValidarCampos validar = new ValidarCampos();
            validar.ValidarCliente(
                Convert.ToInt32(nudCadastroClienteID.Value),
                txtCadastroClienteNome.Text,
                cboCadastroClienteLogadouro.Text,
                txtCadastroClienteEndereco.Text,
                txtCadastroClienteNumero.Text,
                txtCadastroClienteComplemento.Text,
                txtCadastroClienteBairro.Text,
                mtbCadastroClienteCep.Text,
                cboCadastroClienteEstado.Text,
                mtbCadastroClienteTelefone.Text,
                mtbCadastroClienteCelular.Text,
                txtCadastroClienteFiliacao.Text,
                cboCadastroClienteStatus.Text,
                txtCadastroClienteLimiteCredito.Text,
                mtbCadastroClienteCpf.Text,
                mtbCadastroClienteRg.Text,
                txtClienteCidade.Text
                );

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
                Limite_De_Credito = Convert.ToDouble(txtCadastroClienteLimiteCredito.Text),
                Cpf = mtbCadastroClienteCpf.Text,
                Rg = mtbCadastroClienteRg.Text,
                Cidade = txtClienteCidade.Text
            };

            manipular.Salvar(cliente);
        }

        private void btnCadastroClienteEditar_Click(object sender, EventArgs e)
        {
            ManipuladorCliente manipular = new ManipuladorCliente();
            Cliente cliente = manipular.BuscaPorID(1);

            //nudCadastroClienteID.Value = 1;
            txtCadastroClienteNome.Text = cliente.Nome;
            cboCadastroClienteLogadouro.Text = cliente.Lougradouro;
            txtCadastroClienteEndereco.Text = cliente.Endereco;
            txtCadastroClienteNumero.Text = cliente.Numero;
            txtCadastroClienteComplemento.Text = cliente.Complemento;
            txtCadastroClienteBairro.Text = cliente.Bairro;
            mtbCadastroClienteCep.Text = cliente.Cep;
            cboCadastroClienteEstado.Text = cliente.Estado;
            mtbCadastroClienteTelefone.Text = cliente.Telefone;
            mtbCadastroClienteCelular.Text = cliente.Celular;
            txtCadastroClienteFiliacao.Text = cliente.Filiacao;
            cboCadastroClienteStatus.Text = cliente.Status_Cliente;
            txtCadastroClienteLimiteCredito.Text = Convert.ToString(cliente.Limite_De_Credito);
            mtbCadastroClienteCpf.Text = cliente.Cpf;
            mtbCadastroClienteRg.Text = cliente.Rg;
            txtClienteCidade.Text = cliente.Cidade;
        }

        private void btnCadastroClienteDeletar_Click(object sender, EventArgs e)
        {

        }
    }
}
