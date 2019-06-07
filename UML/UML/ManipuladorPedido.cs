using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML.Entidade;

namespace UML
{
    public class ManipuladorPedido
    {
        private EntidadesContext contexto;

        public ManipuladorPedido()
        {
            contexto = new EntidadesContext();
        }

        public void Salvar(Pedido pedido)
        {
            contexto.Pedido.Add(pedido);
            contexto.SaveChanges();

            MessageBox.Show("Pedido cadastrado com sucesso!");
        }
    }
}
