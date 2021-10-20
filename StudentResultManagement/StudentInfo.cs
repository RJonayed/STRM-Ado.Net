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
    public partial class frmStudent : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        //ClsMain SvCls = new ClsMain();
        //ClsVar ClsVar = new ClsVar();
        string imgLocatin;
        string studentId;
        int cellId;
        public frmStudent()
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

        private void StudentInfo_Load(object sender, EventArgs e)
        {

            LoadTheme();
            txtPrMobile.Text = "8801";
            ComData();         
        }
        private void clearData()
        {
            cboStId.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPrMobile.Text = "8801";
            txtAddress.Text = "";
            dtBith.Text = DateTime.Now.ToString();
        }
        private void ComData()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select StudentId from Student";
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr, LoadOption.Upsert);
                cboStId.DisplayMember = "StudentId";
                cboStId.ValueMember = "StudentId";
                cboStId.DataSource = dt;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocatin = dialog.FileName.ToString();
                imgbx.ImageLocation = imgLocatin;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] pic = null;
            FileStream stream = new FileStream(imgLocatin, FileMode.Open, FileAccess.Read);
            BinaryReader brdr = new BinaryReader(stream);
            pic = brdr.ReadBytes((int)(stream.Length));
            using (SqlConnection con = new SqlConnection(conStr))
            {
                int count;
                string file = imgLocatin;
                string[] farray = file.Split('\\');
                string fn = farray[farray.Length - 1];
                string des = @"E:\IDB-BiSEWITScholarship\XMLModule_5\Ado.Net\Projects\STRM\StudentResultManagement\Images\" + fn;
                File.Copy(file, des, true);

                SqlCommand cmd = con.CreateCommand();
                StudentFileds st = new StudentFileds();
                st.StId = cboStId.Text;
                st.name = txtName.Text;
                st.mobile = txtPrMobile.Text;
                st.email = txtEmail.Text;
                st.address = txtAddress.Text;
                st.dateofbirth = Convert.ToDateTime(dtBith.Text);
                st.ImageData = pic;
                st.ImageName = file;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Student (StudentId,StName,Phone,DateOfbirth,Email,Addresss,ImageName,ImageData)values('" + st.StId + "', '" + st.name + "', '" + st.mobile + "', '" + st.address + "', '" + st.email + "','" + st.dateofbirth + "','" + st.ImageName + "',@img)";
                cmd.Parameters.Add(new SqlParameter("@img", st.ImageData));
                con.Open();

                count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    lblMgs.ForeColor = System.Drawing.Color.Blue;
                    lblMgs.Visible = true;
                    lblMgs.Text = "SAVED SUCCESSFULLY...!!";
                    ComData();
                    this.BackColor = Color.Green;
                    PicSave.Visible = true;
                    LoadDgDataView();
                    clearData();
                    cboStId.Select();
                }
            }
        }
        private void LoadDgDataView()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " select StudentId as[Student Id],StName as[Name],Phone as[Mobile],DateOfbirth as[Date Of birth],Email,Addresss as[Address],ImageData as[Image] from Student";
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr, LoadOption.Upsert);
                GridStudent.DataSource = dt;
                //GridStudent.RowTemplate.MinimumHeight = 50;
                DataGridViewImageColumn imgCl = new DataGridViewImageColumn();
                imgCl = (DataGridViewImageColumn)GridStudent.Columns[6];
                imgCl.ImageLayout = DataGridViewImageCellLayout.Stretch;
                stCount();
                //GridStudent.Columns[8].Visible = false;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (studentId!="")
            {
                byte[] pic = null;
                FileStream stream = new FileStream(imgLocatin, FileMode.Open, FileAccess.Read);
                BinaryReader brdr = new BinaryReader(stream);
                pic = brdr.ReadBytes((int)(stream.Length));
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    int cout = 0;
                    string file = imgLocatin;
                    string[] farray = file.Split('\\');
                    string fn = farray[farray.Length - 1];
                    string des = @"E:\IDB-BiSEWITScholarship\XMLModule_5\Ado.Net\Projects\STRM\StudentResultManagement\Images\" + fn;
                    //File.Copy(file, des, true);
                    SqlCommand cmd = con.CreateCommand();
                    StudentFileds st = new StudentFileds();
                    st.StId = cboStId.Text;
                    st.name = txtName.Text;
                    st.mobile = txtPrMobile.Text;
                    st.email = txtEmail.Text;
                    st.address = txtAddress.Text;
                    st.dateofbirth = Convert.ToDateTime(dtBith.Text);
                    st.ImageData = pic;
                    st.ImageName = file;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Update Student Set StName='" + st.name + "',Phone='" + st.mobile + "',DateOfbirth='" + st.dateofbirth + "',Email='" + st.email + "',Addresss='" + st.address + "',ImageName='" + st.ImageName + "',ImageData=@img where StudentId='" + st.StId + "'";
                    cmd.Parameters.Add(new SqlParameter("@img", st.ImageData));
                    con.Open();

                    cout = cmd.ExecuteNonQuery();
                    if (cout > 0)
                    {
                        MessageBox.Show("Do you want to Update!");
                        this.BackColor = Color.Orange;

                        {
                            lblMgs.ForeColor = System.Drawing.Color.Blue;
                            lblMgs.Visible = true;
                            lblMgs.Text = "Update SUCCESSFULLY...!!";
                            PicSave.Visible = true;
                            LoadDgDataView();
                            clearData();

                            ComData();

                            cboStId.Select();
                        }
                    }
                }
            }
        }

        private void GridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //select StudentId, StName, Phone, DateOfbirth, Email, Addresss, ImageData
            cellId = e.RowIndex;
            DataGridViewRow row = GridStudent.Rows[cellId];
            studentId = row.Cells[0].Value.ToString();
            cboStId.Text = studentId.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtPrMobile.Text = row.Cells[2].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();
            txtAddress.Text = row.Cells[5].Value.ToString();


            byte[] data = (byte[])row.Cells[6].Value;
            MemoryStream stream = new MemoryStream(data);
            imgbx.Image = Image.FromStream(stream);
            imgbx.SizeMode = PictureBoxSizeMode.StretchImage;

            string fileName = row.Cells[6].Value.ToString();
            imgLocatin = fileName;
            btnSave.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (studentId!="")
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    int cout = 0;
                    SqlCommand cmd = con.CreateCommand();
                    StudentFileds stobj = new StudentFileds();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from Student where StudentId='" + cboStId.Text.Trim() + "'";
                    con.Open();
                    cout = cmd.ExecuteNonQuery();
                    if (cout > 0)
                    {
                        MessageBox.Show("Do You Want To Delete!");
                        lblMgs.Text = "Delete Successfully";

                        this.BackColor = Color.Red;
                        lblMgs.ForeColor = Color.Red;
                        lblMgs.Visible = true;
                        LoadDgDataView();
                        ComData();

                        cboStId.Select();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMgs.Visible = false;
            PicSave.Visible = false;

            this.BackColor = Color.White;

            btnSave.Enabled = true;
        }

        private void stCount()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select count(StudentId) as [Total Student] from Student";
                con.Open();
                object rsult = cmd.ExecuteScalar();
                lblTotal.Visible = true;
                lblTotal.ForeColor = Color.Green;
                lblTotal.Text =  "Total Student Count: - "+ rsult.ToString();
            }
        }

        private void btnLoDt_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDgDataView();
        }

        private void cboStId_Leave(object sender, EventArgs e)
        {
            //using (SqlConnection con=new SqlConnection(conStr))
            //{
            //    int count = 0;
            //    SqlCommand cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.Text ;
            //    cmd.CommandText = "Select StName,Phone,DateOfbirth,Email,Addresss from Student where StudentId='" + cboStId.Text.Trim() + "'";
            //    con.Open();
            //    count = cmd.ExecuteNonQuery();

            //    txtName.Text = GridStudent.Rows[0].ToString();
            //}
        }
    }
}
