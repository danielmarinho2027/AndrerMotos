using AndreMotos.Data.Interfaces;
using AndreMotos.Dominio.EstoqueRoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMotos.Data.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private List<Produto> _produtos;

        public ProdutoRepositorio()
        {

        }
        public List<Produto> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
