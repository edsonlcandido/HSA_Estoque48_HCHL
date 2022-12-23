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

        }
    }
}
