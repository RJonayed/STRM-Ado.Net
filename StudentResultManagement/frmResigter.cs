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
    public partial class frmResigter : Form
    {
        ClsMain SvCls = new ClsMain();
        public frmResigter()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Please select Valid User Name ", "USSL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Select();
                return;
            }
            string SelectQry;
            string SaveQry;
            string updateQry;
            updateQry = "update Login set UserName='" + txtPassword.Text.Trim() + "', Password=' " + txtUserName.Text.Trim() + "'";
            SelectQry = "Select * from Login";
            SaveQry = "Insert into Login(UserName,Password)values('" + txtUserName.Text.Trim() + "','" + txtPassword.Text.Trim() + "'";
            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {
                SvCls.insertUpdate(SaveQry);
                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                txtUserName.Focus();
            }

            else
            {
                SvCls.insertUpdate(updateQry);
                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "EDIT SUCCESSFULLY...!!";

                txtUserName.Focus();
            }         

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            frmLogin frl = new frmLogin();
            frl.Show();
        }
    }
}
