using HSA_Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Repository
{
    internal interface IUnidadeRepository
    {
        int add(Model.Unidade modelUnidade);
        void update(Model.Unidade modelUnidade);
        Model.Unidade get(int id);
        IEnumerable<Model.Unidade> findAll();
    }
}
