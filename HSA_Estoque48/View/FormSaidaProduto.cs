using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSA_Estoque.View
{
    public partial class FormSaidaProduto : Form
    {
        Model.Produto _modelProduto;
        FormSaidaProduto()
        {
            InitializeComponent();
        }

        public FormSaidaProduto(Model.Produto modelProduto)
        {
            InitializeComponent();
            _modelProduto = modelProduto;

            textBoxProdutoId.Text = _modelProduto.id.ToString();
            textBoxProdutoDescricao.Text = _modelProduto.descricao;
            textBoxProdutoQuantidadeTotal.Text = _modelProduto.quantidadeTotal.ToString();
            textBoxProdutoQuantidadeMinima.Text = _modelProduto.quantidadeMinima.ToString();
            textBoxProdutoQuantidadeMaxima.Text = _modelProduto.quantidadeMaxima.ToString();
        }

        private void FormSaidaProduto_Load(object sender, EventArgs e)
        {
            textBoxEntreguePor.Text = Environment.UserName;
        }

        private void buttonRetirarProduto_Click(object sender, EventArgs e)
        {
            Presenter.Produto presenterProduto = new Presenter.Produto();
            presenterProduto.id = _modelProduto.id;
            presenterProduto.descricao = _modelProduto.descricao;
            presenterProduto.quantidadeMinima = _modelProduto.quantidadeMinima;
            presenterProduto.quantidadeMaxima = _modelProduto.quantidadeMaxima;
            presenterProduto.quantidadeTotal = _modelProduto.quantidadeTotal - Convert.ToDouble(textBoxQuantidadeNecessaria.Text);
            presenterProduto.leadTime = _modelProduto.leadTime;
            presenterProduto.tipo = _modelProduto.tipo;
            presenterProduto.unidade = _modelProduto.unidade;
            presenterProduto.localizacao = _modelProduto.localizacao;
            presenterProduto.caixa = _modelProduto.caixa;


            Presenter.Historico presenterHistorico = new Presenter.Historico();
            presenterHistorico.produtoId = Convert.ToInt32(_modelProduto.id);
            presenterHistorico.quantidadeMovimentada = Convert.ToDouble(textBoxQuantidadeNecessaria.Text);
            presenterHistorico.solicitante = textBoxSolicitante.Text;
            presenterHistorico.pedidoCentroCusto = textBoxPedido_CC.Text;

            try
            {
                presenterProduto.update();
                presenterHistorico.retiradaProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
    }
}
