
namespace StudentResultManagement
{
    partial class frmReportView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportView));
            this.label5 = new System.Windows.Forms.Label();
            this.btnRptTsp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnAdmissionRpt = new System.Windows.Forms.Button();
            this.btnModule = new System.Windows.Forms.Button();
            this.btnCrsInfo = new System.Windows.Forms.Button();
            this.btnStInfo = new System.Windows.Forms.Button();
            this.btnTchInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 25);
            this.label5.TabIndex = 299;
            this.label5.Text = "Welcome to Report Center";
            // 
            // btnRptTsp
            // 
            this.btnRptTsp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRptTsp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRptTsp.FlatAppearance.BorderSize = 2;
            this.btnRptTsp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnRptTsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRptTsp.Image = ((System.Drawing.Image)(resources.GetObject("btnRptTsp.Image")));
            this.btnRptTsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRptTsp.Location = new System.Drawing.Point(43, 18);
            this.btnRptTsp.Name = "btnRptTsp";
            this.btnRptTsp.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRptTsp.Size = new System.Drawing.Size(198, 30);
            this.btnRptTsp.TabIndex = 1;
            this.btnRptTsp.Text = "Training Information";
            this.btnRptTsp.UseVisualStyleBackColor = true;
            this.btnRptTsp.Click += new System.EventHandler(this.btnRptTsp_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(391, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 300);
            this.panel1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "Course / Class";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comboBox2.Location = new System.Drawing.Point(156, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(89, 22);
            this.comboBox2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Year";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(15, 139);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(89, 22);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "January ",
            "February",
            "March",
            "April",
            "May",
            "June ",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBox1.Location = new System.Drawing.Point(15, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 22);
            this.comboBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Form Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(156, 39);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(89, 22);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnResult);
            this.panel2.Controls.Add(this.btnAdmissionRpt);
            this.panel2.Controls.Add(this.btnModule);
            this.panel2.Controls.Add(this.btnCrsInfo);
            this.panel2.Controls.Add(this.btnStInfo);
            this.panel2.Controls.Add(this.btnTchInfo);
            this.panel2.Controls.Add(this.btnRptTsp);
            this.panel2.Location = new System.Drawing.Point(69, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 300);
            this.panel2.TabIndex = 0;
            // 
            // btnResult
            // 
            this.btnResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnResult.FlatAppearance.BorderSize = 2;
            this.btnResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Image = ((System.Drawing.Image)(resources.GetObject("btnResult.Image")));
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResult.Location = new System.Drawing.Point(43, 254);
            this.btnResult.Name = "btnResult";
            this.btnResult.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnResult.Size = new System.Drawing.Size(198, 30);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // btnAdmissionRpt
            // 
            this.btnAdmissionRpt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdmissionRpt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdmissionRpt.FlatAppearance.BorderSize = 2;
            this.btnAdmissionRpt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAdmissionRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmissionRpt.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmissionRpt.Image")));
            this.btnAdmissionRpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmissionRpt.Location = new System.Drawing.Point(43, 214);
            this.btnAdmissionRpt.Name = "btnAdmissionRpt";
            this.btnAdmissionRpt.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAdmissionRpt.Size = new System.Drawing.Size(198, 30);
            this.btnAdmissionRpt.TabIndex = 6;
            this.btnAdmissionRpt.Text = "Admission Information";
            this.btnAdmissionRpt.UseVisualStyleBackColor = true;
            this.btnAdmissionRpt.Click += new System.EventHandler(this.btnAdmissionRpt_Click);
            // 
            // btnModule
            // 
            this.btnModule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnModule.FlatAppearance.BorderSize = 2;
            this.btnModule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModule.Image = ((System.Drawing.Image)(resources.GetObject("btnModule.Image")));
            this.btnModule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModule.Location = new System.Drawing.Point(43, 178);
            this.btnModule.Name = "btnModule";
            this.btnModule.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnModule.Size = new System.Drawing.Size(198, 30);
            this.btnModule.TabIndex = 5;
            this.btnModule.Text = "All Module";
            this.btnModule.UseVisualStyleBackColor = true;
            // 
            // btnCrsInfo
            // 
            this.btnCrsInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrsInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCrsInfo.FlatAppearance.BorderSize = 2;
            this.btnCrsInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnCrsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrsInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnCrsInfo.Image")));
            this.btnCrsInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrsInfo.Location = new System.Drawing.Point(43, 138);
            this.btnCrsInfo.Name = "btnCrsInfo";
            this.btnCrsInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCrsInfo.Size = new System.Drawing.Size(198, 30);
            this.btnCrsInfo.TabIndex = 4;
            this.btnCrsInfo.Text = "Corse Details";
            this.btnCrsInfo.UseVisualStyleBackColor = true;
            this.btnCrsInfo.Click += new System.EventHandler(this.btnCrsInfo_Click);
            // 
            // btnStInfo
            // 
            this.btnStInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStInfo.FlatAppearance.BorderSize = 2;
            this.btnStInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnStInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnStInfo.Image")));
            this.btnStInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStInfo.Location = new System.Drawing.Point(43, 98);
            this.btnStInfo.Name = "btnStInfo";
            this.btnStInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnStInfo.Size = new System.Drawing.Size(198, 30);
            this.btnStInfo.TabIndex = 3;
            this.btnStInfo.Text = "Student Details";
            this.btnStInfo.UseVisualStyleBackColor = true;
            this.btnStInfo.Click += new System.EventHandler(this.btnStInfo_Click);
            // 
            // btnTchInfo
            // 
            this.btnTchInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTchInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTchInfo.FlatAppearance.BorderSize = 2;
            this.btnTchInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnTchInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTchInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnTchInfo.Image")));
            this.btnTchInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTchInfo.Location = new System.Drawing.Point(43, 58);
            this.btnTchInfo.Name = "btnTchInfo";
            this.btnTchInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTchInfo.Size = new System.Drawing.Size(198, 30);
            this.btnTchInfo.TabIndex = 2;
            this.btnTchInfo.Text = "Teacher Information";
            this.btnTchInfo.UseVisualStyleBackColor = true;
            this.btnTchInfo.Click += new System.EventHandler(this.btnTchInfo_Click);
            // 
            // frmReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Name = "frmReportView";
            this.Text = "Report Center";
            this.Load += new System.EventHandler(this.frmReportView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRptTsp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModule;
        private System.Windows.Forms.Button btnCrsInfo;
        private System.Windows.Forms.Button btnStInfo;
        private System.Windows.Forms.Button btnTchInfo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnAdmissionRpt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}