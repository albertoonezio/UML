using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class Produto
    {
        private int id { get; set; }
        public string nome { get; set; }
        public string categoria { get; set; }
        public double valor { get; set; }
        public DateTime dataFabricacao { get; set; }
        public DateTime dataVencimento { get; set; }
        public Fornecedor fornecedor { get; set; }

        public void Cadastrar(string nome)
        {

        }

        public void Editar()
        {

        }

        public void Deletar()
        {

        }

        public void Verificar()
        {

        }

        public void VerificarValidade()
        {

        }

        public void RetirarEstoque()
        {

        }
    }
}
