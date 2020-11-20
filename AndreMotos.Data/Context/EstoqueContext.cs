using AndreMotos.Dominio.EstoqueRoot;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMotos.Data.Context
{
    public class EstoqueContext : DbContext
    {

        public EstoqueContext() : base(StrConexao)
        {

        }

        public static DbCompiledModel StrConexao { get; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
