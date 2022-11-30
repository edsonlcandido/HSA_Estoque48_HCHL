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
        public FormMain()
        {
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
    }
}
