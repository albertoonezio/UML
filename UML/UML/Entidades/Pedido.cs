using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML.Entidade
{
    public class Pedido
    {
        private int id { get; set; }
        public DateTime dataElaboracao { get; set; }
        public double quantidade { get; set; }
        public Cliente cliente { get; set; }

        public void Criar(int id, double quantidade)
        {
            frmPedido pedido = new frmPedido();
            List<Pedido> listaPedido = new List<Pedido>();
            listaPedido.Add(new Pedido() { id = id, quantidade = quantidade });
            pedido.dgvCadastroPedido.DataSource = listaPedido;
            pedido.dgvCadastroPedido.Rows[0].Cells[0].Value = id;
        }

        public void Incluir(string produto)
        {

        }

        public void Retirar(int idProduto)
        {

        }

        public void Verificar(int idProduto)
        {

        }

        public void CalcularValorTotal(double valor)
        {

        }

        public void FecharPedido()
        {

        }

        public void Status(int idProduto)
        {

        }
    }
}
