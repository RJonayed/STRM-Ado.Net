
namespace StudentResultManagement.Forms
{
    partial class frmAdmission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmission));
            this.DtAdsDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboClsRoll = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdsCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GridAdmission = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTchName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCrsName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboMdlName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCrsCost = new System.Windows.Forms.TextBox();
            this.txtTchId = new System.Windows.Forms.TextBox();
            this.txtStId = new System.Windows.Forms.TextBox();
            this.txtCrsId = new System.Windows.Forms.TextBox();
            this.txtMdlId = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.PicSave = new System.Windows.Forms.PictureBox();
            this.lblMgs = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAdmission = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSrch = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DtAdsDate
            // 
            this.DtAdsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtAdsDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtAdsDate.Location = new System.Drawing.Point(119, 218);
            this.DtAdsDate.Name = "DtAdsDate";
            this.DtAdsDate.Size = new System.Drawing.Size(123, 24);
            this.DtAdsDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 82;
            this.label4.Text = "Admission Date";
            // 
            // cboClsRoll
            // 
            this.cboClsRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClsRoll.FormattingEnabled = true;
            this.cboClsRoll.Location = new System.Drawing.Point(119, 52);
            this.cboClsRoll.Name = "cboClsRoll";
            this.cboClsRoll.Size = new System.Drawing.Size(68, 26);
            this.cboClsRoll.TabIndex = 0;
            this.cboClsRoll.Leave += new System.EventHandler(this.cboClsRoll_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 80;
            this.label6.Text = "Student Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 25);
            this.label5.TabIndex = 79;
            this.label5.Text = "Student Admission Here..";
            // 
            // txtAdsCost
            // 
            this.txtAdsCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdsCost.Location = new System.Drawing.Point(119, 251);
            this.txtAdsCost.Name = "txtAdsCost";
            this.txtAdsCost.Size = new System.Drawing.Size(125, 24);
            this.txtAdsCost.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 72;
            this.label7.Text = "Admission Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Class Roll";
            // 
            // GridAdmission
            // 
            this.GridAdmission.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GridAdmission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridAdmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAdmission.Location = new System.Drawing.Point(300, 30);
            this.GridAdmission.Name = "GridAdmission";
            this.GridAdmission.Size = new System.Drawing.Size(456, 275);
            this.GridAdmission.TabIndex = 11;
            this.GridAdmission.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAdmission_CellDoubleClick);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadData.Image")));
            this.btnLoadData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadData.Location = new System.Drawing.Point(175, 332);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(90, 25);
            this.btnLoadData.TabIndex = 10;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(99, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 25);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(31, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Teacher Name";
            // 
            // cboTchName
            // 
            this.cboTchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTchName.FormattingEnabled = true;
            this.cboTchName.Location = new System.Drawing.Point(118, 85);
            this.cboTchName.Name = "cboTchName";
            this.cboTchName.Size = new System.Drawing.Size(125, 26);
            this.cboTchName.TabIndex = 1;
            this.cboTchName.TextChanged += new System.EventHandler(this.cboTchName_TextChanged);
            this.cboTchName.Leave += new System.EventHandler(this.cboTchName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 70;
            this.label3.Text = "Student Name";
            // 
            // cboStName
            // 
            this.cboStName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStName.FormattingEnabled = true;
            this.cboStName.Location = new System.Drawing.Point(118, 118);
            this.cboStName.Name = "cboStName";
            this.cboStName.Size = new System.Drawing.Size(125, 26);
            this.cboStName.TabIndex = 2;
            this.cboStName.TextChanged += new System.EventHandler(this.cboStName_TextChanged);
            this.cboStName.Leave += new System.EventHandler(this.cboStName_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 70;
            this.label8.Text = "Course Name";
            // 
            // cboCrsName
            // 
            this.cboCrsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCrsName.FormattingEnabled = true;
            this.cboCrsName.Location = new System.Drawing.Point(117, 151);
            this.cboCrsName.Name = "cboCrsName";
            this.cboCrsName.Size = new System.Drawing.Size(125, 26);
            this.cboCrsName.TabIndex = 3;
            this.cboCrsName.TextChanged += new System.EventHandler(this.cboCrsName_TextChanged);
            this.cboCrsName.Leave += new System.EventHandler(this.cboCrsName_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 70;
            this.label9.Text = "Module Name";
            // 
            // cboMdlName
            // 
            this.cboMdlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMdlName.FormattingEnabled = true;
            this.cboMdlName.Location = new System.Drawing.Point(117, 184);
            this.cboMdlName.Name = "cboMdlName";
            this.cboMdlName.Size = new System.Drawing.Size(125, 26);
            this.cboMdlName.TabIndex = 4;
            this.cboMdlName.TextChanged += new System.EventHandler(this.cboMdlName_TextChanged);
            this.cboMdlName.Leave += new System.EventHandler(this.cboMdlName_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 18);
            this.label10.TabIndex = 72;
            this.label10.Text = "Course Cost";
            // 
            // txtCrsCost
            // 
            this.txtCrsCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrsCost.Location = new System.Drawing.Point(119, 283);
            this.txtCrsCost.Name = "txtCrsCost";
            this.txtCrsCost.Size = new System.Drawing.Size(125, 24);
            this.txtCrsCost.TabIndex = 7;
            // 
            // txtTchId
            // 
            this.txtTchId.Location = new System.Drawing.Point(244, 89);
            this.txtTchId.Name = "txtTchId";
            this.txtTchId.Size = new System.Drawing.Size(47, 20);
            this.txtTchId.TabIndex = 84;
            this.txtTchId.Visible = false;
            // 
            // txtStId
            // 
            this.txtStId.Location = new System.Drawing.Point(244, 122);
            this.txtStId.Name = "txtStId";
            this.txtStId.Size = new System.Drawing.Size(47, 20);
            this.txtStId.TabIndex = 84;
            this.txtStId.Visible = false;
            // 
            // txtCrsId
            // 
            this.txtCrsId.Location = new System.Drawing.Point(244, 156);
            this.txtCrsId.Name = "txtCrsId";
            this.txtCrsId.Size = new System.Drawing.Size(47, 20);
            this.txtCrsId.TabIndex = 84;
            this.txtCrsId.Visible = false;
            // 
            // txtMdlId
            // 
            this.txtMdlId.Location = new System.Drawing.Point(244, 189);
            this.txtMdlId.Name = "txtMdlId";
            this.txtMdlId.Size = new System.Drawing.Size(47, 20);
            this.txtMdlId.TabIndex = 84;
            this.txtMdlId.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Location = new System.Drawing.Point(342, 324);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 16);
            this.lblTotal.TabIndex = 283;
            this.lblTotal.Text = "............";
            // 
            // PicSave
            // 
            this.PicSave.BackColor = System.Drawing.Color.Transparent;
            this.PicSave.Image = ((System.Drawing.Image)(resources.GetObject("PicSave.Image")));
            this.PicSave.Location = new System.Drawing.Point(426, 380);
            this.PicSave.Name = "PicSave";
            this.PicSave.Size = new System.Drawing.Size(97, 58);
            this.PicSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSave.TabIndex = 282;
            this.PicSave.TabStop = false;
            this.PicSave.Visible = false;
            // 
            // lblMgs
            // 
            this.lblMgs.AutoSize = true;
            this.lblMgs.BackColor = System.Drawing.Color.Transparent;
            this.lblMgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMgs.Location = new System.Drawing.Point(270, 400);
            this.lblMgs.Name = "lblMgs";
            this.lblMgs.Size = new System.Drawing.Size(36, 16);
            this.lblMgs.TabIndex = 281;
            this.lblMgs.Text = ".......";
            this.lblMgs.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAdmission
            // 
            this.btnAdmission.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdmission.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdmission.FlatAppearance.BorderSize = 2;
            this.btnAdmission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmission.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmission.Image")));
            this.btnAdmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmission.Location = new System.Drawing.Point(615, 324);
            this.btnAdmission.Name = "btnAdmission";
            this.btnAdmission.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAdmission.Size = new System.Drawing.Size(141, 30);
            this.btnAdmission.TabIndex = 284;
            this.btnAdmission.Text = "Admission Report";
            this.btnAdmission.UseVisualStyleBackColor = true;
            this.btnAdmission.Click += new System.EventHandler(this.btnAdmission_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(192, 51);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(43, 22);
            this.btnClear.TabIndex = 285;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSrch
            // 
            this.btnSrch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSrch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrch.Location = new System.Drawing.Point(504, 3);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(75, 22);
            this.btnSrch.TabIndex = 286;
            this.btnSrch.Text = "Search";
            this.btnSrch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSrch.UseVisualStyleBackColor = true;
            this.btnSrch.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.btnExit);
            this.pnlGrid.Controls.Add(this.txtSearch);
            this.pnlGrid.Controls.Add(this.label11);
            this.pnlGrid.Controls.Add(this.dataGridView1);
            this.pnlGrid.Location = new System.Drawing.Point(7, 400);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(789, 42);
            this.pnlGrid.TabIndex = 287;
            this.pnlGrid.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(781, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(8, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 29);
            this.label11.TabIndex = 1;
            this.label11.Text = "Search By Id,Nam,Mobile No";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(114, 6);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(295, 29);
            this.txtSearch.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(745, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.btnSrch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdmission);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.PicSave);
            this.Controls.Add(this.lblMgs);
            this.Controls.Add(this.txtMdlId);
            this.Controls.Add(this.txtCrsId);
            this.Controls.Add(this.txtStId);
            this.Controls.Add(this.txtTchId);
            this.Controls.Add(this.DtAdsDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMdlName);
            this.Controls.Add(this.cboCrsName);
            this.Controls.Add(this.cboStName);
            this.Controls.Add(this.cboTchName);
            this.Controls.Add(this.cboClsRoll);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCrsCost);
            this.Controls.Add(this.txtAdsCost);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridAdmission);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmission";
            this.Text = "Admission";
            this.Load += new System.EventHandler(this.frmAdmission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSave)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtAdsDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboClsRoll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdsCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridAdmission;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTchName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCrsName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboMdlName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCrsCost;
        private System.Windows.Forms.TextBox txtTchId;
        private System.Windows.Forms.TextBox txtStId;
        private System.Windows.Forms.TextBox txtCrsId;
        private System.Windows.Forms.TextBox txtMdlId;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox PicSave;
        private System.Windows.Forms.Label lblMgs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAdmission;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSrch;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}