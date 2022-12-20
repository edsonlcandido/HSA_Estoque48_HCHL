using HSA_Estoque.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        private void buttonPesquisaPorDescricao_Click(object sender, EventArgs e)
        {
            Repository.Produto produtoRepository = new Repository.Produto();
            produtoBindingSource.DataSource = produtoRepository.filterByDescricao(textBoxPesquisaPordescricao.Text);
            textBoxPesquisaPordescricao.Clear();
        }

        private void buttonPesquisaPorCodigo_Click(object sender, EventArgs e)
        {
            Repository.Produto produtoRepository = new Repository.Produto();
            produtoBindingSource.DataSource = produtoRepository.filterByID(textBoxPesquisaPorCodigo.Text);
            textBoxPesquisaPorCodigo.Clear();
        }

        private void buttonEntradaEstoque_Click(object sender, EventArgs e)
        {
            FormEntradaProduto formEntradaProduto = new FormEntradaProduto((Model.Produto)produtoBindingSource.Current);
            formEntradaProduto.ShowDialog();
            carregaProdutos();
        }

        private void buttonSaidaEstoque_Click(object sender, EventArgs e)
        {
            View.FormSaidaProduto formSaidaProduto = new View.FormSaidaProduto((Model.Produto)produtoBindingSource.Current);

            formSaidaProduto.ShowDialog();
            carregaProdutos();
        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Model.Historico> modelHistorico = new Repository.Historico().reportAll().ToList();
            DataTable dataTable = listToDataTable(modelHistorico);
            dataTable.Columns.Remove("produto");
            dataTable.Columns.Add("Descrição");
            dataTable.Columns["Descrição"].SetOrdinal(5);
            int rowIndex = 0;
            foreach (Model.Historico hist in modelHistorico)
            {
                dataTable.Rows[rowIndex]["Descrição"] = hist.produto.descricao;
                rowIndex++;
            }

            FormReport formReport = new FormReport(dataTable);
            formReport.title = "Movimentação";
            formReport.ShowDialog();
        }

        DataTable listToDataTable<T>(List<T> listObj)
        {
            DataTable dt = new DataTable("Report");
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                var displayNameAttribute = property.GetCustomAttributes(typeof(DisplayNameAttribute), false);
                Type columnType = property.PropertyType;

                try
                {
                    dt.Columns.Add((displayNameAttribute[0] as DisplayNameAttribute).DisplayName, columnType);
                }
                catch (IndexOutOfRangeException ex)
                {
                    dt.Columns.Add(property.Name, columnType);
                }
            }

            foreach (Object obj in listObj)
            {
                DataRow dr = dt.NewRow();
                dr.BeginEdit();
                foreach (PropertyInfo property in properties)
                {
                    if (property.GetValue(obj, null) != null)
                    {
                        var displayNameAttribute = property.GetCustomAttributes(typeof(DisplayNameAttribute), false);
                        try
                        {
                            dr[(displayNameAttribute[0] as DisplayNameAttribute).DisplayName] = property.GetValue(obj, null);
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            dr[property.Name] = property.GetValue(obj, null);
                        }
                    }
                }
                dr.EndEdit();
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void resumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Model.Produto> produtos = new Repository.Produto().findAll().ToList();
            DataTable dataTable = listToDataTable(produtos);
            FormReport formReport = new FormReport(dataTable);
            formReport.title = "Produtos";
            formReport.ShowDialog();
        }
    }
}
