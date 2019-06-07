using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML.Entidade
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Lougradouro { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Filiacao { get; set; }
        public string Status_Cliente { get; set; }
        public double Limite_De_Credito { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Cidade { get; set; }

        public void Cadastrar(int id, string nome, string lougradouro, string endereco, string numero, string complemento, string bairro, string cep, string estado, string telefone, string celular, string filiacao, string status, string limiteDeCredito, string cpf, string rg, string cidade)
        {
            
        }

        public void Editar(int id)
        {

        }

        public void Deletar(int id)
        {

        }

        public void Verificar(int id)
        {

        }

        public void VerificarLimite(int id)
        {

        }
    }
}
