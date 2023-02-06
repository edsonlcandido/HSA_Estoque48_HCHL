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
    public partial class FormUsuario : Form
    {
        Presenter.Usuario _presenterUsuario;
        FormUsuario()
        {
            InitializeComponent();
        }

        public FormUsuario(Presenter.Usuario presenterUsuario)
        {
            _presenterUsuario = presenterUsuario;
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            updateDataBinding();
        }

        private void buttonAdiciona_Click(object sender, EventArgs e)
        {
            if (textBoxUsuarioName.Text.TrimEnd() != "")
            {
                _presenterUsuario.nome = textBoxUsuarioName.Text.ToUpper().Trim();
                _presenterUsuario.add();
                textBoxUsuarioName.Clear();
                updateDataBinding();
            }
            else
            {
                MessageBox.Show("Valor não pode ser em branco", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void updateDataBinding()
        {
            usuarioBindingSource.DataSource = _presenterUsuario.showAll;
            dataGridViewMain.DataSource = usuarioBindingSource;
            dataGridViewMain.Refresh();
        }

        private void dataGridViewMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            Model.Usuario currentModelUsuario = (Model.Usuario)usuarioBindingSource.Current;
            _presenterUsuario.id = currentModelUsuario.id;
            _presenterUsuario.nome = dgv.Rows[e.RowIndex].Cells[0].Value.ToString().ToUpper();
            _presenterUsuario.isAdmin = (bool)dgv.Rows[e.RowIndex].Cells[1].Value;

            _presenterUsuario.update();
            updateDataBinding();
        }   
    }
}
