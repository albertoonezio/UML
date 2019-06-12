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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            txtProdutoNome.Enabled = false;
            txtProdutoFornecedor.Enabled = false;
            txtProdutoValorUnidade.Enabled = false;
            nudProdutoQuantidade.Enabled = false;
            mtbProdutoDataFabricacao.Enabled = false;
            mtbProdutoDataAdicao.Enabled = false;
            mtbProdutoDataVencimento.Enabled = false;
            cboProdutoStatus.Enabled = false;
            cboProdutoCategoria.Enabled = false;
        }

        private void btnProdutoCriar_Click(object sender, EventArgs e)
        {
            txtProdutoNome.Enabled = true;
            txtProdutoFornecedor.Enabled = true;
            txtProdutoValorUnidade.Enabled = true;
            nudProdutoQuantidade.Enabled = true;
            mtbProdutoDataFabricacao.Enabled = true;
            mtbProdutoDataAdicao.Enabled = true;
            mtbProdutoDataVencimento.Enabled = true;
            cboProdutoStatus.Enabled = true;
            cboProdutoCategoria.Enabled = true;
        }

        private void btnProdutoSalvar_Click(object sender, EventArgs e)
        {
            ManipuladorProduto manipular = new ManipuladorProduto();
            Produto produto = new Produto()
            {
                Nome = txtProdutoNome.Text,
                Data_Adicao = Convert.ToDateTime(mtbProdutoDataAdicao.Text),
                Data_Fabricacao = Convert.ToDateTime(mtbProdutoDataFabricacao.Text),
                Data_Vencimento = Convert.ToDateTime(mtbProdutoDataVencimento.Text),
                Valor = Convert.ToDouble(txtProdutoValorUnidade.Text),
                Quantidade = Convert.ToDouble(nudProdutoQuantidade.Value),
                Categoria = cboProdutoCategoria.Text,
                Status_Produto = cboProdutoStatus.Text
            };

            manipular.Salvar(produto);
        }

        public void preencherDataGrid()
        {
            try
            {
                EntidadesContext contexto = new EntidadesContext();
                int i = 0;
                var retornarDados = from d in contexto.Produto
                                    select d;

                int total = retornarDados.Count();
                nudProdutoID.Maximum = total;

                foreach (var item in retornarDados)
                {
                    dgvProdutos.Rows.Add(new object[]
                    {
                    dgvProdutos.Rows[i].Cells["ID"].Value = item.Id,
                    dgvProdutos.Rows[i].Cells["NOME"].Value = item.Nome,
                    dgvProdutos.Rows[i].Cells["CATEGORIA"].Value = item.Categoria,
                    dgvProdutos.Rows[i].Cells["DATA_ADICAO"].Value = item.Data_Adicao,
                    dgvProdutos.Rows[i].Cells["DATA_FABRICACAO"].Value = item.Data_Fabricacao,
                    dgvProdutos.Rows[i].Cells["DATA_VENCIMENTO"].Value = item.Data_Vencimento,
                    dgvProdutos.Rows[i].Cells["FORNECEDOR"].Value = item.Fornecedor,
                    dgvProdutos.Rows[i].Cells["QUANTIDADE"].Value = item.Quantidade,
                    dgvProdutos.Rows[i].Cells["VALOR"].Value = item.Valor,
                    dgvProdutos.Rows[i].Cells["STATUS_CLIENTE"].Value = item.Status_Produto
                    });
                    i++;
                }

                dgvProdutos.RowCount = total;
                dgvProdutos.Update();
                dgvProdutos.Refresh();

                lblProdutoBancoSituacao.Text = "ONLINE";
                lblProdutoBancoSituacao.ForeColor = Color.ForestGreen;
            }
            catch (Exception)
            {

                MessageBox.Show("Banco de Dados não conectado");
                lblProdutoBancoSituacao.Text = "OFFLINE";
                lblProdutoBancoSituacao.ForeColor = Color.Red;
            }
        }
    }
}
