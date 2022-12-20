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
        FormReport()
        {
            InitializeComponent();
        }

        public FormReport(DataTable dt)
        {
            InitializeComponent();
            _dt = dt;
        }

        private void FormReportHistorico_Load(object sender, EventArgs e)
        {
            dataGridViewMain.DataSource = _dt;
        }
    }
}
