using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HSA_Estoque.View
{
    public partial class FormUnidades : Form
    {
        Presenter.Unidade _presenterTipo;
        public FormUnidades(Presenter.Unidade presenterUnidade)
        {
            _presenterTipo = presenterUnidade;
            InitializeComponent();
            updateBidingSource();
        }

        private void buttonAdiciona_Click(object sender, EventArgs e)
        {
            if (textBoxUnidadeName.Text.TrimEnd() != "")
            {
                _presenterTipo.name = textBoxUnidadeName.Text.ToUpper().TrimEnd();
                _presenterTipo.add();
                textBoxUnidadeName.Clear();
                updateBidingSource();
            }
            else
            {
                MessageBox.Show("Valor não pode ser em branco","Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void FormTipos_Load(object sender, EventArgs e)
        {

        }

        private void updateBidingSource()
        {
            unidadeBindingSource.DataSource = _presenterTipo.showAll;
            dataGridViewMain.DataSource = unidadeBindingSource;
            dataGridViewMain.Refresh();
        }

        private void tipoBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            Model.Tipo currentModelTipo = (Model.Tipo)unidadeBindingSource.Current;
            _presenterTipo.id = currentModelTipo.id;
            _presenterTipo.name = dgv.Rows[e.RowIndex].Cells[0].Value.ToString().ToUpper();
            _presenterTipo.visible = (bool)dgv.Rows[e.RowIndex].Cells[1].Value;

            _presenterTipo.update();
            updateBidingSource();
        }
    }
}
