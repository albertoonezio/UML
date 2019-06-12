using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML.Entidade;

namespace UML
{
    public class ManipuladorProduto
    {
        private EntidadesContext contexto;

        public ManipuladorProduto()
        {
            contexto = new EntidadesContext();
        }

        public void Salvar(Produto produto)
        {
            contexto.Produto.Add(produto);
            contexto.SaveChanges();

            MessageBox.Show("Produto cadastrado com sucesso!");
        }

        public void Remover(Produto produto)
        {
            contexto.Cliente.Remove(produto);
            contexto.SaveChanges();

            MessageBox.Show("Produto removido com sucesso!");
        }
    }
}
