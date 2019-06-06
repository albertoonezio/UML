using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class ValidarCampos
    {
        bool camposCliente { get; set; }

        public bool ValidarCliente(int id, string nome, string lougradouro, string endereco, string numero, string complemento, string bairro, string cep, string estado, string telefone, string celular, string filiacao, string status, string limiteDeCredito, string cpf, string rg, string cidade)
        {
            if (nome.Length > 0)
            {
                camposCliente = true;
            }

            else
            {
                camposCliente = false;
            }
            return camposCliente;
        }
    }
}
