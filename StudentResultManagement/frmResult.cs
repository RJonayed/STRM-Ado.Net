using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentResultManagement.Forms
{

    public partial class frmResult : Form
    {
        ClsMain SvCls = new ClsMain();
        public frmResult()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemColor.primaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemColor.secondColor;
                }
            }
            label6.ForeColor = ThemColor.secondColor;
            label5.ForeColor = ThemColor.primaryColor;
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadCombo()
        {
            string Qry;
            Qry = "Select StudentId from Student order by StudentId";
            cboStudentId.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboStudentId.DisplayMember = "StudentId";
            cboStudentId.Text = "";

            Qry = "Select RslId from ResultMake order by RslId";
            cboSlNo.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboSlNo.DisplayMember = "RslId";
            cboSlNo.Text = "";
        }
        private void txtMarks_Leave(object sender, EventArgs e)
        {
            int myNmber = 0;
            string point = "";
            if (myNmber >= 80 && myNmber <= 100)
            {
                point = "5";
            }
            else
            {
                point = "0";
            }


            if (myNmber > 80 && myNmber <= 100)
            {
                if (myNmber < 80)
                {
                    if (myNmber > 33 && myNmber <= 39)
                    {
                        point = "C";
                        txtGarde.Text = point;
                    }
                    else if (myNmber > 40 && myNmber <= 49)
                    {
                        point = "B";
                        txtGarde.Text = point;
                    }
                    else if (myNmber >= 50 && myNmber <= 69)
                    {
                        point = "A-";
                        txtGarde.Text = point;
                    }
                    else if (myNmber >= 70 && myNmber <= 79)
                    {
                        point = "A";
                        txtGarde.Text = point;
                    }                   
                    LblMsg.Text = "You Failed";
                }
                else
                {
                    point = "A+";
                }
               
            }

            else
            {
                LblMsg.Text = "You Failed";
            }
            txtGarde.Text = point;
        }

        private void txtMarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblMsg.Visible = false;
        }
    }
}
