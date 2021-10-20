
namespace StudentResultManagement
{
    partial class frmRptTsp
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
            this.RptTsp = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // RptTsp
            // 
            this.RptTsp.ActiveViewIndex = -1;
            this.RptTsp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RptTsp.Cursor = System.Windows.Forms.Cursors.Default;
            this.RptTsp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RptTsp.Location = new System.Drawing.Point(0, 0);
            this.RptTsp.Name = "RptTsp";
            this.RptTsp.Size = new System.Drawing.Size(800, 450);
            this.RptTsp.TabIndex = 0;
            this.RptTsp.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRptTsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RptTsp);
            this.Name = "frmRptTsp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training Center Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRptTsp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RptTsp;
    }
}