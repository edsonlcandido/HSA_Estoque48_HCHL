using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Model
{
    internal interface IProdutoModel
    {
        string id { get; set; }
        string descricao { get; set; }
        double quantidadeInicial { get; set; }
        double quantidadeMinima { get; set; }
        double quantidadeMaxima { get; set; }
        int quantidadeTotal { get; set;}
        int leadTime { get; set; }
        string tipo { get; set; }
        string unidade { get; set; }
        string localizacao { get; set; }
        string caixa { get; set; }
    }
}
