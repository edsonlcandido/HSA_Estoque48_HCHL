using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Model
{
    public class Produto : IProdutoModel
    {
        [DisplayName("Código")]
        public int id { get ; set ; }
        [DisplayName("Descrição")]
        public string descricao { get ; set ; }

        [DisplayName("Qtd. mín.")]
        public double quantidadeMinima { get ; set ; }

        [DisplayName("Qtd. máx.")] 
        public double quantidadeMaxima { get ; set ; }
        [DisplayName("Qtd. atual")]
        public double quantidadeTotal { get ; set ; }
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

            return modelProduto;
        }
    }
}
