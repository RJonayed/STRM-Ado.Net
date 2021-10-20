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
    public partial class frmCourseInfo : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        int cellId = 0;
        int courseId;
        int ck = 0;
        public frmCourseInfo()
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

        private void frmCourseInfo_Load(object sender, EventArgs e)
        {
            LoadTheme();
            string Qry = "Select CrsId from CourseDtls";
            cboCoursId.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboCoursId.DisplayMember = "CrsId";
            cboCoursId.Text = "";

            txtCost.Text = "0";
            cboCoursId.Select();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboCoursId.Text.Trim() == "")
            {
                MessageBox.Show("Course ID Can't be Blank", "IDB-BISWE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboName.Select();
                return;
            }
            if (cboName.Text.Trim() == "")
            {
                MessageBox.Show("Course Name Can't be Blank", "IDB-BISWE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboName.Select();
                return;
            }
            string SaveQry;
            string SelectQry;
            string EdtQry;
            
            SaveQry = "Insert into CourseDtls(ComId, CrsId, CrsName, CrsDuratin, CrsFee, UserId, PcName,Rmk,chkMonth,chkYear)values('" + ClsVar.GblComId + "', '" + cboCoursId.Text.Trim() + "', '" + cboName.Text.Trim() + "', '" + cboDuratin.Text.Trim() + "','" + txtCost.Text.Trim() + "', '" + ClsVar.GblUserId + "', '" + ClsVar.GblPcName + "','" + txtRmk.Text.Trim() + "'," + Convert.ToInt16(chkMonth.Checked) + ","+ Convert.ToInt16(chkYear.Checked) +")";
            SelectQry = "Select ComId, CrsName, CrsDuratin, CrsFee, UserId, PcName,Rmk,chkMonth,chkYear From CourseDtls where CrsId = '" + cboCoursId.Text.Trim() + "'";
            EdtQry = "Update CourseDtls set ComId = '" + ClsVar.GblComId + "', CrsName = '" + cboName.Text.Trim() + "', CrsDuratin = '" + cboDuratin.Text.Trim() + "', CrsFee = '" + txtCost.Text.Trim() + "', UserId = '" + ClsVar.GblUserId + "', PcName = '" + ClsVar.GblPcName + "',Rmk='" + txtRmk.Text.Trim() + "',chkMonth=" + Convert.ToInt16(chkMonth.Checked) + ",chkYear='" + Convert.ToInt16(chkYear.Checked) + "' where CrsId = '" + cboCoursId.Text.Trim() + "'";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {
                SvCls.insertUpdate(SaveQry);
                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                PicSave.Visible = true;
                Grid_Head();
                this.BackColor = Color.Green;
                clear();
            }
            else
            {
                SvCls.insertUpdate(EdtQry);
                lblMgs.ForeColor = System.Drawing.Color.Green;
                lblMgs.Visible = true;
                lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                PicSave.Visible = true;
                clear();
                this.BackColor = Color.Gold;

                Grid_Head();
            }
        }

        private void Grid_Head()
        {
            GridCourse.DataSource = SvCls.GblDataTable("Select CrsId as[Course ID],CrsName as[Course Name], CrsDuratin as[Duration], CrsFee as[Course Fee],chkMonth as[Month],chkYear as[Year],Rmk as[Remarks] From CourseDtls where CrsId ='" + cboCoursId.Text.Trim() + "'");
            GridCourse.Refresh();
            int rowCount = GridCourse.Rows.Count - 1;
            lblTotal.Text = "Total Course : " + rowCount;
        }

        private void cboCoursId_Leave(object sender, EventArgs e)
        {
            if (cboCoursId.Text.Trim() != "")
            {
                string SelectQry;
                SelectQry = "Select CrsName, CrsDuratin, CrsFee,Rmk,chkMonth,chkYear From CourseDtls where CrsId ='" + cboCoursId.Text.Trim() + "'";
                SvCls.toGetData(SelectQry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboName.Text = SvCls.GblRdrToGetData["CrsName"].ToString();
                    cboDuratin.Text = SvCls.GblRdrToGetData["CrsDuratin"].ToString();
                    txtCost.Text = SvCls.GblRdrToGetData["CrsFee"].ToString();
                    txtRmk.Text = SvCls.GblRdrToGetData["Rmk"].ToString();
                    ck = Convert.ToInt32(SvCls.GblRdrToGetData["chkMonth"].ToString());
                    ck = Convert.ToInt32(SvCls.GblRdrToGetData["chkYear"].ToString());
                    if (ck == 1)
                    {
                        chkMonth.Checked = true;
                    }
                    else
                    {
                        chkMonth.Checked = false;
                    }
                    if (ck == 1)
                    {
                        chkYear.Checked = true;
                    }
                    else
                    {
                        chkYear.Checked = false;
                    }
                    btnSave.Text = "EDIT";       
                    Grid_Head();
                }
                else
                {
                    lblMgs.ForeColor = System.Drawing.Color.Green;
                    lblMgs.Visible = true;
                    lblMgs.Text = "NO DATA FOUND...!!";
                    PicSave.Visible = true;

                    txtRmk.Text = "";
                    txtCost.Text = "0";
                    cboDuratin.Text = "";
                    cboName.Text = "";

                    btnSave.Text = "Save";                   
                }
            }
        }
        private void clear()
        {
            txtRmk.Text = "";
            txtCost.Text = "0";
            cboDuratin.Text = "";
            cboName.Text = "";
            cboCoursId.Text = "";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            PicSave.Visible = false;
            lblMgs.Visible = false;
            this.BackColor = Color.White;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GridCourse.DataSource = SvCls.GblDataTable("Select CrsId as[Course ID],CrsName as[Course Name], CrsDuratin as[Duration], CrsFee as[Course Fee],chkMonth as[Month],chkYear as[Year],Rmk as[Remarks] From CourseDtls order by CrsId ");
            GridCourse.Refresh();
            int rowCount = GridCourse.Rows.Count - 1;
            lblTotal.Text = "Total Course : " + rowCount;
        }

        private void GridCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GridCourse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = GridCourse.SelectedCells[0].RowIndex;
            cboCoursId.Text = GridCourse.Rows[i].Cells[0].Value.ToString();
            cboName.Text = GridCourse.Rows[i].Cells[1].Value.ToString();
            cboDuratin.Text = GridCourse.Rows[i].Cells[2].Value.ToString();
            txtCost.Text = GridCourse.Rows[i].Cells[3].Value.ToString();
            txtRmk.Text = GridCourse.Rows[i].Cells[4].Value.ToString();

            btnSave.Text = "Edit";
            //chkMonth.Text = GridCourse.Rows[i].Cells[6].Value.ToString());
            //chkYear.Text = GridCourse.Rows[i].Cells[7].Value.ToString();

            if (ck == 1)
            {
                chkMonth.Checked = true;
            }

            if (ck == 1)
            {
                chkYear.Checked = true;
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {

                string DeleteQry;
                string SelectQry;

                if (cboCoursId.Text.Trim() == "")
                {
                    return;
                }              

                SelectQry = "Select * from Coursedtls where CrsId='" + cboCoursId.Text.Trim() + "'";
                DeleteQry = "Delete from CourseDtls where CrsId='" + cboCoursId.Text.Trim() + "'";

                if (MessageBox.Show("Do you realy want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    if (SvCls.DataExist(SelectQry).ToString() == "1")
                    {
                        SvCls.insertUpdate(DeleteQry);

                        lblMgs.ForeColor = System.Drawing.Color.Red;
                        lblMgs.Visible = true;
                        lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                        PicSave.Visible = true;
                        this.BackColor = Color.Red;
                        Grid_Head();
                        clear();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
