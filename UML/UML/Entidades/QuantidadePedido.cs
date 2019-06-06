using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML.Entidade;

namespace UML
{
    public class QuantidadePedido
    {
        public int quantidade { get; set; }
        public string nome { get; set; }
        public Pedido pedido { get; set; }

        public void VerificarEstoque()
        {

        }
    }
}
