using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HSA_Estoque.View
{
    public partial class FormTipos : Form
    {
        Presenter.Tipo _presenterTipo;
        public FormTipos(Presenter.Tipo presenterTipo)
        {
            _presenterTipo = presenterTipo;
            InitializeComponent();
            updateBidingSource();
        }       

        private void buttonAdiciona_Click(object sender, EventArgs e)
        {
            _presenterTipo.name = textBoxTipoName.Text.ToUpper();
            _presenterTipo.add();
            textBoxTipoName.Clear();
            updateBidingSource();
        }

        private void FormTipos_Load(object sender, EventArgs e)
        {

        }

        private void updateBidingSource()
        {
            tipoBindingSource.DataSource = _presenterTipo.showAll;
            dataGridViewMain.DataSource = tipoBindingSource;
            dataGridViewMain.Refresh();
        }
    }
}
