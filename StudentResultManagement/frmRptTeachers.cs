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
    public partial class frmRptTeachers : Form
    {
        List<TeachersFields> list;
        public frmRptTeachers()
        {
            InitializeComponent();
        }
        public frmRptTeachers(List<TeachersFields> objList)
        {
            InitializeComponent();
            list = objList;
        }
        private void frmRptTeachers_Load(object sender, EventArgs e)
        {
            this.Text = "Teachers Information";
            RptTeacher rpt = new RptTeacher();
            rpt.SetDataSource(list);
            RptTeacher.ReportSource = rpt;
            RptTeacher.Refresh();
        }
    }
}
