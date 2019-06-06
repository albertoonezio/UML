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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void btnCadastroPedidoCriar_Click(object sender, EventArgs e)
        {
            int id = 0;
            double quantidade = Convert.ToDouble(txtPedidoNomeCliente.Text);
            Pedido pedido = new Pedido();
            pedido.Criar(id, quantidade);
        }
    }
}
