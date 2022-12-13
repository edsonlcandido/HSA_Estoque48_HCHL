using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Model
{
    public class Historico : IHistoricoModel
    {
        public DateTime dataMovimentacao { get; set; }
        public string usuario { get; set; }
        public double quantidadeMovimentada { get; set; }
        public string tipoMovimentacao { get; set; }
        public int produtoId { get; set; }
        public string solicitante { get; set; }
        public string pedidoCentroCusto { get; set; }
        public string notaFiscal { get; set; }
        public string obs { get; set; }
    }
}
