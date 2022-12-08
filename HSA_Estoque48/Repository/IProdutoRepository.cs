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
        Model.Produto get(int id);
        IEnumerable<Model.Produto> findAll();
    }
}
