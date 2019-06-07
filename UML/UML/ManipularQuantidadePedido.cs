using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML.Entidade;

namespace UML
{
    public class ManipularQuantidadePedido
    {
        private EntidadesContext contexto;

        public ManipularQuantidadePedido()
        {
            contexto = new EntidadesContext();
        }

        public void Salvar(QuantidadePedido quantidade)
        {
            contexto.QuantidadePedido.Add(quantidade);
            contexto.SaveChanges();

            MessageBox.Show("Pedido cadastrado com sucesso!");
        }
    }
}
