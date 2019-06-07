using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML.Entidade;

namespace UML
{
    class ManipuladorFornecedor
    {
        private EntidadesContext contexto;

        public ManipuladorFornecedor()
        {
            contexto = new EntidadesContext();
        }

        public void Salvar(Fornecedor fornecedor)
        {
            contexto.Fornecedores.Add(fornecedor);
            contexto.SaveChanges();

            MessageBox.Show("Fornecedor cadastrado com sucesso!");
        }
    }
}
