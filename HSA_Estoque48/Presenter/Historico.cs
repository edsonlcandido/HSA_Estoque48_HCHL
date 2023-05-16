using HSA_Estoque.Model;
using HSA_Estoque.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Presenter
{
    public class Historico : IHistoricoModel
    {
        List<Historico> _showAll;
        IHistoricoRepository _historicoRepository;
        public Historico() {
            _historicoRepository = new Repository.Historico();
            dataMovimentacao = DateTime.Now;
            usuario = Environment.UserName;
            solicitante = "";
            pedidoCentroCusto = "";
            notaFiscal = "";
        }

        public void entradaProduto()
        {
            this.obs = $@"Se ha agregado {this.quantidadeMovimentada} al producto";
            this.tipoMovimentacao= "Entrada";
            Model.Historico modelHistorico = new Model.Historico();
            modelHistorico.dataMovimentacao = this.dataMovimentacao;
            modelHistorico.usuario = this.usuario;
            modelHistorico.quantidadeMovimentada = this.quantidadeMovimentada;
            modelHistorico.tipoMovimentacao = this.tipoMovimentacao;
            modelHistorico.produtoId = this.produtoId;
            modelHistorico.notaFiscal = this.notaFiscal;
            modelHistorico.obs = this.obs;
            _historicoRepository.Add(modelHistorico);
        }

        public void retiradaProduto()
        {
            this.obs = $@"Se ha realizado la retirada de {this.quantidadeMovimentada} del producto";
            this.tipoMovimentacao= "Retirada";
            Model.Historico modelHistorico = new Model.Historico();
            modelHistorico.dataMovimentacao= this.dataMovimentacao;
            modelHistorico.usuario = this.usuario;            
            modelHistorico.tipoMovimentacao = this.tipoMovimentacao;
            modelHistorico.quantidadeMovimentada = this.quantidadeMovimentada;
            modelHistorico.produtoId = this.produtoId;
            modelHistorico.solicitante = this.solicitante;
            modelHistorico.pedidoCentroCusto = this.pedidoCentroCusto;
            modelHistorico.obs = this.obs;
            _historicoRepository.Add(modelHistorico);
        }

        public int inclusaoProduto()
        {
            this.obs = $@"Cantidad inicial de {this.quantidadeMovimentada}";
            this.tipoMovimentacao = "Inicial";
            Model.Historico modelHistorico = new Model.Historico();
            modelHistorico.dataMovimentacao = this.dataMovimentacao;
            modelHistorico.usuario = this.usuario;
            modelHistorico.quantidadeMovimentada = this.quantidadeMovimentada;
            modelHistorico.tipoMovimentacao = this.tipoMovimentacao;
            modelHistorico.produtoId = this.produtoId;
            modelHistorico.obs = this.obs;
            return _historicoRepository.Add(modelHistorico);
        }

        public void alteracaoProduto()
        {
            this.obs = $@"El producto ha sido editado";
            this.tipoMovimentacao = "Edición";
            Model.Historico modelHistorico = new Model.Historico();
            modelHistorico.dataMovimentacao = this.dataMovimentacao;
            modelHistorico.tipoMovimentacao = this.tipoMovimentacao;
            modelHistorico.usuario = this.usuario;
            modelHistorico.produtoId = this.produtoId;
            modelHistorico.obs = this.obs;
            _historicoRepository.Add(modelHistorico);
        }
        public void remocaoProduto()
        {
            this.obs = $@"El producto ha sido eliminado";
            this.tipoMovimentacao = "Remoción";
            Model.Historico modelHistorico = new Model.Historico();
            modelHistorico.dataMovimentacao = this.dataMovimentacao;
            modelHistorico.tipoMovimentacao = this.tipoMovimentacao;
            modelHistorico.usuario = this.usuario;
            modelHistorico.produtoId = this.produtoId;
            modelHistorico.obs = this.obs;
            _historicoRepository.Add(modelHistorico);
        }

        public DateTime dataMovimentacao { get ; set ; }
        public string usuario { get ; set ; }
        public double quantidadeMovimentada { get ; set ; }
        public string tipoMovimentacao { get ; set ; }
        public string produtoId { get ; set ; }
        public string solicitante { get ; set ; }
        public string pedidoCentroCusto { get ; set ; }
        public string notaFiscal { get ; set ; }
        public string obs { get ; set ; }
        public Model.Produto produto { get ; set ; }
    }
}
