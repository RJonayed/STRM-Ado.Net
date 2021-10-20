using StudentResultManagement.Rpt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentResultManagement
{
    public partial class frmReport : Form
    {
        List<ReportFiled> list;
        public frmReport()
        {
            InitializeComponent();
        }
        public frmReport(List<ReportFiled> objList)
        {
            InitializeComponent();
            list = objList;
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            this.Text = "Admission Report";
            Admission rpt = new Admission();
            rpt.SetDataSource(list);
            crystalReportViewer.ReportSource = rpt;
            crystalReportViewer.Refresh();
        }      
    }
}
