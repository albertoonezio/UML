﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML.Entidade;

namespace UML.Entidade
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Valor { get; set; }
        public DateTime Data_Fabricacao { get; set; }
        public DateTime Data_Vencimento { get; set; }
        public DateTime Data_Adicao { get; set; }
        public double Quantidade { get; set; }
        public string Status_Produto { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual int FornecedorId { get; set; }
        //public virtual IList<Pedido> Pedidos { get; set; }

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
