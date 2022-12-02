using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Model
{
    internal class Produto : IProdutoModel
    {
        [DisplayName("Código")]
        public string id { get ; set ; }
        [DisplayName("Descrição")]
        public string descricao { get ; set ; }
        [DisplayName("Qtd. inicial")]
        public double quantidadeInicial { get ; set ; }
        [DisplayName("Qtd. mín.")]
        public double quantidadeMinima { get ; set ; }

        [DisplayName("Qtd. máx.")] 
        public double quantidadeMaxima { get ; set ; }
        [DisplayName("Qtd. atual")]
        public int quantidadeTotal { get ; set ; }
        [DisplayName("Lead time")]
        public int leadTime { get ; set ; }
        [DisplayName("Tipo")]
        public string tipo { get ; set ; }
        [DisplayName("Unidade")]
        public string unidade { get ; set ; }
        [DisplayName("Localização")]
        public string localizacao { get ; set ; }
        [DisplayName("Caixa")]
        public string caixa { get ; set ; }
    }
}
