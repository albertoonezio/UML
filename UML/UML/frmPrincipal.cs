using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnControleGeralCliente_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();
        }

        private void btnControleGeralFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedor fornecedor = new frmFornecedor();
            fornecedor.Show();
        }

        private void btnControleGeralProduto_Click(object sender, EventArgs e)
        {
            frmProduto produto = new frmProduto();
            produto.Show();
        }

        private void btnControleGeralPedido_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido();
            pedido.Show();
        }
    }
}
