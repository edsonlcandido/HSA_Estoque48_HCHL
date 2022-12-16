using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Repository
{
    public interface IHistoricoRepository
    {
        int Add(Model.Historico modelHistorico);
        IEnumerable<Model.Historico> findAll();

        IEnumerable<Model.Historico> reportAll();
    }
}
