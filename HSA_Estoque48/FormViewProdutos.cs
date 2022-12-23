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
    public partial class FormViewProdutos : Form
    {
        Presenter.Produto _presenterProduto;
        List<Model.Produto> _todosProdutos;
        public FormViewProdutos(Presenter.Produto presenterProduto)
        {
            _presenterProduto = presenterProduto;
            _todosProdutos = _presenterProduto.showAll;
            InitializeComponent();
        }

        private void FormViewProdutos_Load(object sender, EventArgs e)
        {
            produtoBindingSource.DataSource = _todosProdutos;
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

        private void buttonLimparFiltro_Click(object sender, EventArgs e)
        {
            _todosProdutos = _presenterProduto.showAll;
            produtoBindingSource.DataSource = _todosProdutos;
        }
    }
}
