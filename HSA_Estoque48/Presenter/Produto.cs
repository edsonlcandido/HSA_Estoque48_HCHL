using HSA_Estoque.Model;
using HSA_Estoque.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HSA_Estoque.Presenter
{
    public class Produto : IProdutoModel
    {
        List<Model.Produto> _showAll;
        IProdutoRepository _repository;
        public Produto()
        {
            _repository = new Repository.Produto();
            id = "0";
            descricao = "PRODUTO SEM CADASTRO";
            quantidadeMinima = 0;
            quantidadeMaxima = 0;
            quantidadeTotal= 0;
            leadTime = 0;
            tipo = "TBD";
            unidade = "TBD";
            localizacao = "ALMOXARIFADO";
            caixa = "TBD";
            obs = "";
        }

        public int add()
        {
            return _repository.add((Model.Produto)this);
        }

        public Model.Produto get(int id)
        {
            Model.Produto modelProduto= _repository.get(id);

            this.id = modelProduto.id;
            this.descricao = modelProduto.descricao;
            this.quantidadeMinima = modelProduto.quantidadeMinima;
            this.quantidadeMaxima = modelProduto.quantidadeMaxima;
            this.quantidadeTotal = modelProduto.quantidadeTotal;
            this.leadTime = modelProduto.leadTime;
            this.tipo= modelProduto.tipo;
            this.unidade= modelProduto.unidade;
            this.localizacao= modelProduto.localizacao;
            this.caixa= modelProduto.caixa;
            this.obs = modelProduto.obs;

            return (Model.Produto)this;
        }

        public void update()
        {
            if (this.quantidadeTotal < 0)
            {
                throw new Exception("Quantidade total não pode ser negativa");
            }
            _repository.update((Model.Produto)this);
        }

        public List<Model.Produto> showAll
        {
            get
            {
                _showAll = (List<Model.Produto>)_repository.findAll();
                return _showAll;
            }
        }

        public string id { get; set ; }
        public string descricao { get ; set ; }
        public double quantidadeMinima { get ; set ; }
        public double quantidadeMaxima { get ; set ; }
        public double quantidadeTotal { get ; set ; }
        public int leadTime { get ; set ; }
        public string tipo { get ; set ; }
        public string unidade { get ; set ; }
        public string localizacao { get ; set ; }
        public string caixa { get ; set ; }
        public string obs { get ; set ; }
    }
}
