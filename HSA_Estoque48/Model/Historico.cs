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
        [DisplayName("Fecha del movimiento")]
        public DateTime dataMovimentacao { get; set; }
        [DisplayName("Usuario")]
        public string usuario { get; set; }
        [DisplayName("Cant. movimentada")]
        public double quantidadeMovimentada { get; set; }
        [DisplayName("Tipo de movimiento")]
        public string tipoMovimentacao { get; set; }
        [DisplayName("Código")]
        public string produtoId { get; set; }
        [DisplayName("Solicitante")]
        public string solicitante { get; set; }
        [DisplayName("Pedido ou C/C")]
        public string pedidoCentroCusto { get; set; }
        [DisplayName("Número de la factura")]
        public string notaFiscal { get; set; }
        [DisplayName("Obs.")]
        public string obs { get; set; }
        public Produto produto { get ; set; }
    }
}
