using HSA_Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Repository
{
    interface ITipoRepository
    {
        int add(Model.Tipo tipoModel);
        void update(Model.Tipo tipoModel);
        Model.Tipo get(int id);
        IEnumerable<Model.Tipo> findAll();
    }
}
