using HSA_Estoque.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSA_Estoque
{
    public partial class FormMain : Form
    {
        Presenter.Produto _presenterProduto;
        List<Model.Produto> _todosProdutos;
        List<Model.Produto> _semMaterial;
        List<Model.Produto> _produtosAcabando;
        List<Model.Produto> _produtosOK;
        FormMain()
        {
            InitializeComponent();
        }

        public FormMain(Presenter.Produto presenterProduto)
        {
            _presenterProduto= presenterProduto;
            _todosProdutos = _presenterProduto.showAll;

            _semMaterial = (from p in _todosProdutos
                           where p.quantidadeTotal <= 0
                           select p).ToList();

            _produtosAcabando = (from p in _todosProdutos
                            where p.quantidadeTotal <= p.quantidadeMinima && p.quantidadeTotal != 0
                                 select p).ToList();

            _produtosOK = (from p in _todosProdutos
                                 where p.quantidadeTotal > p.quantidadeMinima
                                 select p).ToList();

            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipos formTipos = new FormTipos(new Presenter.Tipo());
            formTipos.ShowDialog();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUnidades formTipos = new FormUnidades(new Presenter.Unidade());
            formTipos.ShowDialog();
        }

        private void buttonCadastrarNovoProduto_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto(new Presenter.Produto(), new Presenter.Tipo(), 
                new Presenter.Unidade(), new Presenter.Historico());
            formProduto.ShowDialog();
            carregaProdutos();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelSemMaterial.Text = String.Format("{0} itens estão sem estoque", _semMaterial.Count());
            labelProdutosAcabando.Text = String.Format("{0} itens estão com quantidades inferior ao minimo", _produtosAcabando.Count());
            labelProdutosOK.Text = String.Format("{0} itens estão com a quantidades ok", _produtosOK.Count());
            produtoBindingSource.DataSource= _todosProdutos;
        }

        private void tableLayoutPanelTodosProdutos_Click(object sender, EventArgs e)
        {
            //_todosProdutos = _presenterProduto.showAll;
            produtoBindingSource.DataSource = _todosProdutos;
        }

        private void tableLayoutPanelItensOK_Click(object sender, EventArgs e)
        {
            produtoBindingSource.DataSource = _produtosOK;
        }

        private void tableLayoutPanelItensAcabando_Click(object sender, EventArgs e)
        {
            produtoBindingSource.DataSource = _produtosAcabando;
        }

        private void tableLayoutPanelSemMaterial_Click(object sender, EventArgs e)
        {
            produtoBindingSource.DataSource = _semMaterial;
        }

        private void buttonEditarProduto_Click(object sender, EventArgs e)
        {
            FormProduto formEditarProduto = new FormProduto(new Presenter.Produto(), 
                new Presenter.Tipo(), new Presenter.Unidade(), new Presenter.Historico(), (Model.Produto)produtoBindingSource.Current);

            formEditarProduto.ShowDialog();

            carregaProdutos();
        }

        private void carregaProdutos()
        {
            _todosProdutos = _presenterProduto.showAll;

            _semMaterial = (from p in _todosProdutos
                            where p.quantidadeTotal <= 0
                            select p).ToList();

            _produtosAcabando = (from p in _todosProdutos
                                 where p.quantidadeTotal <= p.quantidadeMinima && p.quantidadeTotal != 0
                                 select p).ToList();

            _produtosOK = (from p in _todosProdutos
                           where p.quantidadeTotal > p.quantidadeMinima
                           select p).ToList();

            produtoBindingSource.DataSource = _todosProdutos;

            labelSemMaterial.Text = String.Format("{0} itens estão sem estoque", _semMaterial.Count());
            labelProdutosAcabando.Text = String.Format("{0} itens estão com quantidades inferior ao minimo", _produtosAcabando.Count());
            labelProdutosOK.Text = String.Format("{0} itens estão com a quantidades ok", _produtosOK.Count());
        }
    }
}
