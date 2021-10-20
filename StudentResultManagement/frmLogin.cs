using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentResultManagement
{
    public partial class frmLogin : Form
    {
        ClsMain SvCls = new ClsMain();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {  
            string SelectQry;
            SelectQry = "SELECT *  FROM Login where UserName='" + txtUserName.Text.Trim() + "' and Password='" + txtPassword.Text.Trim() + "'";            
            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {
                frmMain frmM = new frmMain();
                frmM.ShowDialog();
                this.Close();
            }

            else
            {
                frmResigter frmr = new frmResigter();
                frmr.Show();
            }           
        }

        private void btnForPass_Click(object sender, EventArgs e)
        {       
                //string SelectQry;
                //SelectQry = "SELECT *  FROM Login where UserName='" + txtUserName.Text.Trim() + "' and Password='" + txtPassword.Text.Trim() + "'";
                //if (SvCls.DataExist(SelectQry).ToString() == "1")
                //{
                //    frmUpdatePassword fsd = new frmUpdatePassword();
                //    fsd.Show();
                //    this.Close();
                //}                
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "Admin";
            txtPassword.Text = "12345677";
        }
    }
}
