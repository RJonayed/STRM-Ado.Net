
namespace StudentResultManagement.Forms
{
    partial class frmCourseInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourseInfo));
            this.label4 = new System.Windows.Forms.Label();
            this.cboCoursId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRmk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GridCourse = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.PicSave = new System.Windows.Forms.PictureBox();
            this.lblMgs = new System.Windows.Forms.Label();
            this.cboDuratin = new System.Windows.Forms.ComboBox();
            this.chkMonth = new System.Windows.Forms.CheckBox();
            this.chkYear = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 82;
            this.label4.Text = "Cost of Course";
            // 
            // cboCoursId
            // 
            this.cboCoursId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCoursId.FormattingEnabled = true;
            this.cboCoursId.Location = new System.Drawing.Point(119, 53);
            this.cboCoursId.Name = "cboCoursId";
            this.cboCoursId.Size = new System.Drawing.Size(128, 26);
            this.cboCoursId.TabIndex = 0;
            this.cboCoursId.Leave += new System.EventHandler(this.cboCoursId_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(300, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 80;
            this.label6.Text = "Course Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 79;
            this.label5.Text = "Course Details...";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(13, 89);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(48, 18);
            this.lbl.TabIndex = 77;
            this.lbl.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 75;
            this.label3.Text = "Duration";
            // 
            // txtRmk
            // 
            this.txtRmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRmk.Location = new System.Drawing.Point(119, 181);
            this.txtRmk.Name = "txtRmk";
            this.txtRmk.Size = new System.Drawing.Size(128, 24);
            this.txtRmk.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 72;
            this.label7.Text = "Remarks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Course ID";
            // 
            // GridCourse
            // 
            this.GridCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCourse.Location = new System.Drawing.Point(298, 31);
            this.GridCourse.Name = "GridCourse";
            this.GridCourse.ReadOnly = true;
            this.GridCourse.Size = new System.Drawing.Size(421, 275);
            this.GridCourse.TabIndex = 9;
            this.GridCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCourse_CellClick);
            this.GridCourse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCourse_CellDoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(173, 276);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 25);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Load Data";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(99, 276);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 25);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(31, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 25);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(119, 149);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(128, 24);
            this.txtCost.TabIndex = 4;
            // 
            // cboName
            // 
            this.cboName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(119, 85);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(128, 26);
            this.cboName.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Location = new System.Drawing.Point(343, 320);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 16);
            this.lblTotal.TabIndex = 277;
            this.lblTotal.Text = "............";
            // 
            // PicSave
            // 
            this.PicSave.BackColor = System.Drawing.Color.Transparent;
            this.PicSave.Image = ((System.Drawing.Image)(resources.GetObject("PicSave.Image")));
            this.PicSave.Location = new System.Drawing.Point(405, 367);
            this.PicSave.Name = "PicSave";
            this.PicSave.Size = new System.Drawing.Size(97, 58);
            this.PicSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSave.TabIndex = 276;
            this.PicSave.TabStop = false;
            this.PicSave.Visible = false;
            // 
            // lblMgs
            // 
            this.lblMgs.AutoSize = true;
            this.lblMgs.BackColor = System.Drawing.Color.Transparent;
            this.lblMgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMgs.Location = new System.Drawing.Point(246, 388);
            this.lblMgs.Name = "lblMgs";
            this.lblMgs.Size = new System.Drawing.Size(36, 16);
            this.lblMgs.TabIndex = 275;
            this.lblMgs.Text = ".......";
            this.lblMgs.Visible = false;
            // 
            // cboDuratin
            // 
            this.cboDuratin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDuratin.FormattingEnabled = true;
            this.cboDuratin.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboDuratin.Location = new System.Drawing.Point(119, 117);
            this.cboDuratin.Name = "cboDuratin";
            this.cboDuratin.Size = new System.Drawing.Size(76, 26);
            this.cboDuratin.TabIndex = 1;
            // 
            // chkMonth
            // 
            this.chkMonth.AutoSize = true;
            this.chkMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonth.Location = new System.Drawing.Point(197, 122);
            this.chkMonth.Name = "chkMonth";
            this.chkMonth.Size = new System.Drawing.Size(56, 17);
            this.chkMonth.TabIndex = 278;
            this.chkMonth.Text = "Month";
            this.chkMonth.UseVisualStyleBackColor = true;
            // 
            // chkYear
            // 
            this.chkYear.AutoSize = true;
            this.chkYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYear.Location = new System.Drawing.Point(249, 123);
            this.chkYear.Name = "chkYear";
            this.chkYear.Size = new System.Drawing.Size(48, 17);
            this.chkYear.TabIndex = 279;
            this.chkYear.Text = "Year";
            this.chkYear.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkYear);
            this.Controls.Add(this.chkMonth);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.PicSave);
            this.Controls.Add(this.lblMgs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboDuratin);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.cboCoursId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtRmk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridCourse);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Name = "frmCourseInfo";
            this.Text = "Course Details";
            this.Load += new System.EventHandler(this.frmCourseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCoursId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRmk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridCourse;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox PicSave;
        private System.Windows.Forms.Label lblMgs;
        private System.Windows.Forms.ComboBox cboDuratin;
        private System.Windows.Forms.CheckBox chkMonth;
        private System.Windows.Forms.CheckBox chkYear;
        private System.Windows.Forms.Timer timer1;
    }
}