using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    class Cliente
    {
        private int id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string filiacao { get; set; }
        public string status { get; set; }
        public string limiteDeCredito { get; private set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string cidade { get; set; }

        public void Cadastrar(string nome, string endereco, string numero, string complemento, string bairro, string cep, string estado, string telefone, string celular, string filiacao, string status, string limiteDeCredito, string cpf, string rg, string cidade)
        {
            frmCliente cliente = new frmCliente();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Cliente";
            cliente.dgvCadastroCliente.Rows.Add(nome);
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
