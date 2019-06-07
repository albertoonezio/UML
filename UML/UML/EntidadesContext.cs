using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using System.Configuration;
using UML.Entidade;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace UML
{
    public class EntidadesContext : DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Cliente> Cliente { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Pedido> Pedido { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Produto> Produto { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<QuantidadePedido> QuantidadePedido { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Fornecedor> Fornecedore { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["Controle_GeralConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(stringConexao);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
