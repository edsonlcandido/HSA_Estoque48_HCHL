using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Model
{
    public interface IProdutoModel
    {
        string id { get; set; }
        string descricao { get; set; }
        double quantidadeMinima { get; set; }
        double quantidadeMaxima { get; set; }
        double quantidadeTotal { get; set;}
        int leadTime { get; set; }
        string tipo { get; set; }
        string unidade { get; set; }
        string localizacao { get; set; }
        string caixa { get; set; }
        string obs { get; set; }
    }
}
