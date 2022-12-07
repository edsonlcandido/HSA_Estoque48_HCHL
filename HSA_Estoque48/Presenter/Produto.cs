using HSA_Estoque.Model;
using HSA_Estoque.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Presenter
{
    public class Produto : IProdutoModel
    {
        List<Produto> _showAll;
        IProdutoRepository _repository;
        public Produto()
        {
            _repository = new Repository.Produto();
            id = 0;
            descricao = "PRODUTO SEM CADASTRO";
            quantidadeMinima = 0;
            quantidadeMaxima = 0;
            quantidadeTotal= 0;
            leadTime = 0;
            tipo = "TBD";
            unidade = "TBD";
            localizacao = "ALMOXARIFADO";
            caixa = "TBD";
        }

        public int add()
        {
            return _repository.add((Model.Produto)this);
        }

        public int id { get; set ; }
        public string descricao { get ; set ; }
        public double quantidadeMinima { get ; set ; }
        public double quantidadeMaxima { get ; set ; }
        public double quantidadeTotal { get ; set ; }
        public int leadTime { get ; set ; }
        public string tipo { get ; set ; }
        public string unidade { get ; set ; }
        public string localizacao { get ; set ; }
        public string caixa { get ; set ; }
    }
}
