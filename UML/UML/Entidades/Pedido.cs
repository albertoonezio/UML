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
        public int Id { get; set; }
        public DateTime DataElaboracao { get; set; }
        public double Quantidade { get; set; }
        public double Valor_Total { get; set; }
        public string Status_Pedido { get; set; }
        public virtual Cliente cliente { get; set; }
        public virtual int ClienteId { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual int ProdutoId { get; set; }
        //public virtual IList<Produto> Produtos { get; set; }

        public void Criar(int id, double quantidade)
        {

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
