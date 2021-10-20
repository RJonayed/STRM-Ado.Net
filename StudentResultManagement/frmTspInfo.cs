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
    public partial class frmTspInfo : Form
    {
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        int cellId=0;
        string TspId;
        public frmTspInfo()
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

        private void frmTspInfo_Load(object sender, EventArgs e)
        {         
            LoadTheme();
            btnLoadGridData_Click(null, null);
            cboTspId.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboTspId.Text.Trim() == "")
            {
                MessageBox.Show("TSP ID Can't be Blank", "IDB-BISWE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTspId.Select();
                return;
            }
            if (cboTspName.Text.Trim() == "")
            {
                MessageBox.Show("TSP Name Can't be Blank", "IDB-BISWE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTspName.Select();
                return;
            }
           
            string SaveQry;
            string SelectQry;
            string EdtQry;

            SaveQry = "Insert into TspInfo(TspId,TspName,TspPhone,TspEmail,TspAddress,SrtDate,ComId,UserId,PcName)values('" + cboTspId.Text.Trim() + "','" + cboTspName.Text.Trim() + "','" + txtMobile.Text.Trim() + "','" + txtEmail.Text.Trim() + "','" + txtAddress.Text.Trim() + "',convert(datetime,'" + dtEstDate.Text.Trim() + "',103),'" + ClsVar.GblComId + "','" + ClsVar.GblUserId + "','" + ClsVar.GblPcName + "')";
            SelectQry = "Select TspName,TspPhone,TspEmail,TspAddress,SrtDate,ComId,UserId,PcName from TspInfo where TspId='" + cboTspId.Text.Trim() + "'";
            EdtQry = "Update TspInfo set TspName='" + cboTspName.Text.Trim() + "',TspPhone='" + txtMobile.Text.Trim() + "',TspEmail='" + txtEmail.Text.Trim() + "',TspAddress='" + txtAddress.Text.Trim() + "',SrtDate=CONVERT(datetime,'" + dtEstDate.Text.Trim() + "',103),ComId='" + ClsVar.GblComId + "',UserId='" + ClsVar.GblUserId + "',PcName='" + ClsVar.GblPcName + "' where TspId='" + cboTspId.Text.Trim() + "'";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {
                SvCls.insertUpdate(SaveQry);
                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                PicSave.Visible = true;

                this.BackColor = Color.Gold;

                Grid_Head();
                clear();

            }
            else
            {
                SvCls.insertUpdate(EdtQry);
                lblMgs.ForeColor = System.Drawing.Color.Green;
                lblMgs.Visible = true;
                lblMgs.Text = "EDIT SUCCESSFULLY...!!";
                PicSave.Visible = true;

                this.BackColor = Color.Orange;

                Grid_Head();
                clear();
            }           
        }

        private void btnLoadGridData_Click(object sender, EventArgs e)
        {
            string qry;
            qry = "Select TspId from TspInfo order by TspId";
            cboTspId.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboTspId.DisplayMember = "TspId";
            cboTspId.Text = "";

            qry = "Select TspName from TspInfo order by TspName";
            cboTspName.DataSource = SvCls.GblDataSet(qry).Tables[0];
            cboTspName.DisplayMember = "TspName";
            cboTspName.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {

                string DeleteQry;
                string SelectQry;

                if (cboTspId.Text.Trim() == "")
                {
                    return;
                }

                if (cboTspId.Text.Trim() == "")
                {
                    return;
                }

                SelectQry = "select * from TspInfo where TspId ='" + cboTspId.Text.Trim() + "'";
                DeleteQry = "Delete from TspInfo where TspId='" + cboTspId.Text.Trim() + "'";

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
        private void Grid_Head()
        {
            GridTsp.DataSource = SvCls.GblDataTable("Select TspId as[TSP ID],TspName as[Name],TspPhone as[Mobile],TspEmail as[Email],TspAddress as[Address],SrtDate as [ Date of Establish] from TspInfo where TspId='" + cboTspId.Text.Trim() + "'");
            GridTsp.Refresh();
            int rowCount = GridTsp.Rows.Count-1;
            lblTotal.Text = "Total Training Center : " + rowCount;           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            GridTsp.DataSource = SvCls.GblDataTable("Select TspId as[TSP ID],TspName as[Name],TspPhone as[Mobile],TspEmail as[Email],TspAddress as[Address],SrtDate as [ Date of Establish] from TspInfo order by TspId");
            GridTsp.Refresh();
            int rowCount = GridTsp.Rows.Count - 1;
            lblTotal.Text = "Total Training Centere : " + rowCount;
        }

        private void cboTspId_Leave(object sender, EventArgs e)
        {
            if (cboTspId.Text.Trim() != "")
            {
                string SelectQry;
                SelectQry = "Select TspName,TspPhone,TspEmail,TspAddress,SrtDate from TspInfo where TspId='" + cboTspId.Text.Trim() + "'";
                SvCls.toGetData(SelectQry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboTspName.Text = SvCls.GblRdrToGetData["TspName"].ToString();
                    txtMobile.Text = SvCls.GblRdrToGetData["TspPhone"].ToString();
                    txtEmail.Text = SvCls.GblRdrToGetData["TspEmail"].ToString();
                    txtAddress.Text = SvCls.GblRdrToGetData["TspAddress"].ToString();
                    dtEstDate.Text = SvCls.GblRdrToGetData["SrtDate"].ToString();
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
                    cboTspName.Text = "";
                    txtMobile.Text = "";
                    txtAddress.Text = "";
                    txtMobile.Text = "";
                    dtEstDate.Text ="";
                    txtEmail.Text = "";

                }
            }
        }
        private void clear()
        {
            cboTspName.Text = "";
            txtMobile.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            dtEstDate.Text = "";
            txtEmail.Text = "";
            cboTspId.Text = "";
        }
        private void cboTspId_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar.ToString() == "\r")
            {
                cboTspName.Select();
            }
        }      
        private void GridTch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellId = e.RowIndex;
            DataGridViewRow row = GridTsp.Rows[cellId];
            TspId = row.Cells[0].Value.ToString();
            cboTspId.Text = TspId.ToString();
            cboTspName.Text = row.Cells[1].Value.ToString();
            txtMobile.Text = row.Cells[2].Value.ToString();
            txtEmail.Text = row.Cells[3].Value.ToString();
            txtAddress.Text = row.Cells[4].Value.ToString();
            dtEstDate.Text = row.Cells[5].Value.ToString();

            btnSave.Text = "EDIT";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMgs.Visible = false;
            PicSave.Visible = false;
            this.BackColor = Color.White;
        }

        private void btnRpt_Click(object sender, EventArgs e)
        {
            
        }
    }
}
