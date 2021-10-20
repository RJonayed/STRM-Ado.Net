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
    public partial class frmRptTsp : Form
    {
        List<TspFiled> list;
        public frmRptTsp()
        {
            InitializeComponent();
        }
        public frmRptTsp(List<TspFiled> objList)
        {
            InitializeComponent();
            list = objList;
        }
        private void frmRptTsp_Load(object sender, EventArgs e)
        {
            this.Text = "Trainig Center Information";
            RptTst rpt = new RptTst();
            rpt.SetDataSource(list);
            RptTsp.ReportSource = rpt;
            RptTsp.Refresh();
        }
    }
}
