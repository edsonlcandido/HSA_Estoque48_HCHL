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
    public partial class FormReportHistorico : Form
    {
        public FormReportHistorico()
        {
            InitializeComponent();
            List<Model.Historico> modelHistorico = new Repository.Historico().reportAll().ToList();
            historicoBindingSource.DataSource = modelHistorico;
            dataGridView1.DataSource = historicoBindingSource;
            dataGridView1.Refresh();
        }
    }
}
