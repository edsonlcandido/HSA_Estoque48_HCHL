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
    public partial class FormEntradaProduto : Form
    {
        Model.Produto _modelProduto;
        FormEntradaProduto()
        {
            InitializeComponent();
        }

        public FormEntradaProduto(Model.Produto modelProduto)
        {
            InitializeComponent();
            _modelProduto =modelProduto;

            textBoxProdutoId.Text = _modelProduto.id.ToString();
            textBoxProdutoDescricao.Text = _modelProduto.descricao;
            textBoxProdutoQuantidadeTotal.Text = _modelProduto.quantidadeTotal.ToString();
            textBoxProdutoQuantidadeMinima.Text = _modelProduto.quantidadeMinima.ToString();
            textBoxProdutoQuantidadeMaxima.Text = _modelProduto.quantidadeMaxima.ToString();
            textBoxInseridoPor.Text = Environment.UserName;
        }

        private void buttonAdicionaProduto_Click(object sender, EventArgs e)
        {
            Presenter.Produto presenterProduto = new Presenter.Produto();
            presenterProduto.id = _modelProduto.id;
            presenterProduto.descricao = _modelProduto.descricao;
            presenterProduto.quantidadeMinima = _modelProduto.quantidadeMinima;
            presenterProduto.quantidadeMaxima = _modelProduto.quantidadeMaxima;
            presenterProduto.quantidadeTotal = _modelProduto.quantidadeTotal + Convert.ToDouble(textBoxQuantidadeA_SerIncluida.Text);
            presenterProduto.leadTime = _modelProduto.leadTime;
            presenterProduto.tipo = _modelProduto.tipo;
            presenterProduto.unidade = _modelProduto.unidade;
            presenterProduto.localizacao = _modelProduto.localizacao;
            presenterProduto.caixa = _modelProduto.caixa;
            

            Presenter.Historico presenterHistorico = new Presenter.Historico();
            presenterHistorico.produtoId = _modelProduto.id;
            presenterHistorico.quantidadeMovimentada = Convert.ToDouble(textBoxQuantidadeA_SerIncluida.Text);
            presenterHistorico.notaFiscal = textBoxNumeroNF.Text;

            try
            {
                presenterProduto.update();
                presenterHistorico.entradaProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void FormEntradaProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
