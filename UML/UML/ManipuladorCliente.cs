using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML.Entidade;

namespace UML
{
    class ManipuladorCliente
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
        }
    }
}
