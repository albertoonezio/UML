using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML.Entidade;

namespace UML.Entidade
{
    public class QuantidadePedido
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public string Nome { get; set; }
        public virtual Pedido Pedido { get; set; }
        public int PedidoId { get; set; }

        public void VerificarEstoque()
        {

        }
    }
}
