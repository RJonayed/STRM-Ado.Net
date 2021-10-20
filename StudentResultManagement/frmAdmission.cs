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

namespace StudentResultManagement.Forms
{
    public partial class frmAdmission : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        ClsMain SvCls = new ClsMain();
        ClsVar ClsVar = new ClsVar();
        public frmAdmission()
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
        private void frmAdmission_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadCombo();

            cboClsRoll.Select();

            txtAdsCost.Text = "0";
            txtCrsCost.Text = "0";

        }
        private void LoadCombo()
        {
            string Qry;
            Qry = "Select clsRoll from Admissions order by clsRoll";
            cboClsRoll.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboClsRoll.DisplayMember = "clsRoll";
            cboClsRoll.Text = "";

            Qry = "Select TchName from TchInfo order by TchName ";
            cboTchName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboTchName.DisplayMember = "TchName";
            cboTchName.Text = "";

            Qry = "Select StName from Student order by StName";
            cboStName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboStName.DisplayMember = "StName";
            cboStName.Text = "";

            Qry = "Select CrsName from CourseDtls order by CrsName ";
            cboCrsName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboCrsName.DisplayMember = "CrsName";
            cboCrsName.Text = "";

            Qry = "Select MdlName from ModuleDtls order by MdlName ";
            cboMdlName.DataSource = SvCls.GblDataSet(Qry).Tables[0];
            cboMdlName.DisplayMember = "MdlName";
            cboMdlName.Text = "";
        }

        private void cboTchName_Leave(object sender, EventArgs e)
        {
            if (cboTchName.Text.Trim() != "")
            {
                string SelectQry;
                SelectQry = "Select TchId from TchInfo where TchName='" + cboTchName.Text.Trim() + "'";
                SvCls.toGetData(SelectQry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    txtTchId.Text = SvCls.GblRdrToGetData["TchId"].ToString();
                }
            }
            }

        private void cboTchName_TextChanged(object sender, EventArgs e)
        {
            //cboTchName_Leave(null,null);
        }

        private void cboStName_Leave(object sender, EventArgs e)
        {

            if (cboStName.Text.Trim() != "")
            {
                string SelectQry;
                SelectQry = "Select StudentId from Student where StName='" + cboStName.Text.Trim() + "'";
                SvCls.toGetData(SelectQry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    txtStId.Text = SvCls.GblRdrToGetData["StudentId"].ToString();
                }
            }
        }

        private void cboCrsName_Leave(object sender, EventArgs e)
        {

            if (cboCrsName.Text.Trim() != "")
            {
                string SelectQry;
                SelectQry = "Select CrsId,CrsFee from CourseDtls where CrsName='" + cboCrsName.Text.Trim() + "'";
                SvCls.toGetData(SelectQry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    txtCrsId.Text = SvCls.GblRdrToGetData["CrsId"].ToString();
                    txtCrsCost.Text = SvCls.GblRdrToGetData["CrsFee"].ToString();
                }
            }
        }

        private void cboMdlName_Leave(object sender, EventArgs e)
        {

            if (cboMdlName.Text.Trim() != "")
            {
                string SelectQry;
                SelectQry = "Select MdlId from ModuleDtls where MdlName='" + cboMdlName.Text.Trim() + "'";
                SvCls.toGetData(SelectQry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    txtMdlId.Text = SvCls.GblRdrToGetData["MdlId"].ToString();
                }
            }
        }

        private void cboStName_TextChanged(object sender, EventArgs e)
        {
            //cboStName_Leave(null,null);
        }

        private void cboCrsName_TextChanged(object sender, EventArgs e)
        {
            //cboCrsName_Leave(null,null);
        }

        private void cboMdlName_TextChanged(object sender, EventArgs e)
        {
           //cboMdlName_Leave(null,null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboClsRoll.Text.Trim() == "")
            {
                MessageBox.Show("Class Roll Can't be Blank", "IDB-BISWE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboClsRoll.Select();
                return;
            }
            if (cboTchName.Text.Trim() == "")
            {
                MessageBox.Show("Teacher Name Can't be Blank", "IDB-BISWE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTchName.Select();
                return;
            }
            string SaveQry;
            string SelectQry;
            string EdtQry;

            SaveQry = "Insert into Admissions(ClsRoll,TchId,StId,CrsId,MdlId,AdsCost,CourseCost,AdsDate)values('" + cboClsRoll.Text.Trim() + "','" + txtTchId.Text.Trim() + "','" + txtStId.Text.Trim() + "','" + txtCrsId.Text.Trim() + "','" + txtMdlId.Text.Trim() + "','" + txtAdsCost.Text.Trim() + "','" + txtCrsCost.Text.Trim() + "',convert(datetime,'" + DtAdsDate.Text.Trim() + "',103))";
            SelectQry = "select TchId,StId,CrsId,MdlId,AdsCost,CourseCost,AdsDate from Admissions where ClsRoll='" + cboClsRoll.Text.Trim() + "'";
            EdtQry = "Update Admissions set TchId='" + txtTchId.Text.Trim() + "',StId='" + txtStId.Text.Trim() + "',CrsId='" + txtCrsId.Text.Trim() + "',MdlId='" + txtMdlId.Text.Trim() + "',AdsCost='" + txtAdsCost.Text.Trim() + "',CourseCost='" + txtCrsCost.Text.Trim() + "',AdsDate=convert(datetime,'" + DtAdsDate.Text.Trim() + "',103) where ClsRoll='" + cboClsRoll.Text.Trim() + "'";

            if (SvCls.DataExist(SelectQry).ToString() == "0")
            {
                SvCls.insertUpdate(SaveQry);
                lblMgs.ForeColor = System.Drawing.Color.Blue;
                lblMgs.Visible = true;
                lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                PicSave.Visible = true;
                Grid_Head();
                //clearData();
                this.BackColor = Color.Green;
                cboClsRoll.Select();
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
                clearData();

                cboClsRoll.Select();
            }
        }

        private void Grid_Head()
        {
            GridAdmission.DataSource = SvCls.GblDataTable("Select ad.clsRoll as[Roll No],tc.TchId as[Teacher ID],tc.TchName as[Teacher Name],st.StudentId as[Student Id],st.StName as[Student Name],cr.CrsId as[Course ID],cr.CrsName as[Course Name],md.MdlId as[Module ID],md.MdlName as[Module Name],adsCost as[Admission Cost],courseCost as[Course Cost],adsdate as[Date] from Admissions ad,TchInfo tc,CourseDtls cr,Student st,ModuleDtls md where ad.TchId=tc.TchId and ad.CrsId=cr.CrsId and ad.StId=st.StudentId and ad.MdlId=md.MdlId and ad.clsRoll='" + cboClsRoll.Text.Trim() + "'");
            GridAdmission.Refresh();
            int rowCount = GridAdmission.Rows.Count - 1;
            lblTotal.Text = "Total Admission : " + rowCount;
        }

        private void GridAdmission_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = GridAdmission.SelectedCells[0].RowIndex;
            cboClsRoll.Text = GridAdmission.Rows[i].Cells[0].Value.ToString();
            txtTchId.Text = GridAdmission.Rows[i].Cells[1].Value.ToString();
            cboTchName.Text = GridAdmission.Rows[i].Cells[2].Value.ToString();
            txtStId.Text = GridAdmission.Rows[i].Cells[3].Value.ToString();
            cboStName.Text = GridAdmission.Rows[i].Cells[4].Value.ToString();
            txtCrsId.Text = GridAdmission.Rows[i].Cells[5].Value.ToString();
            cboCrsName.Text = GridAdmission.Rows[i].Cells[6].Value.ToString();
            txtMdlId.Text = GridAdmission.Rows[i].Cells[7].Value.ToString();
            cboMdlName.Text = GridAdmission.Rows[i].Cells[8].Value.ToString();
            txtAdsCost.Text = GridAdmission.Rows[i].Cells[9].Value.ToString();
            txtCrsCost.Text = GridAdmission.Rows[i].Cells[10].Value.ToString();
            DtAdsDate.Text = GridAdmission.Rows[i].Cells[11].Value.ToString();

            btnSave.Text = "Edit";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string DeleteQry;
                string SelectQry;

                if (cboClsRoll.Text.Trim() == "")
                {
                    return;
                }

                SelectQry = "Select * from Admissions where clsRoll='" + cboClsRoll.Text.Trim() + "'";
                DeleteQry = "Delete from Admissions where clsRoll='" + cboClsRoll.Text.Trim() + "'";

                if (MessageBox.Show("Do you realy want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    if (SvCls.DataExist(SelectQry).ToString() == "1")
                    {
                        SvCls.insertUpdate(DeleteQry);
                        lblMgs.ForeColor = System.Drawing.Color.Red;
                        this.BackColor = Color.Red;
                        lblMgs.Visible = true;
                        lblMgs.Text = "DELETE SUCCESSFULLY...!!";
                        PicSave.Visible = true;
                        Grid_Head();
                        //clearData();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            GridAdmission.DataSource = SvCls.GblDataTable("Select ad.clsRoll as[Roll No],tc.TchId as[Teacher ID],tc.TchName as[Teacher Name],st.StudentId as[Student Id],st.StName as[Student Name],cr.CrsId as[Course ID],cr.CrsName as[Course Name],md.MdlId as[Module ID],md.MdlName as[Module Name],adsCost as[Admission Cost],courseCost as[Course Cost],adsdate as[Date] from Admissions ad,TchInfo tc,CourseDtls cr,Student st,ModuleDtls md where ad.TchId=tc.TchId and ad.CrsId=cr.CrsId and ad.StId=st.StudentId and ad.MdlId=md.MdlId");
            GridAdmission.Refresh();
            int rowCount = GridAdmission.Rows.Count - 1;
            lblTotal.Text = "Count Module : " + rowCount;
        }

        private void cboClsRoll_Leave(object sender, EventArgs e)
        {
            if (cboClsRoll.Text.Trim() != "")
            {
                string SelectQry;
                SelectQry = "Select tc.TchId,tc.TchName,st.StudentId,st.StName,cr.CrsId,cr.CrsName,md.MdlId,md.MdlName,adsCost,courseCost,adsdate from Admissions ad,TchInfo tc,CourseDtls cr,Student st,ModuleDtls md where ad.TchId=tc.TchId and ad.CrsId=cr.CrsId and ad.StId=st.StudentId and ad.MdlId=md.MdlId and ad.clsRoll='" + cboClsRoll.Text.Trim() + "'";
                SvCls.toGetData(SelectQry);
                if (SvCls.GblRdrToGetData.Read())
                {
                    cboTchName.Text = SvCls.GblRdrToGetData["TchName"].ToString();
                    txtTchId.Text = SvCls.GblRdrToGetData["TchId"].ToString();
                    cboStName.Text = SvCls.GblRdrToGetData["StName"].ToString();
                    txtStId.Text = SvCls.GblRdrToGetData["StudentId"].ToString();
                    cboCrsName.Text = SvCls.GblRdrToGetData["CrsName"].ToString();
                    txtCrsId.Text = SvCls.GblRdrToGetData["CrsId"].ToString();

                    cboMdlName.Text = SvCls.GblRdrToGetData["MdlName"].ToString();
                    txtMdlId.Text = SvCls.GblRdrToGetData["MdlId"].ToString();
                    txtAdsCost.Text = SvCls.GblRdrToGetData["adsCost"].ToString();
                    txtCrsCost.Text = SvCls.GblRdrToGetData["CourseCost"].ToString();
                    DtAdsDate.Text = SvCls.GblRdrToGetData["AdsDate"].ToString();
                }
                else
                {
                    lblMgs.ForeColor = System.Drawing.Color.Green;
                    lblMgs.Visible = true;
                    lblMgs.Text = "NO DATA FOUND...!!";
                    PicSave.Visible = true;

                    btnSave.Text = "Save";
                    //cboMdlName.Text = "";
                    //cboCrsName.Text = "";
                    //cboStName.Text = "";
                    //cboTchName.Text = "";
                    //txtAdsCost.Text = "";
                    //txtCrsCost.Text = "";
                    //txtCrsId.Text = "";
                    //txtStId.Text = "";
                    //txtTchId.Text = "";
                    //txtMdlId.Text = "";
                    DtAdsDate.Text = DateTime.Now.ToString();
                }
            }
        }
        private void clearData()
        {
            cboClsRoll.Text = "";
            cboMdlName.Text = "";
            cboCrsName.Text = "";
            cboStName.Text = "";
            cboTchName.Text = "";
            txtAdsCost.Text = "";
            txtCrsCost.Text = "";
            txtCrsId.Text = "";
            txtStId.Text = "";
            txtTchId.Text = "";
            txtMdlId.Text = "";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMgs.Visible = false;
            PicSave.Visible = false;
            this.BackColor = Color.White;
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            List<ReportFiled> list = new List<ReportFiled>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select clsRoll,st.StName,st.ImageData,st.ImageName,tc.TchName,cr.CrsName,AdsCost,CourseCost,AdsDate from Admissions ad,Student st,TchInfo tc,CourseDtls cr where ad.StId=st.StudentId and ad.TchId=tc.TchId and ad.CrsId=cr.CrsId";
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr, LoadOption.Upsert);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ReportFiled obj = new ReportFiled();
                    obj.ClsRoll = dt.Rows[i]["clsRoll"].ToString();
                    obj.StName = dt.Rows[i]["StName"].ToString();
                    obj.ImageData = (byte[])dt.Rows[i]["ImageData"];
                    obj.ImageName = dt.Rows[i]["ImageName"].ToString();
                    obj.TchName = dt.Rows[i]["TchName"].ToString();
                    obj.CrsName = dt.Rows[i]["CrsName"].ToString();
                    obj.AdsCost = Convert.ToDecimal(dt.Rows[i]["AdsCost"].ToString());
                    obj.CourseCost = Convert.ToDecimal(dt.Rows[i]["CourseCost"].ToString());                
                    obj.AdsDate = Convert.ToDateTime(dt.Rows[i]["AdsDate"].ToString());                  
                    list.Add(obj);
                }
            }

            using (frmReport frn = new frmReport(list))
            {
                frn.ShowDialog();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            pnlGrid.Visible = true;
            pnlGrid.Size = new System.Drawing.Size(781, 435);       
        }
    }
}
