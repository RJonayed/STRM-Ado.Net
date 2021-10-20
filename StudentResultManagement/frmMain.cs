using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentResultManagement
{   
    public partial class frmMain : Form
    {
        //fileds
        private Button currentbutton;
        private Random random;
        private int tepmIndex;
        private Form activateForm;
        //constructor
        public frmMain()
        {
            InitializeComponent();
            random = new Random();
            btnChildFormClose.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int hmsg,int wParam,int IParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemColor.ColorList.Count);
            while (tepmIndex==index)
            {
               index= random.Next(ThemColor.ColorList.Count);
            }
            tepmIndex = index;
            string color = ThemColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void activateButton(object btnSender)
        {
            DiseableButton();
            if (btnSender != null)
            {
                if (currentbutton != (Button)btnSender)
                {
                    Color color = SelectThemeColor();
                    currentbutton = (Button)btnSender;
                    currentbutton.BackColor = color;
                    currentbutton.ForeColor = Color.White;
                    currentbutton.Font= new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTiteleBar.BackColor = color;
                    PanelLogo.BackColor = ThemColor.ChangeColorBrithness(color, -0.3);

                    ThemColor.primaryColor = color;
                    ThemColor.secondColor = ThemColor.ChangeColorBrithness(color, -03);

                    btnChildFormClose.Visible = true;
                }
            }
        }
        private void DiseableButton()
        {
            foreach (Control previousbutton in ManuPanel.Controls)
            {
                if (previousbutton.GetType() == typeof(Button))
                {
                    previousbutton.BackColor = Color.FromArgb(51, 51, 76);
                    previousbutton.ForeColor = Color.Gainsboro;
                    previousbutton.Font=new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            activateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblHome.Text = childForm.Text;

        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmTspInfo(), sender);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // activateButton(sender);
            OpenChildForm(new Forms.frmTeacher(), sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //activateButton(sender);
            OpenChildForm(new Forms.frmStudent(), sender);
        }

        private void btnRpt_Click(object sender, EventArgs e)
        {
            //activateButton(sender);
            OpenChildForm(new Forms.frmCourseInfo(), sender);
        }

        private void btnNoti_Click(object sender, EventArgs e)
        {
            //activateButton(sender);
            OpenChildForm(new Forms.frmModule(), sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            //activateButton(sender);
            OpenChildForm(new Forms.frmAdmission(), sender);          
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbgTime.Text = "Login At :- " + DateTime.Now.ToString("HH:MM:ss:t");
            frmMain.ActiveForm.Select();
        }

        private void btnChildFormClose_Click(object sender, EventArgs e)
        {
            if (activateForm != null)
            {
                activateForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DiseableButton();
            lblHome.Text = "HOME";
            panelTiteleBar.BackColor = Color.FromArgb(0, 150, 136);
            PanelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentbutton = null;
            btnChildFormClose.Visible = false;
        }

        private void panelTiteleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmResult(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmReportView(), sender);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmSetting(), sender);
        }
    }
}
