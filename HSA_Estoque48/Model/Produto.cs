using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Model
{
    public class Produto : IProdutoModel
    {
        [DisplayName("Código")]
        [DataType(DataType.Text)]
        public string id { get ; set ; }
        [DisplayName("Descripción")]
        public string descricao { get ; set ; }

        [DisplayName("Cant. mín.")]
        public double quantidadeMinima { get ; set ; }

        [DisplayName("Cant. máx.")] 
        public double quantidadeMaxima { get ; set ; }
        [DisplayName("Cant. atual")]
        public double quantidadeTotal { get ; set ; }
        [DisplayName("Lead time")]
        public int leadTime { get ; set ; }
        [DisplayName("Tipo")]
        public string tipo { get ; set ; }
        [DisplayName("Unidad")]
        public string unidade { get ; set ; }
        [DisplayName("Unicación")]
        public string localizacao { get ; set ; }
        [DisplayName("Caja")]
        public string caixa { get ; set ; }
        [DisplayName("Obs")]
        public string obs { get; set; }

        public static explicit operator Produto(Presenter.Produto presenterProduto)
        {
            Model.Produto modelProduto = new Produto();
            modelProduto.id = presenterProduto.id;
            modelProduto.descricao = presenterProduto.descricao;
            modelProduto.quantidadeMinima = presenterProduto.quantidadeMinima;
            modelProduto.quantidadeMaxima = presenterProduto.quantidadeMaxima;
            modelProduto.quantidadeTotal = presenterProduto.quantidadeTotal;
            modelProduto.leadTime = presenterProduto.leadTime;
            modelProduto.tipo = presenterProduto.tipo;
            modelProduto.unidade = presenterProduto.unidade;
            modelProduto.localizacao = presenterProduto.localizacao;
            modelProduto.caixa = presenterProduto.caixa;
            modelProduto.obs = presenterProduto.obs;

            return modelProduto;
        }
    }
}
