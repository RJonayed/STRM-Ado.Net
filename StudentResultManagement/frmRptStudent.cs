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
    public partial class frmRptStudent : Form
    {
        List<StudentFileds> list;
        public frmRptStudent()
        {
            InitializeComponent();
        }
        public frmRptStudent(List<StudentFileds> objList)
        {
            InitializeComponent();
            list = objList;
        }

        private void frmRptStudent_Load(object sender, EventArgs e)
        {
            this.Text = "Student Information";
            RptStudent rpt = new RptStudent();
            rpt.SetDataSource(list);
            RptStudent.ReportSource = rpt;
            rpt.Refresh();
        }
    }
}
