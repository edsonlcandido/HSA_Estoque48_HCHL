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
    public partial class FormReport : Form
    {
        DataTable _dt;
        public FormReport()
        {
            InitializeComponent();
            List<Model.Historico> modelHistorico = new Repository.Historico().reportAll().ToList();
            var reportHistoricos = new Repository.Historico().reportAll();
            historicoBindingSource.DataSource = modelHistorico;
            dataGridViewMain.DataSource = historicoBindingSource;
            dataGridViewMain.Refresh();
        }

        public FormReport(DataTable dt)
        {
            InitializeComponent();
            _dt = dt;
        }

        private void FormReportHistorico_Load(object sender, EventArgs e)
        {

        }
    }
}
