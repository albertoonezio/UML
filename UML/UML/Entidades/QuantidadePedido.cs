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
        public int ID { get; set; }
        public DateTime Data_Pedido { get; set; }
        public string Status_Quantidade { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual int PedidoId { get; set; }

        public void VerificarEstoque()
        {

        }
    }
}
