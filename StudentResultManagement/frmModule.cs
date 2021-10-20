using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace StudentResultManagement.Forms
{
    public partial class frmModule : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        int cellId = 0;
        public frmModule()
        {
            InitializeComponent();
        }

        private void frmModule_Load(object sender, EventArgs e)
        {
            LoadTheme();
            loadCombo();

            cboCourseName.Select();
            txtMdCost.Text = "0";
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
        private void loadCombo()
        {
            string Qry;
            Qry = "Select MdlId from ModuleDtls order by MdlId";
            cbomdlId.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cbomdlId.DisplayMember = "MdlId";
            cbomdlId.Text = "";

            Qry = "Select CrsName from CourseDtls order by CrsName";
            cboCourseName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboCourseName.DisplayMember = "CrsName";
            cboCourseName.Text = "";

            txtMdCost.Text = "0";
            cbomdlId.Select();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbomdlId.Text.Trim() == "")
            {
                MessageBox.Show("Module ID Can't be Blank", "IDB-BISWE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomdlId.Select();
                return;
            }
            if (cbomdlId.Text.Trim() == "")
            {
                MessageBox.Show("Module Name Can't be Blank", "IDB-BISWE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomdlId.Select();
                return;
            }
            string SaveQry;
            string SelectQry;
            string EdtQry;
            
            SaveQry = "Insert into ModuleDtls(ComId, MdlId, CrsId, MdlName, MdlFees, UserId,rmk, PcName)values('" + ClsVar.GblComId + "', '" + cbomdlId.Text.Trim() + "', '" + txtcrId.Text.Trim() + "', '" + cboMdName.Text.Trim() + "', '" + txtMdCost.Text.Trim() + "', '" + ClsVar.GblUserId + "','" + txtRmk.Text.Trim() + "', '" + ClsVar.GblPcName + "')";
            SelectQry = "Select ComId, MdlName, MdlFees, UserId,rmk, PcName from ModuleDtls where CrsId='" + txtcrId.Text.Trim() + "'and MdlId = '" + cbomdlId.Text.Trim() + "'";
            EdtQry = "Update ModuleDtls set ComId = '" + ClsVar.GblComId + "', CrsId = '" + txtcrId.Text.Trim() + "', MdlName = '" + cboMdName.Text.Trim() + "', MdlFees = '" + txtMdCost.Text.Trim() + "', UserId = '" + ClsVar.GblUserId + "', rmk='" + txtRmk.Text.Trim() + "',PcName = '" + ClsVar.GblPcName + "' where CrsId='" + txtcrId.Text.Trim() + "' and MdlId = '" + cbomdlId.Text.Trim() + "'";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {
                SvCls.insertUpdate(SaveQry);
                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                PicSave.Visible = true;
                Grid_Head();
                this.BackColor = Color.Green;

                cboCourseName.Select();
            }
            else
            {
                SvCls.insertUpdate(EdtQry);
                lblMgs.ForeColor = System.Drawing.Color.Green;
                lblMgs.Visible = true;
                lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                PicSave.Visible = true;

                this.BackColor = Color.Gold;
                Grid_Head();

                cboCourseName.Select();
            }
        }

        private void Grid_Head()
        {
            GridModule.DataSource = SvCls.GblDataTable("select MdlId as[Module ID],md.CrsId as[Course ID],cr.CrsName as[Course Name], MdlName as[Module Name], MdlFees as[Module Cost],md.rmk as[Remarks] from ModuleDtls md,CourseDtls cr where md.CrsId=cr.CrsId  and MdlId='" + cbomdlId.Text.Trim() + "'");
            GridModule.Refresh();
            int rowCount = GridModule.Rows.Count - 1;
            lblTotal.Text = "Count Module : " + rowCount;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            GridModule.DataSource = SvCls.GblDataTable("select MdlId as[Module ID],md.CrsId as[Course ID],cr.CrsName as[Course Name], MdlName as[Module Name], MdlFees as[Module Cost],md.rmk as[Remarks] from ModuleDtls md,CourseDtls cr where md.CrsId=cr.CrsId order by MdlId");
            GridModule.Refresh();
            int rowCount = GridModule.Rows.Count - 1;
            lblTotal.Text = "Count Module : " + rowCount;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PicSave.Visible = false;
            lblMgs.Visible = false;
            this.BackColor = Color.White;
        }

        private void cbomdlId_Leave(object sender, EventArgs e)
        {
            
        }

        private void cboCourseName_Leave(object sender, EventArgs e)
        {
            if (cboCourseName.Text.Trim() != "")
            {
                string SelectQry;
                SelectQry = "select md.MdlId,md.CrsId, MdlName, MdlFees,md.rmk from ModuleDtls md,CourseDtls cr where md.CrsId=cr.CrsId and cr.CrsName='" + cboCourseName.Text.Trim() + "'";
                SvCls.toGetData(SelectQry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cbomdlId.Text = SvCls.GblRdrToGetData["MdlId"].ToString();
                    txtcrId.Text = SvCls.GblRdrToGetData["CrsId"].ToString();
                    cboMdName.Text = SvCls.GblRdrToGetData["MdlName"].ToString();
                    txtMdCost.Text = SvCls.GblRdrToGetData["MdlFees"].ToString();
                    txtRmk.Text = SvCls.GblRdrToGetData["rmk"].ToString();

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

                    txtRmk.Text = "";
                    txtMdCost.Text = "0";
                    cboMdName.Text = "";
                    txtcrId.Text = "";
                    //cboCourseName.Text = "";
                }
            }
    }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string DeleteQry;
                string SelectQry;

                if (cbomdlId.Text.Trim() == "")
                {
                    return;
                }               

                SelectQry = "Select* from ModuleDtls where MdlId = '" + cbomdlId.Text.Trim() + "'";
                DeleteQry = "Delete from ModuleDtls where MdlId = '" + cbomdlId.Text.Trim() + "'";

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
        }

        private void GridModule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {          
            int i;
            i = GridModule.SelectedCells[0].RowIndex;
            cbomdlId.Text = GridModule.Rows[i].Cells[0].Value.ToString();
            txtcrId.Text = GridModule.Rows[i].Cells[1].Value.ToString();
            cboCourseName.Text = GridModule.Rows[i].Cells[2].Value.ToString();
            cboMdName.Text = GridModule.Rows[i].Cells[3].Value.ToString();
            txtMdCost.Text = GridModule.Rows[i].Cells[4].Value.ToString();
            txtRmk.Text = GridModule.Rows[i].Cells[5].Value.ToString();

            btnSave.Text = "Edit";
        }

        private void GridModule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRpt_Click(object sender, EventArgs e)
        {
           
        }
    }
}
