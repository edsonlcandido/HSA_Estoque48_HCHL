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

        private void tipoBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            Model.Tipo currentModelTipo = (Model.Tipo)tipoBindingSource.Current;
            _presenterTipo.id = currentModelTipo.id;
            _presenterTipo.name = dgv.Rows[e.RowIndex].Cells[0].Value.ToString().ToUpper();
            _presenterTipo.visible = (bool)dgv.Rows[e.RowIndex].Cells[1].Value;

            _presenterTipo.update();
            updateBidingSource();
        }
    }
}
