using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Repository
{
    interface IProdutoRepository
    {
        int add(Model.Produto produtoModel);
        void update(Model.Produto produtoModel);
        void delete(Model.Produto produtoModel);
        Model.Produto get(int id);
        IEnumerable<Model.Produto> findAll();
        IEnumerable<Model.Produto> filterByDescricao(string descricao);
        IEnumerable<Model.Produto> filterByID(string id);
    }
}
