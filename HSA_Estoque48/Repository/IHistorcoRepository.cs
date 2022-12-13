using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Repository
{
    public interface IHistorcoRepository
    {
        int Add(Model.Historico modelHistorico);
        IEnumerable<Model.Unidade> findAll();
    }
}
