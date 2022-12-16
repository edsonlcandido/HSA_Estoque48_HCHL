using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Model
{
    public class Historico : IHistoricoModel
    {
        [DisplayName("Data da movimentação")]
        public DateTime dataMovimentacao { get; set; }
        [DisplayName("Usuário")]
        public string usuario { get; set; }
        [DisplayName("Qtd. moveimentada")]
        public double quantidadeMovimentada { get; set; }
        [DisplayName("Tipo de Movimentação")]
        public string tipoMovimentacao { get; set; }
        [DisplayName("Código")]
        public int produtoId { get; set; }
        [DisplayName("Solicitante")]
        public string solicitante { get; set; }
        [DisplayName("Pedido ou C/C")]
        public string pedidoCentroCusto { get; set; }
        [DisplayName("No.  NF")]
        public string notaFiscal { get; set; }
        [DisplayName("Obs.")]
        public string obs { get; set; }
        public Produto produto { get ; set; }
    }
}
