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
    public partial class FormProduto : Form
    {
        Presenter.Produto _presenterProduto;
        Presenter.Tipo _presenterTipo;
        Presenter.Unidade _presenterUnidade;
        FormProduto()
        {
            InitializeComponent();
        }

        public FormProduto(Presenter.Produto presenterProduto, Presenter.Tipo presnterTipo, Presenter.Unidade presenterUnidade)
        {
            InitializeComponent();
            _presenterProduto = presenterProduto;            
            _presenterTipo = presnterTipo;
            _presenterUnidade = presenterUnidade;
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            var listaTipo = from tipo in _presenterTipo.showAll
                                     where tipo.visible == true
                                     select tipo.name;

            var listaUnidade = from unidade in _presenterUnidade.showAll
                                                   where unidade.visible == true
                                                   select unidade.name;
            comboBoxTipo.DataSource = listaTipo.ToList();
            comboBoxUnidade.DataSource = listaUnidade.ToList();
            textBoxInseridoPor.Text = Environment.UserName;
            textBoxDataInclusão.Text = DateTime.Now.ToString("d");
        }


    }
}
