using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentResultManagement.Forms
{
    public partial class frmTeacher : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        int cellId = 0;
        string TchId;
        public frmTeacher()
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

        private void frmTeacher_Load(object sender, EventArgs e)
        {
            LoadTheme();
            loadCombo();
            txtMobile.Text = "8801";
        }

        private void loadCombo()
        {
            string qry;
            qry = "Select TchId from TchInfo order by TchId";
            cboTchId.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboTchId.DisplayMember = "TchId";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboTchId.Text.Trim() == "")
            {
                MessageBox.Show("Teacher ID Can't be Blank", "IDB-BISWE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTchId.Select();
                return;
            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Teacher Name Can't be Blank", "IDB-BISWE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Select();
                return;
            }

            string SaveQry;
            string SelectQry;
            string EdtQry;

            SaveQry = "Insert into TchInfo (TchId,TchName,JoinDate,TchPhone,TchEmail,TchAddress,UserId,ComId,PcName,salary)values('" + cboTchId.Text.Trim() + "','" + txtName.Text.Trim() + "',convert(datetime,'" + dtJoin.Text.Trim() + "',103),'" + txtMobile.Text.Trim() + "','" + txtEmail.Text.Trim() + "','" + txtAddress.Text.Trim() + "','" + ClsVar.GblUserId + "','" + ClsVar.GblComId + "','" + ClsVar.GblPcName + "','" + txtSalary.Text.Trim() + "')";
            SelectQry = "Select TchName,JoinDate,TchPhone,TchEmail,TchAddress,UserId,ComId,PcName,salary from TchInfo where TchId='" + cboTchId.Text.Trim() + "'";
            EdtQry = "Update TchInfo set TchName='" + txtName.Text.Trim() + "',JoinDate=convert(datetime,'" + dtJoin.Text.Trim() + "',103),TchPhone='" + txtMobile.Text.Trim() + "',TchEmail='" + txtEmail.Text.Trim() + "',TchAddress='" + txtAddress.Text.Trim() + "',UserId='" + ClsVar.GblUserId + "',ComId='" + ClsVar.GblComId + "',PcName='" + ClsVar.GblPcName + "',salary='" + txtSalary.Text.Trim() + "' where TchId='" + cboTchId.Text.Trim() + "'";
            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {
                SvCls.insertUpdate(SaveQry);
                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                PicSave.Visible = true;

                Grid_Head();
            }
            else
            {
                SvCls.insertUpdate(EdtQry);
                lblMgs.ForeColor = System.Drawing.Color.Green;
                lblMgs.Visible = true;
                lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                PicSave.Visible = true;

                Grid_Head();
            }

        }
        private void Grid_Head()
        {
            GridTch.DataSource = SvCls.GblDataTable("Select TchId as[Teacher ID],TchName as[Name],JoinDate as[Join Date],TchPhone as[Mobile],TchEmail as[Email],TchAddress as[Address],salary as[Salary] from TchInfo where TchId='" + cboTchId.Text.Trim() + "'");
            GridTch.Refresh();
            int rowCount = GridTch.Rows.Count - 1;
            lblTotal.Text = "Quantity of Teacher : " + rowCount;

            GridTch.BackgroundColor = Color.FromArgb(204, 204, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    imgLocatin = dialog.FileName.ToString();
            //    TchImg.ImageLocation = imgLocatin;
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GridTch.DataSource = SvCls.GblDataTable("Select TchId as[Teacher ID],TchName as[Name],JoinDate as[Join Date],TchPhone as[Mobile],TchEmail as[Email],TchAddress as[Address],salary as[Salary] from TchInfo order by TchId");
            GridTch.Refresh();
            int rowCount = GridTch.Rows.Count - 1;
            lblTotal.Text = "Quantity of Teacher : " + rowCount;

            loadCombo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMgs.Visible = false;
            PicSave.Visible = false;
            GridTch.BackgroundColor = Color.White;
        }

        private void cboTchId_Leave(object sender, EventArgs e)
        {
            if (cboTchId.Text.Trim() != "")
            {
                string SelectQry;
                SelectQry = "Select TchName,JoinDate,TchPhone,TchEmail,TchAddress,salary from TchInfo where TchId='" + cboTchId.Text.Trim() + "'";
                SvCls.toGetData(SelectQry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    txtName.Text = SvCls.GblRdrToGetData["TchName"].ToString();
                    dtJoin.Text = SvCls.GblRdrToGetData["JoinDate"].ToString();
                    txtMobile.Text = SvCls.GblRdrToGetData["TchPhone"].ToString();
                    txtEmail.Text = SvCls.GblRdrToGetData["TchEmail"].ToString();
                    txtAddress.Text = SvCls.GblRdrToGetData["TchAddress"].ToString();
                    txtSalary.Text = SvCls.GblRdrToGetData["salary"].ToString();
                    btnSave.Text = "EDIT";

                    Grid_Head();
                }
                else
                {
                    lblMgs.ForeColor = System.Drawing.Color.Green;
                    lblMgs.Visible = true;
                    lblMgs.Text = "NO DATA FOUND...!!";
                    PicSave.Visible = true;

                    btnSave.Text = "Save";

                    txtName.Text = "";
                    txtMobile.Text = "";
                    txtAddress.Text = "";
                    txtMobile.Text = "";
                    dtJoin.Text = "";

                }
            }
        }

        private void GridTch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellId = e.RowIndex;
            DataGridViewRow row = GridTch.Rows[cellId];
            TchId = row.Cells[0].Value.ToString();
            cboTchId.Text = TchId.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            dtJoin.Text = row.Cells[2].Value.ToString();
            txtMobile.Text = row.Cells[3].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();
            txtAddress.Text = row.Cells[5].Value.ToString();
            txtSalary.Text = row.Cells[6].Value.ToString();

            btnSave.Text = "EDIT";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string DeleteQry;
                string SelectQry;

                if (cboTchId.Text.Trim() == "")
                {
                    return;
                }

                if (cboTchId.Text.Trim() == "")
                {
                    return;
                }

                SelectQry = "Select * from TchInfo where TchId='" + cboTchId.Text.Trim() + "'";
                DeleteQry = "Delete from TchInfo where TchId='" + cboTchId.Text.Trim() + "'";

                if (MessageBox.Show("Do you realy want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    if (SvCls.DataExist(SelectQry).ToString() == "1")
                    {
                        SvCls.insertUpdate(DeleteQry);

                        lblMgs.ForeColor = System.Drawing.Color.Red;
                        lblMgs.Visible = true;
                        lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                        PicSave.Visible = true;

                        Grid_Head();

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //try
            //{

            //    string DeleteQry;
            //    string SelectQry;

            //    if (cboTchId.Text.Trim() == "")
            //    {
            //        return;
            //    }

            //    SelectQry = "Select * from TchInfo where TchId='" + cboTchId.Text.Trim() + "'";
            //    DeleteQry = "Delete from TchInfo where TchId='" + cboTchId.Text.Trim() + "'";

            //    if (MessageBox.Show("Do you realy want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

            //        if (SvCls.DataExist(SelectQry).ToString() == "1")
            //        {
            //            SvCls.insertUpdate(DeleteQry);

            //            lblMgs.ForeColor = System.Drawing.Color.Red;
            //            lblMgs.Visible = true;
            //            lblMgs.Text = "DELETE SUCCESSFULLY...!!";
            //            PicSave.Visible = true;

            //            Grid_Head();

            //        }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}

