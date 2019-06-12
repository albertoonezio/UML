using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML.Entidade;

namespace UML
{
    public class ManipuladorCliente
    {
        private EntidadesContext contexto;

        public ManipuladorCliente()
        {
            contexto = new EntidadesContext();
        }

        public void Salvar(Cliente cliente)
        {
            contexto.Cliente.Add(cliente);
            contexto.SaveChanges();

            MessageBox.Show("Cliente cadastrado com sucesso!");
        }

        public void BuscaPorId(int id)
        {
            var cliente = contexto.Cliente.FirstOrDefault(c => c.ID == id);
            MessageBox.Show(cliente.Nome);
        }

        public void Remover(Cliente cliente)
        {
            contexto.Cliente.Remove(cliente);
            contexto.SaveChanges();

            MessageBox.Show("Cliente removido com sucesso!");
        }
    }
}
