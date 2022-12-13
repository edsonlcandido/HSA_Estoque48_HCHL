using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Model
{
    public interface IHistoricoModel
    {
        DateTime dataMovimentacao { get; set; }
        string usuario { get; set; }
        double quantidadeMovimentada { get; set; }
        string tipoMovimentacao { get; set; }
        int produtoId { get; set; }
        string solicitante { get; set; }
        string pedidoCentroCusto { get; set; }
        string notaFiscal { get; set; }
        string obs { get; set; }
    }
}
