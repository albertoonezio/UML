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
    }
}
