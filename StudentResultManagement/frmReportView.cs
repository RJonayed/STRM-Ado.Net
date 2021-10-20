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
    public partial class frmReportView : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public frmReportView()
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
            label5.ForeColor = ThemColor.primaryColor;
        }

        private void frmReportView_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnStInfo_Click(object sender, EventArgs e)
        {
            List<StudentFileds> list = new List<StudentFileds>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select StudentId,StName,Phone,Email,Addresss,ImageData from Student";
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr, LoadOption.Upsert);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    StudentFileds obj = new StudentFileds();
                    obj.StId = dt.Rows[i]["StudentId"].ToString();
                    obj.name = dt.Rows[i]["StName"].ToString();
                    obj.mobile = dt.Rows[i]["Phone"].ToString();       
                    obj.email = dt.Rows[i]["Email"].ToString();
                    obj.ImageData = (byte[])dt.Rows[i]["ImageData"];
                    obj.address = dt.Rows[i]["Addresss"].ToString();
                    list.Add(obj);
                }
            }

            using (frmRptStudent frn = new frmRptStudent(list))
            {
                frn.ShowDialog();
            }
        }

        private void btnCrsInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmissionRpt_Click(object sender, EventArgs e)
        {

        }

        private void btnRptTsp_Click(object sender, EventArgs e)
        {
            List<TspFiled> list = new List<TspFiled>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select TspId,TspName,TspPhone,TspEmail,TspAddress,SrtDate from TspInfo";
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr, LoadOption.Upsert);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TspFiled obj = new TspFiled();
                    obj.TspId = dt.Rows[i]["TspId"].ToString();
                    obj.TspName = dt.Rows[i]["TspName"].ToString();
                    obj.TspPhone = dt.Rows[i]["TspPhone"].ToString();
                    obj.TspEmail = dt.Rows[i]["TspEmail"].ToString();
                    obj.TspAddress = dt.Rows[i]["TspAddress"].ToString();
                    obj.SrtDate = Convert.ToDateTime(dt.Rows[i]["SrtDate"].ToString());
                    list.Add(obj);
                }
            }

            using (frmRptTsp frn = new frmRptTsp(list))
            {
                frn.ShowDialog();
            }
        }

        private void btnTchInfo_Click(object sender, EventArgs e)
        {
            List<TeachersFields> list = new List<TeachersFields>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select TchId,TchName,JoinDate,TchPhone,TchEmail,TchAddress,salary from TchInfo";
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr, LoadOption.Upsert);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TeachersFields obj = new TeachersFields();
                    obj.TchId = dt.Rows[i]["TchId"].ToString();
                    obj.TchName = dt.Rows[i]["TchName"].ToString();
                    obj.TchPhone = dt.Rows[i]["TchPhone"].ToString();
                    obj.TchEmail = dt.Rows[i]["TchEmail"].ToString();
                    obj.TchAddress = dt.Rows[i]["TchAddress"].ToString();
                    obj.salary = Convert.ToDecimal(dt.Rows[i]["salary"].ToString());
                    obj.JoinDate = Convert.ToDateTime(dt.Rows[i]["JoinDate"].ToString());
                    list.Add(obj);
                }
            }

            using (frmRptTeachers frn = new frmRptTeachers(list))
            {
                frn.ShowDialog();
            }      
    }
    }
}
